using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck73_eastonmd21_AzoriusTempo_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(1, "Restoration Angel"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(2, "Spell Queller"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Vendilion Clique"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Fact or Fiction"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Remand"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(2, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(3, "Hallowed Fountain"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Condemn"),
            new SampleCard(1, "Detention Sphere"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(2, "Timely Reinforcements") 
        };
    }
}