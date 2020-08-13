using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_showcase_last_chance_2020_08_12
{
    public class Deck06_Ganksyou_AzoriusControl_AzoriusStoneblade_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(1, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(3, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Forsake the Worldly"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "Narset, Parter of Veils"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(2, "Timely Reinforcements") 
        };
    }
}