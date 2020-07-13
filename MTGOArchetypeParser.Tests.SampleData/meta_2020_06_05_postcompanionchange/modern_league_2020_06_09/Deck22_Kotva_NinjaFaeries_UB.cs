using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_09
{
    public class Deck22_Kotva_NinjaFaeries_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Liliana of the Veil"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(2, "Fallen Shinobi"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(4, "Spellstutter Sprite"),
            new SampleCard(1, "Vendilion Clique"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Opt"),
            new SampleCard(3, "Bitterblossom"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(6, "Island"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Damnation"),
            new SampleCard(1, "Force of Negation"),
            new SampleCard(2, "Kalitas, Traitor of Ghet"),
            new SampleCard(2, "Nihil Spellbomb") 
        };
    }
}