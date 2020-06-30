using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27
{
    public class Deck09_cjucjujp_EightWhack_AtarkaWhack_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Burning-Tree Emissary"),(3, "Gallia of the Endless Dance"),(4, "Goblin Bushwhacker"),(4, "Goblin Guide"),(4, "Legion Loyalist"),(4, "Memnite"),(4, "Reckless Bushwhacker"),(4, "Signal Pest"),(2, "Scale Up"),(4, "Atarka's Command"),(4, "Lightning Bolt"),(3, "Bloodstained Mire"),(3, "Castle Embereth"),(5, "Mountain"),(4, "Stomping Ground"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Bonecrusher Giant"),(2, "Dismember"),(3, "Leyline of Combustion"),(2, "Pyrite Spellbomb"),(3, "Smash to Smithereens"),(3, "Tormod's Crypt") }; } }
    }
}