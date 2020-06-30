using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_30
{
    public class Deck11_Niallghas_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Boggart Harbinger"),(4, "Conspicuous Snoop"),(4, "Goblin Matron"),(1, "Goblin Ringleader"),(1, "Goblin Warchief"),(1, "Kiki-Jiki, Mirror Breaker"),(1, "Krenko, Mob Boss"),(4, "Mogg War Marshal"),(4, "Munitions Expert"),(2, "Pashalik Mons"),(2, "Skirk Prospector"),(2, "Sling-Gang Lieutenant"),(2, "Thoughtseize"),(2, "Unearth"),(4, "Aether Vial"),(1, "Arid Mesa"),(4, "Auntie's Hovel"),(3, "Blackcleave Cliffs"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(4, "Cavern of Souls"),(1, "Fiery Islet"),(2, "Snow-Covered Mountain"),(1, "Snow-Covered Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Thoughtseize"),(2, "Blood Moon"),(3, "Boil"),(1, "Collective Brutality"),(1, "Earwig Squad"),(1, "Goblin Cratermaker"),(1, "Goblin Trashmaster"),(3, "Plague Engineer"),(2, "Relic of Progenitus") }; } }
    }
}