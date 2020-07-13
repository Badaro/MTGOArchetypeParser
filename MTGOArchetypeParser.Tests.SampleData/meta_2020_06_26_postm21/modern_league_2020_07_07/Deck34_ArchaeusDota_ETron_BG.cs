using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07
{
    public class Deck34_ArchaeusDota_ETron_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Karn Liberated"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(4, "Matter Reshaper"),
            new SampleCard(4, "Reality Smasher"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(3, "Walking Ballista"),
            new SampleCard(2, "World Breaker"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Spatial Contortion"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(2, "Mazemind Tome"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(1, "Forest"),
            new SampleCard(4, "Llanowar Wastes"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower"),
            new SampleCard(1, "Wastes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Spatial Contortion"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Leyline of the Void"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Mystic Forge"),
            new SampleCard(2, "Pithing Needle"),
            new SampleCard(1, "Trinisphere"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}