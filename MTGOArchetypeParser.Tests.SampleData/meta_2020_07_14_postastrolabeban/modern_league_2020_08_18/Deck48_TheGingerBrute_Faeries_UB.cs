using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck48_TheGingerBrute_Faeries_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Master of Time"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(4, "Spellstutter Sprite"),
            new SampleCard(1, "Vendilion Clique"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(1, "Eliminate"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Opt"),
            new SampleCard(4, "Bitterblossom"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(6, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Sunken Hollow"),
            new SampleCard(1, "Swamp"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Ashiok, Nightmare Muse"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Kalitas, Traitor of Ghet"),
            new SampleCard(2, "Plague Engineer") 
        };
    }
}