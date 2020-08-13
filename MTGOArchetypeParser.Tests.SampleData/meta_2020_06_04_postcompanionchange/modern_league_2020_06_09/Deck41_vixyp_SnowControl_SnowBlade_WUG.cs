using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_09
{
    public class Deck41_vixyp_SnowControl_SnowBlade_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(1, "Deputy of Detention"),
            new SampleCard(3, "Geist of Saint Traft"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Arcum's Astrolabe"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(1, "Waterlogged Grove"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Gaddock Teeg"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}