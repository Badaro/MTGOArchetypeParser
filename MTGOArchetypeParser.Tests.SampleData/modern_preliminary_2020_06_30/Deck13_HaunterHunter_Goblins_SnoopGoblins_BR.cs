using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_30
{
    public class Deck13_HaunterHunter_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Boggart Harbinger"),(4, "Conspicuous Snoop"),(4, "Goblin Matron"),(4, "Goblin Ringleader"),(1, "Goblin Warchief"),(1, "Kiki-Jiki, Mirror Breaker"),(1, "Krenko, Mob Boss"),(4, "Mogg War Marshal"),(4, "Munitions Expert"),(1, "Pashalik Mons"),(2, "Skirk Prospector"),(2, "Sling-Gang Lieutenant"),(4, "Aether Vial"),(4, "Auntie's Hovel"),(4, "Blackcleave Cliffs"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(4, "Cavern of Souls"),(3, "Mountain"),(1, "Swamp"),(1, "Unclaimed Territory"),(1, "Tarfire") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Goblin Warchief"),(1, "Tarfire"),(2, "Blood Moon"),(1, "Goblin Chainwhirler"),(1, "Goblin Cratermaker"),(1, "Goblin Piledriver"),(1, "Goblin Trashmaster"),(2, "Plague Engineer"),(2, "Relic of Progenitus"),(3, "Thoughtseize") }; } }
    }
}