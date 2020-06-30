using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck05_Blitzlion27_Mill_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Hedron Crab"),(4, "Manic Scribe"),(1, "Breaking // Entering"),(4, "Glimpse the Unthinkable"),(4, "Archive Trap"),(1, "Crypt Incursion"),(4, "Drown in the Loch"),(4, "Fatal Push"),(4, "Surgical Extraction"),(4, "Visions of Beyond"),(4, "Mesmeric Orb"),(2, "Darkslick Shores"),(4, "Field of Ruin"),(1, "Oboro, Palace in the Clouds"),(4, "Polluted Delta"),(2, "Prismatic Vista"),(1, "Shelldock Isle"),(4, "Snow-Covered Island"),(2, "Snow-Covered Swamp"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(2, "Ashiok, Dream Render"),(1, "Ashiok, Nightmare Weaver"),(2, "Collective Brutality"),(2, "Echoing Truth"),(1, "Extirpate"),(2, "Grafdigger's Cage"),(3, "Mystical Dispute") }; } }
    }
}