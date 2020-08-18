using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck63_scipios_Crabvine_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Gravecrawler"),
            new SampleCard(2, "Gurmag Angler"),
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(4, "Merfolk Secretkeeper"),
            new SampleCard(4, "Narcomoeba"),
            new SampleCard(3, "Prized Amalgam"),
            new SampleCard(3, "Silversmote Ghoul"),
            new SampleCard(4, "Stitcher's Supplier"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Vengevine"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(3, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(3, "Force of Vigor"),
            new SampleCard(1, "Inquisition of Kozilek"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}