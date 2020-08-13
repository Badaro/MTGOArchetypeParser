using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_showcase_last_chance_2020_08_11
{
    public class Deck06_tibaltofredsub_Mill_UB_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(3, "Manic Scribe"),
            new SampleCard(2, "Damnation"),
            new SampleCard(3, "Glimpse the Unthinkable"),
            new SampleCard(4, "Archive Trap"),
            new SampleCard(1, "Crypt Incursion"),
            new SampleCard(1, "Dream Twist"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(2, "Echoing Truth"),
            new SampleCard(1, "Eliminate"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Murderous Cut"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(4, "Visions of Beyond"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(4, "Mesmeric Orb"),
            new SampleCard(1, "Search for Azcanta"),
            new SampleCard(2, "Darkslick Shores"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(1, "Mikokoro, Center of the Sea"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Shelldock Isle"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Crypt Incursion"),
            new SampleCard(1, "Eliminate"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Extirpate"),
            new SampleCard(2, "Ghost Quarter"),
            new SampleCard(1, "Go for the Throat"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(1, "Moment of Craving"),
            new SampleCard(2, "Profane Memento"),
            new SampleCard(1, "Ravenous Trap"),
            new SampleCard(1, "Winds of Rebuke") 
        };
    }
}