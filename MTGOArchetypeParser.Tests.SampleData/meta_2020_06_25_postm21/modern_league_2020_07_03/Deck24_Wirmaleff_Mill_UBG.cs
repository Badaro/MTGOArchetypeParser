using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_03
{
    public class Deck24_Wirmaleff_Mill_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(4, "Archive Trap"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(2, "Extirpate"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Mission Briefing"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(4, "Visions of Beyond"),
            new SampleCard(3, "Arcum's Astrolabe"),
            new SampleCard(4, "Mesmeric Orb"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Shelldock Isle"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Fatal Push"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Crypt Incursion"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Weather the Storm"),
            new SampleCard(1, "Winds of Rebuke") 
        };
    }
}