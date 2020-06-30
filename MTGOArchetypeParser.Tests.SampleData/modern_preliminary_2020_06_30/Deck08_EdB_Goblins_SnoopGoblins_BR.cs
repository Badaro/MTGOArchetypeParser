using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_30
{
    public class Deck08_EdB_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Boggart Harbinger"),(4, "Conspicuous Snoop"),(4, "Dark Confidant"),(1, "Goblin Cratermaker"),(4, "Goblin Matron"),(1, "Goblin Rabblemaster"),(2, "Kiki-Jiki, Mirror Breaker"),(2, "Sling-Gang Lieutenant"),(4, "Inquisition of Kozilek"),(4, "Thoughtseize"),(4, "Unearth"),(1, "Warren Weirding"),(4, "Auntie's Hovel"),(4, "Blackcleave Cliffs"),(4, "Blood Crypt"),(4, "Bloodstained Mire"),(2, "Fiery Islet"),(2, "Mountain"),(2, "Polluted Delta"),(1, "Swamp"),(2, "Tarfire") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Tarfire"),(1, "Warren Weirding"),(2, "Collective Brutality"),(3, "Damping Sphere"),(4, "Fatal Push"),(4, "Nihil Spellbomb") }; } }
    }
}