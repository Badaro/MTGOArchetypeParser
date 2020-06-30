using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck13_lovealienzzz_SnowControl_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Brazen Borrower"),(4, "Ice-Fang Coatl"),(3, "Snapcaster Mage"),(3, "Uro, Titan of Nature's Wrath"),(3, "Archmage's Charm"),(2, "Cryptic Command"),(3, "Force of Negation"),(4, "Lightning Bolt"),(1, "Magmatic Sinkhole"),(2, "Mana Leak"),(4, "Opt"),(2, "Spell Snare"),(4, "Arcum's Astrolabe"),(1, "Breeding Pool"),(2, "Flooded Strand"),(1, "Ketria Triome"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(4, "Scalding Tarn"),(1, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(1, "Steam Vents"),(1, "Stomping Ground") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(2, "Anger of the Gods"),(2, "Ashiok, Dream Render"),(2, "Blood Moon"),(2, "Ceremonious Rejection"),(3, "Veil of Summer"),(1, "Weather the Storm") }; } }
    }
}