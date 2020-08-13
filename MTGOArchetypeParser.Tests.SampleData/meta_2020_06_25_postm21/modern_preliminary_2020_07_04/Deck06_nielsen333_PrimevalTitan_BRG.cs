using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_04
{
    public class Deck06_nielsen333_PrimevalTitan_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Arboreal Grazer"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(2, "Golos, Tireless Pilgrim"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(4, "Explore"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(1, "Sylvan Scrying"),
            new SampleCard(3, "Summoner's Pact"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(1, "Cascading Cataracts"),
            new SampleCard(4, "Castle Garenbrig"),
            new SampleCard(3, "Cavern of Souls"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(2, "Golgari Rot Farm"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(2, "Radiant Fountain"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Valakut, the Molten Pinnacle"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(1, "Vesuva") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(1, "Choke"),
            new SampleCard(2, "Memoricide"),
            new SampleCard(2, "Obstinate Baloth"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}