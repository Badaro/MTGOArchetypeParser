using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck62_DoctorQueller_Spirits_BantSpirits_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Drogskol Captain"),
            new SampleCard(4, "Mausoleum Wanderer"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(2, "Phantasmal Image"),
            new SampleCard(4, "Rattlechains"),
            new SampleCard(3, "Reflector Mage"),
            new SampleCard(3, "Selfless Spirit"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Supreme Phantom"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(3, "Aether Vial"),
            new SampleCard(2, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(1, "Moorland Haunt"),
            new SampleCard(1, "Seachrome Coast"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(1, "Waterlogged Grove"),
            new SampleCard(2, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Unified Will") 
        };
    }
}