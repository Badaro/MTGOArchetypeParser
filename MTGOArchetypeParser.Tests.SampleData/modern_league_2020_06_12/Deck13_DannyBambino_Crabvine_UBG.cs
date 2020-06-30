using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck13_DannyBambino_Crabvine_UBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Carrion Feeder"),(1, "Fatestitcher"),(4, "Gravecrawler"),(4, "Hedron Crab"),(4, "Merfolk Secretkeeper"),(4, "Narcomoeba"),(4, "Prized Amalgam"),(4, "Stitcher's Supplier"),(4, "Vengevine"),(4, "Creeping Chill"),(4, "Glimpse the Unthinkable"),(4, "Bloodstained Mire"),(4, "Marsh Flats"),(3, "Overgrown Tomb"),(4, "Polluted Delta"),(2, "Swamp"),(3, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Abrupt Decay"),(1, "Assassin's Trophy"),(3, "Damping Sphere"),(3, "Fatal Push"),(3, "Leyline of the Void"),(2, "Nature's Claim"),(2, "Thoughtseize") }; } }
    }
}