using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_06_28
{
    public class Deck23_Curtisaxel_Spirits_BantSpirits_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(2, "Deputy of Detention"),
            new SampleCard(4, "Drogskol Captain"),
            new SampleCard(4, "Mausoleum Wanderer"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Rattlechains"),
            new SampleCard(2, "Selfless Spirit"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Supreme Phantom"),
            new SampleCard(3, "Unsettled Mariner"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(1, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Seachrome Coast"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(3, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Path to Exile"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(3, "Knight of Autumn"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(1, "Unified Will") 
        };
    }
}