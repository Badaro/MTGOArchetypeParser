using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25
{
    public class Deck12_Granham_AzoriusControl_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Elspeth, Knight-Errant"),
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Frantic Inventory"),
            new SampleCard(1, "Logic Knot"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(2, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(6, "Island"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(2, "Plains"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(1, "Scalding Tarn") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(1, "Elspeth, Sun's Nemesis"),
            new SampleCard(1, "Gideon of the Trials"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(3, "Timely Reinforcements") 
        };
    }
}