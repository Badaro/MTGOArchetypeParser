using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_30
{
    public class Deck10_RicardoMSLan_ETron_C : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(2, "Ugin, the Ineffable"),
            new SampleCard(4, "Matter Reshaper"),
            new SampleCard(4, "Reality Smasher"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(1, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(1, "All Is Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Spatial Contortion"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Mind Stone"),
            new SampleCard(2, "Smuggler's Copter"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(1, "Sea Gate Wreckage"),
            new SampleCard(1, "Tectonic Edge"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower"),
            new SampleCard(3, "Wastes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Spatial Contortion"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(4, "Leyline of the Void"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Mystic Forge"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(1, "Skysovereign, Consul Flagship"),
            new SampleCard(1, "Torpor Orb"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}