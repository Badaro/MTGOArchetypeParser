using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07
{
    public class Deck31_Mathieu23_AzoriusControl_AzoriusStoneblade_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(1, "Logic Knot"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(1, "Celestial Colonnade"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hall of Heliod's Generosity"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(5, "Island"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(2, "Plains"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(1, "Prairie Stream") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Batterskull"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "Rest in Peace"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(2, "Timely Reinforcements") 
        };
    }
}