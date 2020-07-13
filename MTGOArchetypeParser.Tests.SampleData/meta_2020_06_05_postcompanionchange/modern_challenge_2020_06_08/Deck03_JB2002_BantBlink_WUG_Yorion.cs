using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08
{
    public class Deck03_JB2002_BantBlink_WUG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(1, "Arcades, the Strategist"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Kitchen Finks"),
            new SampleCard(4, "Knight of Autumn"),
            new SampleCard(4, "Restoration Angel"),
            new SampleCard(2, "Vendilion Clique"),
            new SampleCard(2, "Venser, Shaper Savant"),
            new SampleCard(4, "Wall of Blossoms"),
            new SampleCard(4, "Wall of Omens"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(2, "Dovin's Veto"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(2, "On Thin Ice"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Cavern of Souls"),
            new SampleCard(4, "Celestial Colonnade"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(4, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(4, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(4, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}