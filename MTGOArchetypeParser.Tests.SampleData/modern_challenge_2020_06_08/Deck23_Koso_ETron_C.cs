using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck23_Koso_ETron_C : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn, the Great Creator"),(2, "Ugin, the Ineffable"),(4, "Matter Reshaper"),(4, "Reality Smasher"),(4, "Thought-Knot Seer"),(3, "Walking Ballista"),(1, "All Is Dust"),(2, "Dismember"),(2, "Warping Wail"),(4, "Chalice of the Void"),(4, "Expedition Map"),(2, "Mind Stone"),(2, "Blast Zone"),(1, "Cavern of Souls"),(4, "Eldrazi Temple"),(1, "Ghost Quarter"),(1, "Scavenger Grounds"),(1, "Tectonic Edge"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower"),(2, "Wastes") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Walking Ballista"),(1, "All Is Dust"),(1, "Emrakul, the Promised End"),(1, "Ensnaring Bridge"),(1, "Grafdigger's Cage"),(1, "Liquimetal Coating"),(2, "Relic of Progenitus"),(1, "Skysovereign, Consul Flagship"),(1, "Sorcerous Spyglass"),(2, "Spatial Contortion"),(1, "Sundering Titan"),(1, "Torpor Orb"),(1, "Wurmcoil Engine") }; } }
    }
}