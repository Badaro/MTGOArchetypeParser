using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_10
{
    public class Deck19_mauricio998_Mill_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(3, "Manic Scribe"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(4, "Archive Trap"),
            new SampleCard(2, "Crypt Incursion"),
            new SampleCard(4, "Drown in the Loch"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Surgical Extraction"),
            new SampleCard(4, "Visions of Beyond"),
            new SampleCard(4, "Mesmeric Orb"),
            new SampleCard(1, "Search for Azcanta"),
            new SampleCard(2, "Darkslick Shores"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Island"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Prismatic Vista"),
            new SampleCard(1, "Shelldock Isle"),
            new SampleCard(2, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Bontu's Last Reckoning"),
            new SampleCard(1, "Damnation"),
            new SampleCard(2, "Echoing Truth"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Ensnaring Bridge"),
            new SampleCard(1, "Extirpate"),
            new SampleCard(2, "Mystical Dispute") 
        };
    }
}