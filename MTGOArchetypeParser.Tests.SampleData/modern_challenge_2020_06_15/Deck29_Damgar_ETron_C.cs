using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck29_Damgar_ETron_C : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn, the Great Creator"),(2, "Ugin, the Ineffable"),(1, "Endbringer"),(4, "Matter Reshaper"),(4, "Reality Smasher"),(4, "Thought-Knot Seer"),(1, "Ulamog, the Ceaseless Hunger"),(3, "Walking Ballista"),(1, "All Is Dust"),(2, "Dismember"),(4, "Chalice of the Void"),(4, "Expedition Map"),(2, "Mind Stone"),(2, "Blast Zone"),(1, "Cavern of Souls"),(4, "Eldrazi Temple"),(1, "Ghost Quarter"),(1, "Scavenger Grounds"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower"),(3, "Wastes") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Walking Ballista"),(1, "Ensnaring Bridge"),(1, "Grafdigger's Cage"),(1, "Liquimetal Coating"),(1, "Mystic Forge"),(1, "Pithing Needle"),(2, "Relic of Progenitus"),(1, "Sorcerous Spyglass"),(2, "Spatial Contortion"),(1, "Tormod's Crypt"),(1, "Torpor Orb"),(1, "Warping Wail"),(1, "Wurmcoil Engine") }; } }
    }
}