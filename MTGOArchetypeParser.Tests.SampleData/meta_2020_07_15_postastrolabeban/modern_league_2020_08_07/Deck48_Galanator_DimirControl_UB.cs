using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck48_Galanator_DimirControl_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Narset, Parter of Veils"),
            new SampleCard(2, "Vendilion Clique"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Deprive"),
            new SampleCard(1, "Dismember"),
            new SampleCard(1, "Drown in the Loch"),
            new SampleCard(1, "Eliminate"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(1, "Mana Leak"),
            new SampleCard(3, "Remand"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(2, "Geier Reach Sanitarium"),
            new SampleCard(6, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(1, "Sunken Hollow"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Spell Snare"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Damnation"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(2, "Notion Thief"),
            new SampleCard(1, "Teferi's Puzzle Box") 
        };
    }
}