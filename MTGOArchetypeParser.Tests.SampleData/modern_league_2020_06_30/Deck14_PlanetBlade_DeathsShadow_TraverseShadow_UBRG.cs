using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck14_PlanetBlade_DeathsShadow_TraverseShadow_UBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Death's Shadow"),(4, "Street Wraith"),(4, "Tarmogoyf"),(3, "Inquisition of Kozilek"),(4, "Thoughtseize"),(3, "Traverse the Ulvenwald"),(2, "Cling to Dust"),(2, "Dismember"),(2, "Drown in the Loch"),(4, "Fatal Push"),(4, "Stubborn Denial"),(2, "Temur Battle Rage"),(4, "Mishra's Bauble"),(1, "Blood Crypt"),(2, "Bloodstained Mire"),(1, "Breeding Pool"),(1, "Nurturing Peatland"),(1, "Overgrown Tomb"),(4, "Polluted Delta"),(1, "Swamp"),(4, "Verdant Catacombs"),(2, "Watery Grave"),(1, "Lurrus of the Dream-Den") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(1, "Assassin's Trophy"),(2, "Collective Brutality"),(2, "Disdainful Stroke"),(2, "Engineered Explosives"),(2, "Mystical Dispute"),(2, "Nihil Spellbomb"),(2, "Veil of Summer") }; } }
    }
}