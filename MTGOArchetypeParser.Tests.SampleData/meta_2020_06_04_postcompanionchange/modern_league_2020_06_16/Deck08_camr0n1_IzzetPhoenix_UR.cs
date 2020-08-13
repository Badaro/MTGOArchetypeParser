using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_16
{
    public class Deck08_camr0n1_IzzetPhoenix_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arclight Phoenix"),
            new SampleCard(1, "Bedlam Reveler"),
            new SampleCard(4, "Merchant of the Vale"),
            new SampleCard(4, "Thing in the Ice"),
            new SampleCard(2, "Chart a Course"),
            new SampleCard(2, "Finale of Promise"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Sleight of Hand"),
            new SampleCard(2, "Izzet Charm"),
            new SampleCard(2, "Lightning Axe"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(3, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(2, "Mountain"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Aria of Flame"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(1, "Surgical Extraction") 
        };
    }
}