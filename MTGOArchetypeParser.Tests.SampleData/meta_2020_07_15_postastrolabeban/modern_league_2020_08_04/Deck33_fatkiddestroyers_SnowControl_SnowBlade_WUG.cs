using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck33_fatkiddestroyers_SnowControl_SnowBlade_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Censor"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Detention Sphere"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(1, "Waterlogged Grove"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Batterskull"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "On Thin Ice"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Shark Typhoon"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(1, "Veil of Summer") 
        };
    }
}