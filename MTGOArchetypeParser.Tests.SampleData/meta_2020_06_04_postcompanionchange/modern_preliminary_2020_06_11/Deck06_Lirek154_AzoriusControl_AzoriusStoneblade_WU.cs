using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_11
{
    public class Deck06_Lirek154_AzoriusControl_AzoriusStoneblade_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Narset, Parter of Veils"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(3, "Spell Queller"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(2, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Glacial Fortress"),
            new SampleCard(3, "Hallowed Fountain"),
            new SampleCard(5, "Island"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(2, "Plains"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(1, "Seachrome Coast") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(1, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Disenchant"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "Rest in Peace"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(1, "Sword of Fire and Ice") 
        };
    }
}