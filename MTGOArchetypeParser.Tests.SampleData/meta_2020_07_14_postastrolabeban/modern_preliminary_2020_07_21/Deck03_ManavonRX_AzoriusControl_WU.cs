using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_21
{
    public class Deck03_ManavonRX_AzoriusControl_WU : ISampleDeck
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
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Frantic Inventory"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(1, "Castle Vantress"),
            new SampleCard(1, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(5, "Island"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(2, "Plains"),
            new SampleCard(3, "Polluted Delta") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(1, "Cataclysmic Gearhulk"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(2, "Circle of Protection: Red"),
            new SampleCard(1, "Commandeer"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(1, "Stony Silence"),
            new SampleCard(2, "Timely Reinforcements") 
        };
    }
}