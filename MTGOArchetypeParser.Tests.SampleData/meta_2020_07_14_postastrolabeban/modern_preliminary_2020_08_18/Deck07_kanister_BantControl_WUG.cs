using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18
{
    public class Deck07_kanister_BantControl_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Hero of Dominaria"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(1, "Snapcaster Mage"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Wall of Omens"),
            new SampleCard(1, "Hour of Promise"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Growth Spiral"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Remand"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(1, "Seaside Citadel"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Dovin's Veto"),
            new SampleCard(1, "Elder Gargaroth"),
            new SampleCard(1, "Ravenous Trap"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}