using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck03_Janh_SnowControl_SultaiSnow_UBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Ashiok, Nightmare Muse"),(3, "Jace, the Mind Sculptor"),(1, "Liliana, the Last Hope"),(4, "Ice-Fang Coatl"),(2, "Snapcaster Mage"),(3, "Uro, Titan of Nature's Wrath"),(2, "Dead of Winter"),(1, "Abrupt Decay"),(2, "Archmage's Charm"),(1, "Cling to Dust"),(2, "Cryptic Command"),(4, "Fatal Push"),(3, "Force of Negation"),(3, "Mana Leak"),(4, "Arcum's Astrolabe"),(1, "Breeding Pool"),(4, "Field of Ruin"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(1, "Overgrown Tomb"),(4, "Polluted Delta"),(1, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Abrupt Decay"),(1, "Dead of Winter"),(4, "Aether Gust"),(2, "Ashiok, Dream Render"),(1, "Assassin's Trophy"),(1, "Negate"),(3, "Shark Typhoon"),(1, "Soul-Guide Lantern"),(1, "Veil of Summer") }; } }
    }
}