using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck01_llabmonkey_SnowControl_SnowBlade_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Spell Queller"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(3, "Serum Visions"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Remand"),
            new SampleCard(3, "Spell Pierce"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Glacial Fortress"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Containment Priest"),
            new SampleCard(1, "Narset, Parter of Veils"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}