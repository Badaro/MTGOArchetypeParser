using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck10_MasterA_Goblins_SnoopGoblins_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Boggart Harbinger"),(4, "Conspicuous Snoop"),(2, "Goblin Matron"),(1, "Grumgully, the Generous"),(2, "Kiki-Jiki, Mirror Breaker"),(4, "Metallic Mimic"),(4, "Munitions Expert"),(1, "Murderous Redcap"),(4, "Putrid Goblin"),(4, "Skirk Prospector"),(4, "Sling-Gang Lieutenant"),(4, "Aether Vial"),(1, "Arid Mesa"),(4, "Auntie's Hovel"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(4, "Cavern of Souls"),(1, "Gemstone Caverns"),(2, "Mountain"),(1, "Stomping Ground"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ashiok, Dream Render"),(1, "Dismember"),(1, "Goblin Ringleader"),(1, "Goblin Trashmaster"),(1, "Lightning Bolt"),(4, "Relic of Progenitus"),(1, "Tarfire"),(4, "Thoughtseize") }; } }
    }
}