using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck46_Deulotar_Rock_BG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Liliana of the Veil"),(4, "Dark Confidant"),(3, "Hexdrinker"),(2, "Scavenging Ooze"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(2, "Thoughtseize"),(1, "Abrupt Decay"),(3, "Assassin's Trophy"),(3, "Fatal Push"),(4, "Mishra's Bauble"),(2, "Nihil Spellbomb"),(4, "Blooming Marsh"),(2, "Forest"),(3, "Ghost Quarter"),(2, "Hissing Quagmire"),(2, "Nurturing Peatland"),(2, "Overgrown Tomb"),(3, "Swamp"),(4, "Verdant Catacombs"),(3, "Lurrus of the Dream-Den") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Ghost Quarter"),(2, "Ashiok, Dream Render"),(1, "Collective Brutality"),(2, "Fulminator Mage"),(1, "Golgari Charm"),(2, "Kalitas, Traitor of Ghet"),(2, "Plague Engineer"),(2, "Torpor Orb"),(2, "Veil of Summer") }; } }
    }
}