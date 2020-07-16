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
            {"Lurrus of the Dream Den", ArchetypeCompanion.Lurrus },
            {"Lutri, the Spellchaser", ArchetypeCompanion.Lutri },
            {"Obosh, the Preypiercer", ArchetypeCompanion.Obosh },
            {"Umori, the Collector",  ArchetypeCompanion.Umori},
            {"Yorion, Sky Nomad",  ArchetypeCompanion.Yorion},
            {"Zirda, the Dawnwaker", ArchetypeCompanion.Zirda }
        };

        public static ArchetypeResult Detect(string[] mainboardCards, string[] sideboardCards, Archetype[] archetypeData)
        {
            ArchetypeCompanion? companion = GetCompanion(mainboardCards, sideboardCards);
            ArchetypeColor color = GetColors(mainboardCards, sideboardCards);

            List<ArchetypeMatch> results = new List<ArchetypeMatch>();
            foreach (Archetype archetype in archetypeData)
            {
                if (Test(mainboardCards, sideboardCards, archetype))
                {
                    bool isVariant = false;
                    if (archetype.Variants != null)
                    {
                        foreach (Archetype variant in archetype.Variants)
                        {
                            if (Test(mainboardCards, sideboardCards, variant))
                            {
                                isVariant = true;
                                results.Add(new ArchetypeMatch() { Archetype = archetype, Variant = variant });
                            }
                        }
                    }
                    if (!isVariant) results.Add(new ArchetypeMatch() { Archetype = archetype, Variant = null, });
                }
            }

            return new ArchetypeResult() { Matches = results.ToArray(), Color = color, Companion = companion };
        }

        private static ArchetypeCompanion? GetCompanion(string[] mainboardCards, string[] sideboardCards)
        {
            ArchetypeCompanion? companion = null;
            foreach (var possibleCompanion in _companionMap)
            {
                if (sideboardCards.Contains(possibleCompanion.Key)) companion = possibleCompanion.Value;
            }
            return companion;
        }

        private static ArchetypeColor GetColors(string[] mainboardCards, string[] sideboardCards)
        {
            StringBuilder colorsFound = new StringBuilder();
            foreach (var card in mainboardCards)
            {
                if (ArchetypeLands.Lands.ContainsKey(card))
                {
                    colorsFound.Append(ArchetypeLands.Lands[card]);
                }
            }
            foreach (var card in sideboardCards)
            {
                if (ArchetypeLands.Lands.ContainsKey(card))
                {
                    colorsFound.Append(ArchetypeLands.Lands[card]);
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

        private static bool Test(string[] mainboardCards, string[] sideboardCards, Archetype archetypeData)
        {
            foreach (var condition in archetypeData.Conditions)
            {
                switch (condition.Type)
                {
                    case ArchetypeConditionType.InMainboard:
                        if (!mainboardCards.Any(c => c == condition.Cards[0])) return false;
                        break;
                    case ArchetypeConditionType.InSideboard:
                        if (!sideboardCards.Any(c => c == condition.Cards[0])) return false;
                        break;
                    case ArchetypeConditionType.InMainOrSideboard:
                        if (!mainboardCards.Any(c => c == condition.Cards[0]) && !sideboardCards.Any(c => c == condition.Cards[0])) return false;
                        break;
                    case ArchetypeConditionType.OneOrMoreInMainboard:
                        if (!mainboardCards.Any(c => condition.Cards.Contains(c))) return false;
                        break;
                    case ArchetypeConditionType.OneOrMoreInSideboard:
                        if (!sideboardCards.Any(c => condition.Cards.Contains(c))) return false;
                        break;
                    case ArchetypeConditionType.OneOrMoreInMainOrSideboard:
                        if (!mainboardCards.Any(c => condition.Cards.Contains(c)) && !sideboardCards.Any(c => condition.Cards.Contains(c))) return false;
                        break;
                    case ArchetypeConditionType.DoesNotContain:
                        if (mainboardCards.Any(c => c == condition.Cards[0]) || sideboardCards.Any(c => c == condition.Cards[0])) return false;
                        break;
                    case ArchetypeConditionType.DoesNotContainAll:
                        if (mainboardCards.Concat(sideboardCards).Distinct().Where(c => condition.Cards.Contains(c)).Count() == condition.Cards.Length) return false;
                        break;
                    case ArchetypeConditionType.TwoOrMoreInMainboard:
                        if (mainboardCards.Where(c => condition.Cards.Contains(c)).Count() < 2) return false;
                        break;
                    case ArchetypeConditionType.TwoOrMoreInSideboard:
                        if (sideboardCards.Where(c => condition.Cards.Contains(c)).Count() < 2) return false;
                        break;
                    case ArchetypeConditionType.TwoOrMoreInMainOrSideboard:
                        if (mainboardCards.Concat(sideboardCards).Distinct().Where(c => condition.Cards.Contains(c)).Count() < 2) return false;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            return true;
        }
    }
}
