using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck30_sora1248_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Boggart Harbinger"),(4, "Conspicuous Snoop"),(1, "Goblin Chieftain"),(1, "Goblin Cratermaker"),(3, "Goblin Matron"),(2, "Goblin Piledriver"),(3, "Goblin Ringleader"),(3, "Goblin Warchief"),(2, "Kiki-Jiki, Mirror Breaker"),(1, "Mogg Fanatic"),(3, "Mogg War Marshal"),(3, "Munitions Expert"),(2, "Sling-Gang Lieutenant"),(4, "Aether Vial"),(4, "Auntie's Hovel"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(4, "Cavern of Souls"),(2, "Mountain"),(2, "Prismatic Vista"),(2, "Snow-Covered Mountain"),(1, "Swamp"),(3, "Unclaimed Territory") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Blood Moon"),(3, "Collective Brutality"),(2, "Damping Sphere"),(1, "Goblin Trashmaster"),(1, "Grafdigger's Cage"),(1, "Nihil Spellbomb"),(2, "Postmortem Lunge"),(1, "Surgical Extraction"),(2, "Tarfire") }; } }
    }
}