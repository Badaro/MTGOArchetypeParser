using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck50_Zxrogue_AzoriusControl_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(5, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(1, "Scalding Tarn") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(2, "Monastery Mentor"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Timely Reinforcements") 
        };
    }
}