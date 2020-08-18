using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck39_kogamo_AzoriusControl_AzoriusStoneblade_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Shark Typhoon"),
            new SampleCard(1, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(3, "Hallowed Fountain"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(1, "Condemn"),
            new SampleCard(1, "Detention Sphere"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(1, "Vendilion Clique") 
        };
    }
}