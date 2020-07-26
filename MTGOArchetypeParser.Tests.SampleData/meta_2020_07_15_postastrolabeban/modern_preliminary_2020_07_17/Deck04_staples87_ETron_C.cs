using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17
{
    public class Deck04_staples87_ETron_C : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(2, "Ugin, the Ineffable"),
            new SampleCard(1, "Emrakul, the Promised End"),
            new SampleCard(3, "Matter Reshaper"),
            new SampleCard(1, "Oblivion Sower"),
            new SampleCard(4, "Reality Smasher"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(1, "All Is Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Spatial Contortion"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(2, "Mazemind Tome"),
            new SampleCard(1, "Mind Stone"),
            new SampleCard(2, "Blast Zone"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Scavenger Grounds"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower"),
            new SampleCard(2, "Wastes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(2, "Spatial Contortion"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Kozilek, the Great Distortion"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Skysovereign, Consul Flagship"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Trinisphere"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}