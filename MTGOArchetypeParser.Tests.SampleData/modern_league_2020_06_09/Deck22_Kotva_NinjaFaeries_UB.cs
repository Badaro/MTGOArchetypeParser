using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck22_Kotva_NinjaFaeries_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Liliana of the Veil"),(2, "Brazen Borrower"),(2, "Fallen Shinobi"),(2, "Snapcaster Mage"),(4, "Spellstutter Sprite"),(1, "Vendilion Clique"),(2, "Inquisition of Kozilek"),(2, "Thoughtseize"),(3, "Archmage's Charm"),(2, "Cling to Dust"),(3, "Cryptic Command"),(2, "Drown in the Loch"),(4, "Fatal Push"),(2, "Opt"),(3, "Bitterblossom"),(2, "Field of Ruin"),(4, "Flooded Strand"),(6, "Island"),(4, "Mystic Sanctuary"),(4, "Polluted Delta"),(1, "Swamp"),(3, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(2, "Ashiok, Dream Render"),(2, "Ceremonious Rejection"),(2, "Collective Brutality"),(2, "Damnation"),(1, "Force of Negation"),(2, "Kalitas, Traitor of Ghet"),(2, "Nihil Spellbomb") }; } }
    }
}