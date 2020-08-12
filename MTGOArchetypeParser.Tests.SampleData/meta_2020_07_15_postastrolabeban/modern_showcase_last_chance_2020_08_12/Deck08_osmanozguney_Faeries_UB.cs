using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_showcase_last_chance_2020_08_12
{
    public class Deck08_osmanozguney_Faeries_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(3, "Brazen Borrower"),
            new SampleCard(1, "Mistbind Clique"),
            new SampleCard(4, "Spellstutter Sprite"),
            new SampleCard(3, "Vendilion Clique"),
            new SampleCard(3, "Cling to Dust"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(3, "Remand"),
            new SampleCard(4, "Bitterblossom"),
            new SampleCard(4, "Creeping Tar Pit"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(4, "Island"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Sunken Hollow"),
            new SampleCard(2, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Hero's Downfall"),
            new SampleCard(4, "Leyline of the Void"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}