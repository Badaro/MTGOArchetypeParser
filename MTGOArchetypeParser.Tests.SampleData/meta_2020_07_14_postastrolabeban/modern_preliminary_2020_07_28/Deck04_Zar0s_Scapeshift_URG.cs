using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_28
{
    public class Deck04_Zar0s_Scapeshift_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Scapeshift"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(2, "Izzet Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Opt"),
            new SampleCard(3, "Remand"),
            new SampleCard(2, "Wilt"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(4, "Steam Vents"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(2, "Valakut, the Molten Pinnacle") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(2, "Flame Slash"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Weather the Storm") 
        };
    }
}