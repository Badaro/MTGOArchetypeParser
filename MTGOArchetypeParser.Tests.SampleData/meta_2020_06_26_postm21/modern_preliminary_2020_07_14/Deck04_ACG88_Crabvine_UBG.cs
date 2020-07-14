using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_preliminary_2020_07_14
{
    public class Deck04_ACG88_Crabvine_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Gravecrawler"),
            new SampleCard(2, "Gurmag Angler"),
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(4, "Merfolk Secretkeeper"),
            new SampleCard(4, "Narcomoeba"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(4, "Silversmote Ghoul"),
            new SampleCard(4, "Stitcher's Supplier"),
            new SampleCard(4, "Vengevine"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(2, "Darkslick Shores"),
            new SampleCard(1, "Island"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(3, "Verdant Catacombs"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(2, "Unmoored Ego") 
        };
    }
}