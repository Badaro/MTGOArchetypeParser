using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck41_bozo2112_Crabvine_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Gravecrawler"),
            new SampleCard(4, "Gurmag Angler"),
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(4, "Merfolk Secretkeeper"),
            new SampleCard(4, "Narcomoeba"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(1, "Skaab Ruinator"),
            new SampleCard(4, "Stitcher's Supplier"),
            new SampleCard(4, "Vengevine"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(2, "Darkslick Shores"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(3, "Prismatic Vista"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Unmoored Ego") 
        };
    }
}