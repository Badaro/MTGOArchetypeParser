using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_14
{
    public class Deck55_December18_PrimevalTitan_TitanShift_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(4, "Farseek"),
            new SampleCard(4, "Scapeshift"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(1, "Sweltering Suns"),
            new SampleCard(1, "Beast Within"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Summoner's Pact"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(1, "Castle Garenbrig"),
            new SampleCard(2, "Cinder Glade"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(1, "Forest"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Sheltered Thicket"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(3, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Vesuva"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Beast Within"),
            new SampleCard(1, "Ancient Grudge"),
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(4, "Grafdigger's Cage"),
            new SampleCard(2, "Obstinate Baloth"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}