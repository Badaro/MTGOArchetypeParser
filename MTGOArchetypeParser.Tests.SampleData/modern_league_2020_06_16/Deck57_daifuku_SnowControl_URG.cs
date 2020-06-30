using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck57_daifuku_SnowControl_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Wrenn and Six"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Archmage's Charm"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(1, "Lonely Sandbar"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}