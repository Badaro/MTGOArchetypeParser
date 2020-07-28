using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck31_Zyrnak_BantMidrange_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(3, "Scavenging Ooze"),
            new SampleCard(3, "Stoneforge Mystic"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Mwonvuli Acid-Moss"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(4, "Forest"),
            new SampleCard(3, "Ghost Quarter"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Crucible of Worlds"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Knowledge Pool"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Shadow of Doubt"),
            new SampleCard(1, "Skysovereign, Consul Flagship") 
        };
    }
}