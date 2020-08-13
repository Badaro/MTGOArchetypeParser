using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07
{
    public class Deck46_ocelot823_AzoriusTempo_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(3, "Brazen Borrower"),
            new SampleCard(4, "Brineborn Cutthroat"),
            new SampleCard(2, "Restoration Angel"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(3, "Spell Queller"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(2, "Vendilion Clique"),
            new SampleCard(1, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Opt"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Spell Pierce"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Glacial Fortress"),
            new SampleCard(3, "Hallowed Fountain"),
            new SampleCard(5, "Island"),
            new SampleCard(2, "Plains"),
            new SampleCard(2, "Polluted Delta") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Disenchant"),
            new SampleCard(1, "Dismember"),
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "Kitchen Finks"),
            new SampleCard(3, "Rest in Peace") 
        };
    }
}