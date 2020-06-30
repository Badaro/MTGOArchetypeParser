using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck30_pbarrrgh_SnowControl_SnowBlade_WUG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Hero of Dominaria"),
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Abundant Growth"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Dovin's Veto"),
            new SampleCard(3, "On Thin Ice"),
            new SampleCard(3, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}