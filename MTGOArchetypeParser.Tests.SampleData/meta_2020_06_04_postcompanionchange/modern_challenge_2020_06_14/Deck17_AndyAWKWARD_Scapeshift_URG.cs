using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_challenge_2020_06_14
{
    public class Deck17_AndyAWKWARD_Scapeshift_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Scapeshift"),
            new SampleCard(2, "Sweltering Suns"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(2, "Izzet Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(4, "Steam Vents"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(2, "Valakut, the Molten Pinnacle") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Alpine Moon"),
            new SampleCard(2, "Flame Slash"),
            new SampleCard(1, "Force of Vigor"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(3, "Obstinate Baloth"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}