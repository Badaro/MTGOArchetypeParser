using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_12
{
    public class Deck17_yamakiller_SnowControl_SnowReclamation_URG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Archmage's Charm"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(4, "Fact or Fiction"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(3, "Abundant Growth"),
            new SampleCard(4, "Wilderness Reclamation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(7, "Snow-Covered Island"),
            new SampleCard(1, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Force of Negation"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(2, "Pyroclasm"),
            new SampleCard(1, "Radiant Flames"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(1, "Weather the Storm"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}