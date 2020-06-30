using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck10_distanthamster_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Boggart Harbinger"),(4, "Conspicuous Snoop"),(4, "Goblin Matron"),(1, "Goblin Ringleader"),(1, "Goblin Warchief"),(1, "Kiki-Jiki, Mirror Breaker"),(4, "Mogg War Marshal"),(4, "Munitions Expert"),(2, "Pashalik Mons"),(2, "Sling-Gang Lieutenant"),(1, "Inquisition of Kozilek"),(4, "Thoughtseize"),(1, "Unearth"),(4, "Aether Vial"),(4, "Auntie's Hovel"),(4, "Blackcleave Cliffs"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(4, "Cavern of Souls"),(1, "Fiery Islet"),(2, "Snow-Covered Mountain"),(1, "Snow-Covered Swamp"),(1, "Tarfire") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Goblin Ringleader"),(2, "Tarfire"),(2, "Blood Moon"),(2, "Boil"),(1, "Goblin Cratermaker"),(1, "Goblin Trashmaster"),(4, "Plague Engineer"),(2, "Relic of Progenitus") }; } }
    }
}