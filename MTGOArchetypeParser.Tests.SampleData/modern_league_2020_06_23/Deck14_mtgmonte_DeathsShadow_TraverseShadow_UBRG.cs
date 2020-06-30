using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck14_mtgmonte_DeathsShadow_TraverseShadow_UBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Wrenn and Six"),(4, "Death's Shadow"),(1, "Lurrus of the Dream Den"),(1, "Scavenging Ooze"),(1, "Snapcaster Mage"),(4, "Street Wraith"),(4, "Tarmogoyf"),(2, "Inquisition of Kozilek"),(4, "Thoughtseize"),(3, "Traverse the Ulvenwald"),(1, "Dismember"),(3, "Fatal Push"),(2, "Stubborn Denial"),(1, "Temur Battle Rage"),(4, "Mishra's Bauble"),(2, "Footfall Crater"),(2, "Blood Crypt"),(1, "Breeding Pool"),(1, "Forest"),(2, "Nurturing Peatland"),(1, "Overgrown Tomb"),(4, "Polluted Delta"),(1, "Swamp"),(4, "Verdant Catacombs"),(1, "Watery Grave"),(3, "Tarfire") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Stubborn Denial"),(1, "Temur Battle Rage"),(1, "Abrupt Decay"),(1, "Anger of the Gods"),(2, "Assassin's Trophy"),(1, "Disdainful Stroke"),(1, "Kolaghan's Command"),(1, "Mystical Dispute"),(1, "Nihil Spellbomb"),(2, "Surgical Extraction"),(2, "Veil of Summer") }; } }
    }
}