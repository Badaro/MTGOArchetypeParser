using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck19_TLaros_PrimevalTitan_TitanShift_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Courser of Kruphix"),
            new SampleCard(2, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(3, "Explore"),
            new SampleCard(2, "Farseek"),
            new SampleCard(1, "Mwonvuli Acid-Moss"),
            new SampleCard(3, "Scapeshift"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(1, "Sweltering Suns"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(3, "Summoner's Pact"),
            new SampleCard(3, "Castle Garenbrig"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Cinder Glade"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(4, "Mountain"),
            new SampleCard(1, "Sheltered Thicket"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(3, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(1, "Vesuva"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boil"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(3, "Obstinate Baloth"),
            new SampleCard(3, "Reclamation Sage"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}