using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck24_kanister_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Boggart Harbinger"),(4, "Conspicuous Snoop"),(2, "Goblin Chieftain"),(4, "Goblin Matron"),(2, "Goblin Ringleader"),(1, "Kiki-Jiki, Mirror Breaker"),(4, "Mogg War Marshal"),(4, "Munitions Expert"),(2, "Skirk Prospector"),(2, "Sling-Gang Lieutenant"),(2, "Inquisition of Kozilek"),(3, "Thoughtseize"),(4, "Aether Vial"),(4, "Auntie's Hovel"),(4, "Blackcleave Cliffs"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(4, "Cavern of Souls"),(2, "Mountain"),(1, "Sunbaked Canyon"),(1, "Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Blood Moon"),(2, "Boil"),(1, "Goblin Cratermaker"),(1, "Goblin Trashmaster"),(2, "Plague Engineer"),(4, "Relic of Progenitus"),(3, "Tarfire") }; } }
    }
}