using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck24_llabmonkey_SnowControl_SnowShift_URG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Flame Slash"),
            new SampleCard(3, "Scapeshift"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Abundant Growth"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Sheltered Thicket"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(4, "Steam Vents"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(2, "Valakut, the Molten Pinnacle") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Flame Slash"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(4, "Anger of the Gods"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}