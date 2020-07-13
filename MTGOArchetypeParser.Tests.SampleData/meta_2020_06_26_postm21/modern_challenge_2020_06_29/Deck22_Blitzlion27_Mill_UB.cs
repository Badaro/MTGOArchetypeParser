using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_06_29
{
    public class Deck22_Blitzlion27_Mill_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(2, "Thing in the Ice"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(4, "Archive Trap"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(1, "Crypt Incursion"),
            new SampleCard(4, "Drown in the Loch"),
            new SampleCard(2, "Eliminate"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Surgical Extraction"),
            new SampleCard(4, "Visions of Beyond"),
            new SampleCard(4, "Mesmeric Orb"),
            new SampleCard(2, "Darkslick Shores"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Prismatic Vista"),
            new SampleCard(1, "Shelldock Isle"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Crypt Incursion"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(2, "Infernal Reckoning"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(3, "Plague Engineer") 
        };
    }
}