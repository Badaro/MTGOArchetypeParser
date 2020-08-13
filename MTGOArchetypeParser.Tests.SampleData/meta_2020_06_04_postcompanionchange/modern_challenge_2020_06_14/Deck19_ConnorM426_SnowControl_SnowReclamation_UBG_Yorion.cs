using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_challenge_2020_06_14
{
    public class Deck19_ConnorM426_SnowControl_SnowReclamation_UBG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(4, "Archmage's Charm"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(1, "Drown in the Loch"),
            new SampleCard(4, "Fact or Fiction"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(1, "Mystical Teachings"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Wilderness Reclamation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(8, "Snow-Covered Island"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Fatal Push"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(3, "Dead of Winter"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(3, "Weather the Storm"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}