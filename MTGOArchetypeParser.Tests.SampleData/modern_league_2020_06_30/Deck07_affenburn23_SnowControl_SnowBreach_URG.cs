using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck07_affenburn23_SnowControl_SnowBreach_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emrakul, the Aeons Torn"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(1, "Snapcaster Mage"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Fact or Fiction"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(2, "Izzet Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "Through the Breach"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Desolate Lighthouse"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(7, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}