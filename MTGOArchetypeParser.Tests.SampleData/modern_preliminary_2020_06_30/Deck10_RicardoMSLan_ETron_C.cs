using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_30
{
    public class Deck10_RicardoMSLan_ETron_C : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn, the Great Creator"),(2, "Ugin, the Ineffable"),(4, "Matter Reshaper"),(4, "Reality Smasher"),(4, "Thought-Knot Seer"),(1, "Ulamog, the Ceaseless Hunger"),(2, "Walking Ballista"),(1, "All Is Dust"),(2, "Dismember"),(1, "Spatial Contortion"),(4, "Chalice of the Void"),(4, "Expedition Map"),(1, "Mind Stone"),(2, "Smuggler's Copter"),(1, "Blast Zone"),(2, "Cavern of Souls"),(4, "Eldrazi Temple"),(1, "Sea Gate Wreckage"),(1, "Tectonic Edge"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower"),(3, "Wastes") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Walking Ballista"),(1, "Spatial Contortion"),(1, "Batterskull"),(1, "Ensnaring Bridge"),(4, "Leyline of the Void"),(1, "Liquimetal Coating"),(1, "Mystic Forge"),(1, "Pithing Needle"),(1, "Relic of Progenitus"),(1, "Skysovereign, Consul Flagship"),(1, "Torpor Orb"),(1, "Wurmcoil Engine") }; } }
    }
}