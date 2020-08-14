using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck41_Maxtick_SnowControl_SnowBlade_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Shark Typhoon"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(1, "Waterlogged Grove"),
            new SampleCard(2, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "On Thin Ice"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}