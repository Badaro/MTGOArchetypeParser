using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_17
{
    public class Deck06_billsive_AzoriusControl_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(1, "Deprive"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Frantic Inventory"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(1, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Disenchant"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Narset, Parter of Veils"),
            new SampleCard(3, "Timely Reinforcements") 
        };
    }
}