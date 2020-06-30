using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck27_sheastrausman_SnowControl_SnowReclamation_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Wrenn and Six"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Expansion // Explosion"),
            new SampleCard(2, "Fact or Fiction"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(1, "Remand"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Wilderness Reclamation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Fact or Fiction"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(1, "Mwonvuli Acid-Moss"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}