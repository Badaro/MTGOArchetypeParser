using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck22_Blitzlion27_Mill_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Hedron Crab"),(2, "Thing in the Ice"),(4, "Glimpse the Unthinkable"),(4, "Archive Trap"),(2, "Cling to Dust"),(1, "Crypt Incursion"),(4, "Drown in the Loch"),(2, "Eliminate"),(4, "Fatal Push"),(4, "Surgical Extraction"),(4, "Visions of Beyond"),(4, "Mesmeric Orb"),(2, "Darkslick Shores"),(3, "Field of Ruin"),(1, "Oboro, Palace in the Clouds"),(4, "Polluted Delta"),(2, "Prismatic Vista"),(1, "Shelldock Isle"),(4, "Snow-Covered Island"),(2, "Snow-Covered Swamp"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Crypt Incursion"),(2, "Aether Gust"),(2, "Ashiok, Dream Render"),(2, "Collective Brutality"),(1, "Echoing Truth"),(2, "Infernal Reckoning"),(2, "Mystical Dispute"),(3, "Plague Engineer") }; } }
    }
}