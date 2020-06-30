using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck16_ZYURYO_SnowControl_WUBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(1, "Kaya's Guile"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(1, "Notion Thief"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}