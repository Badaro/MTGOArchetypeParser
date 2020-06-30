using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_25
{
    public class Deck13_killersuv_SnowControl_SnowReclamation_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(2, "Fact or Fiction"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(2, "Remand"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Wilderness Reclamation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Fact or Fiction"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(3, "Dead of Winter"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(3, "Weather the Storm") 
        };
    }
}