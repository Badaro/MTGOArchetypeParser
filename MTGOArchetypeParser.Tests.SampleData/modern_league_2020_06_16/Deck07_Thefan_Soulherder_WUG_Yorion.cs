using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck07_Thefan_Soulherder_WUG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eternal Witness"),(4, "Ice-Fang Coatl"),(1, "Knight of Autumn"),(1, "Meddling Mage"),(4, "Noble Hierarch"),(1, "Scavenging Ooze"),(1, "Soulherder"),(4, "Stoneforge Mystic"),(1, "Stonehorn Dignitary"),(2, "Uro, Titan of Nature's Wrath"),(1, "Venser, Shaper Savant"),(2, "Cryptic Command"),(4, "Eladamri's Call"),(4, "Ephemerate"),(4, "Path to Exile"),(3, "Remand"),(4, "Aether Vial"),(4, "Arcum's Astrolabe"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(1, "Sword of Fire and Ice"),(1, "Breeding Pool"),(4, "Flooded Strand"),(1, "Hallowed Fountain"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(2, "Polluted Delta"),(1, "Prairie Stream"),(3, "Snow-Covered Forest"),(3, "Snow-Covered Island"),(2, "Snow-Covered Plains"),(1, "Temple Garden"),(4, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(3, "Ashiok, Dream Render"),(1, "Burrenton Forge-Tender"),(1, "Collector Ouphe"),(1, "Deputy of Detention"),(2, "Disdainful Stroke"),(1, "Dovin's Veto"),(1, "Gaddock Teeg"),(1, "Lavinia of the Tenth"),(1, "Yorion, Sky Nomad") }; } }
    }
}