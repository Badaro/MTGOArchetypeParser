using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_18
{
    public class Deck02_DreamsOfAshiok_ETron_C : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn, the Great Creator"),(2, "Ugin, the Ineffable"),(1, "Endbringer"),(4, "Matter Reshaper"),(4, "Reality Smasher"),(4, "Thought-Knot Seer"),(3, "Walking Ballista"),(1, "All Is Dust"),(2, "Dismember"),(2, "Warping Wail"),(4, "Chalice of the Void"),(4, "Expedition Map"),(1, "Mind Stone"),(1, "Blast Zone"),(2, "Cavern of Souls"),(4, "Eldrazi Temple"),(1, "Scavenger Grounds"),(1, "Sea Gate Wreckage"),(1, "Tectonic Edge"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower"),(2, "Wastes") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Walking Ballista"),(1, "All Is Dust"),(1, "Ensnaring Bridge"),(1, "Grafdigger's Cage"),(1, "Kozilek, the Great Distortion"),(1, "Liquimetal Coating"),(1, "Pithing Needle"),(2, "Relic of Progenitus"),(1, "Skysovereign, Consul Flagship"),(1, "Sorcerous Spyglass"),(1, "Sundering Titan"),(1, "Tormod's Crypt"),(1, "Torpor Orb"),(1, "Wurmcoil Engine") }; } }
    }
}