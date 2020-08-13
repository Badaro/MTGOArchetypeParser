using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_28
{
    public class Deck07_koji1130_ETron_C : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(2, "Ugin, the Ineffable"),
            new SampleCard(4, "Matter Reshaper"),
            new SampleCard(4, "Reality Smasher"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(3, "Walking Ballista"),
            new SampleCard(1, "All Is Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Warping Wail"),
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(2, "Mazemind Tome"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(2, "Scavenger Grounds"),
            new SampleCard(2, "Tectonic Edge"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower"),
            new SampleCard(4, "Wastes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Mystic Forge"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(1, "Skysovereign, Consul Flagship"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(3, "Spatial Contortion"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}