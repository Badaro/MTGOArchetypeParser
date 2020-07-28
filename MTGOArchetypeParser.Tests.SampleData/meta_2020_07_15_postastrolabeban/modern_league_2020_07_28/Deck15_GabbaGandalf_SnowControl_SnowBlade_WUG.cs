using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck15_GabbaGandalf_SnowControl_SnowBlade_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Vendilion Clique"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Forest"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(4, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}