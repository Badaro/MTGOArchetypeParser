using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_14
{
    public class Deck24_WallofBromens_LivingEnd_BlueLivingEnd_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(4, "Curator of Mysteries"),
            new SampleCard(4, "Glassdust Hulk"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Striped Riverwinder"),
            new SampleCard(2, "Waker of Waves"),
            new SampleCard(4, "Windcaller Aven"),
            new SampleCard(2, "Failure // Comply"),
            new SampleCard(3, "Living End"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(4, "Ardent Plea"),
            new SampleCard(3, "As Foretold"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(1, "Glacial Fortress"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(4, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(4, "Seachrome Coast") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(1, "As Foretold"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Drake Haven"),
            new SampleCard(2, "Faerie Macabre"),
            new SampleCard(2, "Generous Gift"),
            new SampleCard(1, "Teferi, Time Raveler") 
        };
    }
}