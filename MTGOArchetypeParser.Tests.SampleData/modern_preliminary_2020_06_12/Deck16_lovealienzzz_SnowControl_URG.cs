using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12
{
    public class Deck16_lovealienzzz_SnowControl_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Wrenn and Six"),(2, "Brazen Borrower"),(4, "Ice-Fang Coatl"),(2, "Snapcaster Mage"),(3, "Uro, Titan of Nature's Wrath"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(2, "Force of Negation"),(4, "Lightning Bolt"),(2, "Mana Leak"),(2, "Spell Snare"),(4, "Thought Scour"),(4, "Arcum's Astrolabe"),(2, "Blood Moon"),(2, "Breeding Pool"),(2, "Flooded Strand"),(1, "Ketria Triome"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(4, "Scalding Tarn"),(1, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(1, "Steam Vents"),(1, "Stomping Ground") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Abrade"),(2, "Aether Gust"),(2, "Anger of the Gods"),(2, "Ashiok, Dream Render"),(2, "Ceremonious Rejection"),(1, "Engineered Explosives"),(1, "Pulse of Murasa"),(1, "Soul-Guide Lantern"),(2, "Veil of Summer"),(1, "Weather the Storm") }; } }
    }
}