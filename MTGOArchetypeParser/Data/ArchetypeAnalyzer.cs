﻿using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MTGOArchetypeParser.Data
{
    public static class ArchetypeAnalyzer
    {
        public static Dictionary<string, ArchetypeCompanion> _companionMap = new Dictionary<string, ArchetypeCompanion>()
        {
            { "Gyruda, Doom of Depths", ArchetypeCompanion.Gyruda },
            {"Jegantha, the Wellspring", ArchetypeCompanion.Jegantha },
            {"Kaheera, the Orphanguard", ArchetypeCompanion.Kaheera  },
            {"Keruga, the Macrosage", ArchetypeCompanion.Keruga },
            {"Lurrus of the Dream-Den", ArchetypeCompanion.Lurrus },
            {"Lutri, the Spellchaser", ArchetypeCompanion.Lutri },
            {"Obosh, the Preypiercer", ArchetypeCompanion.Obosh },
            {"Umori, the Collector",  ArchetypeCompanion.Umori},
            {"Yorion, Sky Nomad",  ArchetypeCompanion.Yorion},
            {"Zirda, the Dawnwaker", ArchetypeCompanion.Zirda }
        };

        public static ArchetypeResult Detect(Card[] mainboardCards, Card[] sideboardCards, ArchetypeFormat format, double minSimiliarity = 0.1, ConflictSolvingMode conflictSolvingMode = ConflictSolvingMode.None)
        {
            Archetype[] archetypeData = format.Archetypes;
            Dictionary<string, ArchetypeColor> landColors = format.Lands;
            Dictionary<string, ArchetypeColor> cardColors = format.NonLands;

            ArchetypeSpecific[] specificArchetypes = archetypeData.Where(a => a is ArchetypeSpecific && !(a is ArchetypeVariant)).Select(a => a as ArchetypeSpecific).ToArray();
            ArchetypeGeneric[] genericArchetypes = archetypeData.Where(a => a is ArchetypeGeneric).Select(a => a as ArchetypeGeneric).ToArray();

            ArchetypeCompanion? companion = GetCompanion(mainboardCards, sideboardCards);
            ArchetypeColor color = GetColors(mainboardCards, sideboardCards, landColors, cardColors);

            List<ArchetypeMatch> results = new List<ArchetypeMatch>();
            foreach (ArchetypeSpecific archetype in specificArchetypes)
            {
                if (Test(mainboardCards, sideboardCards, color, archetype))
                {
                    bool isVariant = false;
                    if (archetype.Variants != null)
                    {
                        foreach (ArchetypeSpecific variant in archetype.Variants)
                        {
                            if (Test(mainboardCards, sideboardCards, color, variant))
                            {
                                isVariant = true;
                                results.Add(new ArchetypeMatch() { Archetype = archetype, Variant = variant, Similarity = 1 });
                            }
                        }
                    }
                    if (!isVariant) results.Add(new ArchetypeMatch() { Archetype = archetype, Variant = null, Similarity = 1 });
                }
            }

            if (results.Count == 0)
            {
                ArchetypeMatch genericArchetype = GetBestGenericArchetype(mainboardCards, sideboardCards, color, genericArchetypes);
                if (genericArchetype != null && genericArchetype.Similarity > minSimiliarity) results.Add(genericArchetype);
            }
            else
            {
                if (results.Count > 1 && conflictSolvingMode == ConflictSolvingMode.PreferSimpler)
                {
                    results = results.OrderBy(r => r.Archetype.GetComplexity() + (r.Variant != null ? r.Variant.GetComplexity() : 0)).Take(1).ToList();
                }
            }

            return new ArchetypeResult() { Matches = results.ToArray(), Color = color, Companion = companion };
        }

        private static ArchetypeCompanion? GetCompanion(Card[] mainboardCards, Card[] sideboardCards)
        {
            ArchetypeCompanion? companion = null;
            foreach (var possibleCompanion in _companionMap)
            {
                if (sideboardCards.Any(c => c.Name == possibleCompanion.Key)) companion = possibleCompanion.Value;
            }
            return companion;
        }

        private static ArchetypeColor GetColors(Card[] mainboardCards, Card[] sideboardCards, Dictionary<string, ArchetypeColor> landColors, Dictionary<string, ArchetypeColor> cardColors)
        {
            Dictionary<char, int> colorsInLands = new Dictionary<char, int>();
            colorsInLands.Add('W', 0);
            colorsInLands.Add('U', 0);
            colorsInLands.Add('B', 0);
            colorsInLands.Add('R', 0);
            colorsInLands.Add('G', 0);

            Dictionary<char, int> colorsInNonLands = new Dictionary<char, int>();
            colorsInNonLands.Add('W', 0);
            colorsInNonLands.Add('U', 0);
            colorsInNonLands.Add('B', 0);
            colorsInNonLands.Add('R', 0);
            colorsInNonLands.Add('G', 0);

            StringBuilder colorsFound = new StringBuilder();
            foreach (var card in mainboardCards.Concat(sideboardCards))
            {
                if (landColors.ContainsKey(card.Name))
                {
                    foreach (var color in landColors[card.Name].ToString())
                    {
                        colorsInLands[color] += card.Count;
                    }
                }
                if (cardColors.ContainsKey(card.Name))
                {
                    foreach (var color in cardColors[card.Name].ToString())
                    {
                        colorsInNonLands[color] += card.Count;
                    }
                }
            }

            string finalColor = String.Empty;
            if (colorsInLands['W'] > 0 && colorsInNonLands['W'] > 0) finalColor += "W";
            if (colorsInLands['U'] > 0 && colorsInNonLands['U'] > 0) finalColor += "U";
            if (colorsInLands['B'] > 0 && colorsInNonLands['B'] > 0) finalColor += "B";
            if (colorsInLands['R'] > 0 && colorsInNonLands['R'] > 0) finalColor += "R";
            if (colorsInLands['G'] > 0 && colorsInNonLands['G'] > 0) finalColor += "G";

            return finalColor.Length > 0 ? (ArchetypeColor)Enum.Parse(typeof(ArchetypeColor), finalColor) : ArchetypeColor.C; ;
        }

        private static bool Test(Card[] mainboardCards, Card[] sideboardCards, ArchetypeColor color, ArchetypeSpecific archetypeData)
        {
            foreach (var condition in archetypeData.Conditions)
            {
                if (condition.Cards == null || condition.Cards.Length == 0) continue; // Skips broken condition

                switch (condition.Type)
                {
                    case ArchetypeConditionType.InMainboard:
                        if (!mainboardCards.Any(c => c.Name == condition.Cards[0])) return false;
                        break;
                    case ArchetypeConditionType.InSideboard:
                        if (!sideboardCards.Any(c => c.Name == condition.Cards[0])) return false;
                        break;
                    case ArchetypeConditionType.InMainOrSideboard:
                        if (!mainboardCards.Any(c => c.Name == condition.Cards[0]) && !sideboardCards.Any(c => c.Name == condition.Cards[0])) return false;
                        break;
                    case ArchetypeConditionType.OneOrMoreInMainboard:
                        if (!mainboardCards.Any(c => condition.Cards.Contains(c.Name))) return false;
                        break;
                    case ArchetypeConditionType.OneOrMoreInSideboard:
                        if (!sideboardCards.Any(c => condition.Cards.Contains(c.Name))) return false;
                        break;
                    case ArchetypeConditionType.OneOrMoreInMainOrSideboard:
                        if (!mainboardCards.Any(c => condition.Cards.Contains(c.Name)) && !sideboardCards.Any(c => condition.Cards.Contains(c.Name))) return false;
                        break;
                    case ArchetypeConditionType.TwoOrMoreInMainboard:
                        if (mainboardCards.Where(c => condition.Cards.Contains(c.Name)).Count() < 2) return false;
                        break;
                    case ArchetypeConditionType.TwoOrMoreInSideboard:
                        if (sideboardCards.Where(c => condition.Cards.Contains(c.Name)).Count() < 2) return false;
                        break;
                    case ArchetypeConditionType.TwoOrMoreInMainOrSideboard:
                        if ((mainboardCards.Where(c => condition.Cards.Contains(c.Name)).Count() + sideboardCards.Where(c => condition.Cards.Contains(c.Name)).Count()) < 2) return false;
                        break;
                    case ArchetypeConditionType.DoesNotContain:
                        if (mainboardCards.Any(c => c.Name == condition.Cards[0]) || sideboardCards.Any(c => c.Name == condition.Cards[0])) return false;
                        break;
                    case ArchetypeConditionType.DoesNotContainMainboard:
                        if (mainboardCards.Any(c => c.Name == condition.Cards[0])) return false;
                        break;
                    case ArchetypeConditionType.DoesNotContainSideboard:
                        if (sideboardCards.Any(c => c.Name == condition.Cards[0])) return false;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            return true;
        }

        private static ArchetypeMatch GetBestGenericArchetype(Card[] mainboardCards, Card[] sideboardCards, ArchetypeColor color, ArchetypeGeneric[] genericArchetypes)
        {
            Dictionary<ArchetypeGeneric, int> weights = new Dictionary<ArchetypeGeneric, int>();

            foreach (ArchetypeGeneric genericArchetype in genericArchetypes)
            {
                weights.Add(genericArchetype, 0);
                foreach (var card in mainboardCards.Concat(sideboardCards).Distinct())
                {

                    if (genericArchetype.CommonCards.Contains(card.Name))
                    {
                        weights[genericArchetype] += card.Count;
                    }
                }
            }

            if (weights.All(k => k.Value == 0))
            {
                return null;
            }
            else
            {
                int max = weights.Max(k => k.Value);
                KeyValuePair<ArchetypeGeneric, int> bestMatch = weights.Where(k => k.Value == max).ToArray().OrderBy(k => k.Key.CommonCards.Length).First();
                return new ArchetypeMatch() { Archetype = bestMatch.Key, Variant = null, Similarity = ((double)max) / ((double)(mainboardCards.Length + sideboardCards.Length)) };
            }
        }
    }
}
