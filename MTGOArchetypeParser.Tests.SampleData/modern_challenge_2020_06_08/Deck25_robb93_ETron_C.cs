using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck25_robb93_ETron_C : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn, the Great Creator"),(2, "Ugin, the Ineffable"),(4, "Matter Reshaper"),(4, "Reality Smasher"),(4, "Thought-Knot Seer"),(3, "Walking Ballista"),(1, "All Is Dust"),(2, "Dismember"),(2, "Warping Wail"),(1, "Batterskull"),(4, "Chalice of the Void"),(4, "Expedition Map"),(1, "Mind Stone"),(3, "Blast Zone"),(1, "Cavern of Souls"),(4, "Eldrazi Temple"),(1, "Scavenger Grounds"),(1, "Tectonic Edge"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower"),(2, "Wastes") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Walking Ballista"),(1, "All Is Dust"),(1, "Basilisk Collar"),(1, "Emrakul, the Promised End"),(1, "Ensnaring Bridge"),(1, "Grafdigger's Cage"),(1, "Liquimetal Coating"),(2, "Relic of Progenitus"),(1, "Skysovereign, Consul Flagship"),(1, "Sorcerous Spyglass"),(1, "Sundering Titan"),(1, "Tormod's Crypt"),(1, "Torpor Orb"),(1, "Wurmcoil Engine") }; } }
    }
}