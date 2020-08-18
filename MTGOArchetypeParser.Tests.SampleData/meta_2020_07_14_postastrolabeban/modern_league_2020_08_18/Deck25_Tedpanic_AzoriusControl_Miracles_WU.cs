using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck25_Tedpanic_AzoriusControl_Miracles_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Hero of Dominaria"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(2, "Terminus"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(1, "Crucible of Worlds"),
            new SampleCard(1, "Search for Azcanta"),
            new SampleCard(1, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(5, "Island"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(1, "Scalding Tarn") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(1, "Terminus"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Leyline of Sanctity"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Stony Silence"),
            new SampleCard(2, "Timely Reinforcements") 
        };
    }
}