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

        public static ArchetypeResult[] Detect(string[] mainboardCards, string[] sideboardCards, Archetype[] archetypeData)
        {
            ArchetypeCompanion? companion = null;
            foreach (var possibleCompanion in _companionMap)
            {
                if (sideboardCards.Contains(possibleCompanion.Key)) companion = possibleCompanion.Value;
            }

            List<ArchetypeResult> results = new List<ArchetypeResult>();
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
                                results.Add(new ArchetypeResult() { Archetype = archetype, Variant = variant, Companion = companion });
                            }
                        }
                    }
                    if (!isVariant) results.Add(new ArchetypeResult() { Archetype = archetype, Variant = null, Companion = companion });
                }
            }

            return results.ToArray();
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
                    case ArchetypeConditionType.OneOfInMainboard:
                        if (!mainboardCards.Any(c => condition.Cards.Contains(c))) return false;
                        break;
                    case ArchetypeConditionType.OneOfInSideboard:
                        if (!sideboardCards.Any(c => condition.Cards.Contains(c))) return false;
                        break;
                    case ArchetypeConditionType.OneOfInMainOrSideboard:
                        if (!mainboardCards.Any(c => condition.Cards.Contains(c)) && !sideboardCards.Any(c => condition.Cards.Contains(c))) return false;
                        break;
                    case ArchetypeConditionType.DoesNotContain:
                        if (mainboardCards.Any(c => c == condition.Cards[0]) || sideboardCards.Any(c => c == condition.Cards[0])) return false;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            return true;
        }
    }
}
