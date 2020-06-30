using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck19_2radMTG_SnowControl_SnowReclamation_URG : ISampleDeck
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
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(3, "Weather the Storm") 
        };
    }
}