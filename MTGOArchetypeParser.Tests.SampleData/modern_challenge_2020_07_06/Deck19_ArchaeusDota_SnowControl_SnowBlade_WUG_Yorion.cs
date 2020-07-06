using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_06
{
    public class Deck19_ArchaeusDota_SnowControl_SnowBlade_WUG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Master of Time"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Spell Queller"),
            new SampleCard(2, "Spellstutter Sprite"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Winds of Abandon"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(2, "Abundant Growth"),
            new SampleCard(2, "Elspeth Conquers Death"),
            new SampleCard(4, "Shark Typhoon"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mutavault"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(4, "Ashiok, Dream Render"),
            new SampleCard(2, "Deafening Silence"),
            new SampleCard(3, "Timely Reinforcements"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}