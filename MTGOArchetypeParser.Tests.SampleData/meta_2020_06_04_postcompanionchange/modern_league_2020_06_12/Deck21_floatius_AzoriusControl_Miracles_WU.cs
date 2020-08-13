using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12
{
    public class Deck21_floatius_AzoriusControl_Miracles_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Terminus"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(4, "Celestial Colonnade"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(4, "Mystical Dispute"),
            new SampleCard(3, "Oust"),
            new SampleCard(4, "Timely Reinforcements") 
        };
    }
}