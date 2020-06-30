using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck28_kbr3_Scapeshift_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Scapeshift"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(2, "Izzet Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Opt"),
            new SampleCard(3, "Remand"),
            new SampleCard(2, "Thought Scour"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(4, "Steam Vents"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(2, "Valakut, the Molten Pinnacle") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(2, "Flame Slash"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}