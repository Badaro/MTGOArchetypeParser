using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck04_FestiFan_SnowControl_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(2, "Thrun, the Last Troll"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}