using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck31_SebastianStueckl_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Boggart Harbinger"),(3, "Conspicuous Snoop"),(4, "Goblin Matron"),(1, "Goblin Piledriver"),(2, "Goblin Ringleader"),(1, "Goblin Warchief"),(1, "Kiki-Jiki, Mirror Breaker"),(1, "Krenko, Mob Boss"),(4, "Mogg War Marshal"),(4, "Munitions Expert"),(2, "Pashalik Mons"),(3, "Skirk Prospector"),(2, "Sling-Gang Lieutenant"),(2, "Unearth"),(4, "Aether Vial"),(2, "Arid Mesa"),(4, "Auntie's Hovel"),(3, "Blood Crypt"),(4, "Bloodstained Mire"),(4, "Cavern of Souls"),(1, "Fiery Islet"),(2, "Snow-Covered Mountain"),(1, "Snow-Covered Swamp"),(1, "Unclaimed Territory") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Blood Moon"),(2, "Collective Brutality"),(1, "Earwig Squad"),(1, "Goblin Chainwhirler"),(1, "Goblin Cratermaker"),(1, "Goblin Trashmaster"),(3, "Leyline of the Void"),(3, "Plague Engineer") }; } }
    }
}