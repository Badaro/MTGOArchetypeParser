using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14
{
    public class Deck08_TSPJendrek_SnowControl_UBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(3, "Wrenn and Six"),(4, "Ice-Fang Coatl"),(2, "Snapcaster Mage"),(3, "Uro, Titan of Nature's Wrath"),(2, "Abrupt Decay"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(1, "Deprive"),(4, "Fatal Push"),(3, "Force of Negation"),(2, "Mana Leak"),(4, "Arcum's Astrolabe"),(1, "Breeding Pool"),(2, "Field of Ruin"),(1, "Lonely Sandbar"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(4, "Polluted Delta"),(1, "Scalding Tarn"),(1, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(1, "Steam Vents"),(1, "Stomping Ground"),(1, "Watery Grave"),(1, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(2, "Ashiok, Dream Render"),(1, "Blood Moon"),(2, "Dead of Winter"),(2, "Mystical Dispute"),(1, "Nihil Spellbomb"),(2, "Notion Thief"),(2, "Veil of Summer") }; } }
    }
}