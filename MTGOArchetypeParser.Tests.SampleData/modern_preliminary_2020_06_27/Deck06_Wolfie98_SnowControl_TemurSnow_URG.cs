using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27
{
    public class Deck06_Wolfie98_SnowControl_TemurSnow_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(1, "Deprive"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(1, "Skred"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(2, "Lonely Sandbar"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}