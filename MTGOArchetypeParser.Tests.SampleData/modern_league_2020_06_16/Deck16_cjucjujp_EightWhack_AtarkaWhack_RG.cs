using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck16_cjucjujp_EightWhack_AtarkaWhack_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Burning-Tree Emissary"),(3, "Gallia of the Endless Dance"),(4, "Goblin Bushwhacker"),(4, "Goblin Guide"),(2, "Hexdrinker"),(4, "Legion Loyalist"),(4, "Memnite"),(4, "Reckless Bushwhacker"),(4, "Signal Pest"),(4, "Atarka's Command"),(4, "Lightning Bolt"),(3, "Bloodstained Mire"),(3, "Castle Embereth"),(1, "Forest"),(4, "Mountain"),(4, "Stomping Ground"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Bonecrusher Giant"),(2, "Dismember"),(3, "Leyline of Combustion"),(2, "Life Goes On"),(3, "Smash to Smithereens"),(3, "Tormod's Crypt") }; } }
    }
}