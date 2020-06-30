using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck27_SightWinner_HollowOne_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Bloodghast"),(4, "Flameblade Adept"),(4, "Flamewake Phoenix"),(4, "Gurmag Angler"),(4, "Hollow One"),(2, "Insolent Neonate"),(4, "Street Wraith"),(2, "Tasigur, the Golden Fang"),(4, "Burning Inquiry"),(1, "Go for Blood"),(4, "Goblin Lore"),(2, "Lightning Bolt"),(4, "Mishra's Bauble"),(3, "Arid Mesa"),(3, "Blood Crypt"),(4, "Bloodstained Mire"),(3, "Mountain"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Lightning Bolt"),(3, "Boil"),(4, "Boom // Bust"),(4, "Collective Brutality"),(2, "Slaughter Games") }; } }
    }
}