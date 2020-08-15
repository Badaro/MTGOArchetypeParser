using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_15
{
    public class Deck02_CavalloGoloso_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Narset, Parter of Veils"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(4, "Thing in the Ice"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Aether Gust"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(1, "Burst Lightning"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Magmatic Sinkhole"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(1, "Blood Moon"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(6, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Blood Moon"),
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Relic of Progenitus") 
        };
    }
}