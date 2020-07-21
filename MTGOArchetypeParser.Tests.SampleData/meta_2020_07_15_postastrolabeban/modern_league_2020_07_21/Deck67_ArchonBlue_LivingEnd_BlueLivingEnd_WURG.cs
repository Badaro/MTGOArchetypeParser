using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_21
{
    public class Deck67_ArchonBlue_LivingEnd_BlueLivingEnd_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Architects of Will"),
            new SampleCard(4, "Curator of Mysteries"),
            new SampleCard(4, "Desert Cerodon"),
            new SampleCard(2, "Glassdust Hulk"),
            new SampleCard(1, "Simian Spirit Guide"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Striped Riverwinder"),
            new SampleCard(4, "Windcaller Aven"),
            new SampleCard(3, "Living End"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Violent Outburst"),
            new SampleCard(4, "Ardent Plea"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Dead // Gone"),
            new SampleCard(3, "Faerie Macabre"),
            new SampleCard(3, "Ingot Chewer"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(3, "Wispmare") 
        };
    }
}