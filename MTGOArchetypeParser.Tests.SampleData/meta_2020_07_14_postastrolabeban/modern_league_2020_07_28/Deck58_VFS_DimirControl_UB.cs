using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_28
{
    public class Deck58_VFS_DimirControl_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Drown in the Loch"),
            new SampleCard(1, "Eliminate"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(3, "Shadow of Doubt"),
            new SampleCard(3, "Spell Snare"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(6, "Island"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Eliminate"),
            new SampleCard(1, "Force of Negation"),
            new SampleCard(1, "Shark Typhoon"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(3, "Damnation"),
            new SampleCard(3, "Ravenous Trap"),
            new SampleCard(3, "Spell Pierce") 
        };
    }
}