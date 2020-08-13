using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_15
{
    public class Deck09_ZYURYO_AzoriusControl_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Narset, Parter of Veils"),
            new SampleCard(2, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(2, "Vendilion Clique"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(1, "Winds of Abandon"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(1, "Detention Sphere"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(3, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Glacial Fortress"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(5, "Island"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(2, "Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Containment Priest"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(2, "Monastery Mentor"),
            new SampleCard(1, "Rest in Peace"),
            new SampleCard(1, "Stony Silence"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}