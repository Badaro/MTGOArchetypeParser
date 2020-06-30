using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_06
{
    public class Deck14_nielsen333_JeskaiControl_JeskaiStoneblade_WUR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Snapcaster Mage"),(3, "Stoneforge Mystic"),(2, "Supreme Verdict"),(2, "Cryptic Command"),(1, "Electrolyze"),(4, "Lightning Bolt"),(4, "Lightning Helix"),(2, "Logic Knot"),(2, "Mana Leak"),(4, "Opt"),(4, "Path to Exile"),(2, "Sphinx's Revelation"),(1, "Batterskull"),(1, "Sword of Fire and Ice"),(4, "Celestial Colonnade"),(4, "Flooded Strand"),(2, "Hallowed Fountain"),(1, "Island"),(1, "Mountain"),(1, "Plains"),(2, "Sacred Foundry"),(4, "Scalding Tarn"),(2, "Seachrome Coast"),(1, "Spirebluff Canal"),(2, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Supreme Verdict"),(2, "Aether Gust"),(3, "Anger of the Gods"),(1, "Celestial Purge"),(1, "Disdainful Stroke"),(2, "Force of Negation"),(1, "Negate"),(2, "Relic of Progenitus"),(2, "Rest in Peace") }; } }
    }
}