using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_07
{
    public class Deck47_Taracogenius_PrimevalTitan_TitanShift_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(4, "Anger of the Gods"),
            new SampleCard(2, "Explore"),
            new SampleCard(4, "Farseek"),
            new SampleCard(2, "Hour of Promise"),
            new SampleCard(4, "Mwonvuli Acid-Moss"),
            new SampleCard(4, "Scapeshift"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(2, "Castle Garenbrig"),
            new SampleCard(1, "Cinder Glade"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(1, "Forest"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Sheltered Thicket"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(4, "Valakut, the Molten Pinnacle"),
            new SampleCard(2, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Beast Within"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Firespout"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(4, "Weather the Storm") 
        };
    }
}