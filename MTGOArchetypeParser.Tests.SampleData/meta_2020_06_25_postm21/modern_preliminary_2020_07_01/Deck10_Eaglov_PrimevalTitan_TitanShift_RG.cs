using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_01
{
    public class Deck10_Eaglov_PrimevalTitan_TitanShift_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Arboreal Grazer"),
            new SampleCard(3, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(1, "Radha, Heart of Keld"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(4, "Explore"),
            new SampleCard(2, "Farseek"),
            new SampleCard(2, "Hour of Promise"),
            new SampleCard(3, "Scapeshift"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(3, "Summoner's Pact"),
            new SampleCard(3, "Castle Garenbrig"),
            new SampleCard(2, "Cinder Glade"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Sheltered Thicket"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(3, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(1, "Boil"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(1, "Hour of Devastation"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(1, "Thragtusk"),
            new SampleCard(2, "Tireless Tracker"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}