using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck34_DarkKeeper_BantControl_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(2, "Primeval Titan"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Explore"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Remand"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Forest"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Temple Garden") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(1, "Elder Gargaroth"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}