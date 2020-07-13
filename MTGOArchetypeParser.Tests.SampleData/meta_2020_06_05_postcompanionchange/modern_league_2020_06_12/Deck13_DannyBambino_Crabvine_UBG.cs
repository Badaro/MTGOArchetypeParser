using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_12
{
    public class Deck13_DannyBambino_Crabvine_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Carrion Feeder"),
            new SampleCard(1, "Fatestitcher"),
            new SampleCard(4, "Gravecrawler"),
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(4, "Merfolk Secretkeeper"),
            new SampleCard(4, "Narcomoeba"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(4, "Stitcher's Supplier"),
            new SampleCard(4, "Vengevine"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(3, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Swamp"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(2, "Nature's Claim"),
            new SampleCard(2, "Thoughtseize") 
        };
    }
}