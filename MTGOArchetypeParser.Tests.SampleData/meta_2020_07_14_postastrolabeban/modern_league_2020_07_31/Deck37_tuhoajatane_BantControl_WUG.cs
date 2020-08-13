using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_31
{
    public class Deck37_tuhoajatane_BantControl_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Hour of Promise"),
            new SampleCard(2, "Search for Tomorrow"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(1, "Fact or Fiction"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Containment Priest"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Soul-Guide Lantern"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}