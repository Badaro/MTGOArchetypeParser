using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_19
{
    public class Deck02_MrJACEone_Crabvine_UBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Gravecrawler"),(4, "Gurmag Angler"),(4, "Hedron Crab"),(4, "Merfolk Secretkeeper"),(4, "Narcomoeba"),(4, "Prized Amalgam"),(1, "Skaab Ruinator"),(4, "Stitcher's Supplier"),(4, "Vengevine"),(4, "Creeping Chill"),(4, "Glimpse the Unthinkable"),(1, "Breeding Pool"),(2, "Darkslick Shores"),(3, "Misty Rainforest"),(2, "Overgrown Tomb"),(4, "Polluted Delta"),(1, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(3, "Verdant Catacombs"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrupt Decay"),(2, "Assassin's Trophy"),(4, "Fatal Push"),(3, "Nature's Claim"),(2, "Thoughtseize"),(2, "Unmoored Ego") }; } }
    }
}