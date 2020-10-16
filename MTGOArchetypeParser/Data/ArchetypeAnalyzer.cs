using MTGOArchetypeParser.Model;
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

        public static ArchetypeResult Detect(Card[] mainboardCards, Card[] sideboardCards, Archetype[] archetypeData)
        {
            ArchetypeSpecific[] specificArchetypes = archetypeData.Where(a => a is ArchetypeSpecific && !(a is ArchetypeVariant)).Select(a => a as ArchetypeSpecific).ToArray();
            ArchetypeGeneric[] genericArchetypes = archetypeData.Where(a => a is ArchetypeGeneric).Select(a => a as ArchetypeGeneric).ToArray();

            ArchetypeCompanion? companion = GetCompanion(mainboardCards, sideboardCards);
            ArchetypeColor color = GetColors(mainboardCards, sideboardCards);

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
                                results.Add(new ArchetypeMatch() { Archetype = archetype, Variant = variant });
                            }
                        }
                    }
                    if (!isVariant) results.Add(new ArchetypeMatch() { Archetype = archetype, Variant = null, });
                }
            }

            if (results.Count == 0)
            {
                Archetype genericArchetype = GetBestGenericArchetype(mainboardCards, sideboardCards, color, genericArchetypes);
                if (genericArchetype != null) results.Add(new ArchetypeMatch() { Archetype = genericArchetype, Variant = null, });
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

        private static ArchetypeColor GetColors(Card[] mainboardCards, Card[] sideboardCards)
        {
            StringBuilder colorsFound = new StringBuilder();
            foreach (var card in mainboardCards)
            {
                if (ArchetypeLands.Lands.ContainsKey(card.Name))
                {
                    colorsFound.Append(ArchetypeLands.Lands[card.Name]);
                }
            }
            foreach (var card in sideboardCards)
            {
                if (ArchetypeLands.Lands.ContainsKey(card.Name))
                {
                    colorsFound.Append(ArchetypeLands.Lands[card.Name]);
                }
            }

            string finalColor = String.Empty;
            if (colorsFound.ToString().Contains("W")) finalColor += "W";
            if (colorsFound.ToString().Contains("U")) finalColor += "U";
            if (colorsFound.ToString().Contains("B")) finalColor += "B";
            if (colorsFound.ToString().Contains("R")) finalColor += "R";
            if (colorsFound.ToString().Contains("G")) finalColor += "G";

            return finalColor.Length > 0 ? (ArchetypeColor)Enum.Parse(typeof(ArchetypeColor), finalColor) : ArchetypeColor.C; ;
        }

        private static bool Test(Card[] mainboardCards, Card[] sideboardCards, ArchetypeColor color, ArchetypeSpecific archetypeData)
        {
            foreach (var condition in archetypeData.Conditions)
            {
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
                    case ArchetypeConditionType.TwoOrMoreInMainboard:
                        if (mainboardCards.Where(c => condition.Cards.Contains(c.Name)).Count() < 2) return false;
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
                    case ArchetypeConditionType.ColorIsExactly:
                        if (condition.Color != color) return false;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            return true;
        }

        private static Archetype GetBestGenericArchetype(Card[] mainboardCards, Card[] sideboardCards, ArchetypeColor color, ArchetypeGeneric[] genericArchetypes)
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

                if (genericArchetype.RequiredCards != null && genericArchetype.RequiredCards.Length > 0)
                {
                    foreach (var requiredCard in genericArchetype.RequiredCards)
                    {
                        if (!mainboardCards.Concat(sideboardCards).Distinct().Any(c => c.Name == requiredCard))
                        {
                            weights[genericArchetype] = -1;
                        }
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
                return weights.Where(k => k.Value == max).ToArray().OrderBy(k => k.Key.CommonCards.Length).First().Key;
            }
        }
    }
}
