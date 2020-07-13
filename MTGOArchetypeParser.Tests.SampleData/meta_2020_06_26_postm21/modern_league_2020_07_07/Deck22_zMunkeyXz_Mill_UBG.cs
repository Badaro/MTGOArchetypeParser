using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07
{
    public class Deck22_zMunkeyXz_Mill_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(4, "Archive Trap"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(3, "Surgical Extraction"),
            new SampleCard(4, "Visions of Beyond"),
            new SampleCard(2, "Winds of Rebuke"),
            new SampleCard(3, "Arcum's Astrolabe"),
            new SampleCard(4, "Mesmeric Orb"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(2, "Waterlogged Grove"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Crypt Incursion"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}