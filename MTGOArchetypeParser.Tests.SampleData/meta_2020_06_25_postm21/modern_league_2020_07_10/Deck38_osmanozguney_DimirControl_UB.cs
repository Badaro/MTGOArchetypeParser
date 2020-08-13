using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_10
{
    public class Deck38_osmanozguney_DimirControl_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Nightmare Muse"),
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(1, "Notion Thief"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(2, "Damnation"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Drown in the Loch"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Hero's Downfall"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(3, "Creeping Tar Pit"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(5, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Sunken Hollow"),
            new SampleCard(2, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Force of Negation"),
            new SampleCard(1, "Hero's Downfall"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(4, "Leyline of the Void"),
            new SampleCard(2, "Ratchet Bomb") 
        };
    }
}