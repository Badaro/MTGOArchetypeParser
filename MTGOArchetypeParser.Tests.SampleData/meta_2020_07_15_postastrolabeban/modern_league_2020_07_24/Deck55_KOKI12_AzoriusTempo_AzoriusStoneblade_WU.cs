using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24
{
    public class Deck55_KOKI12_AzoriusTempo_AzoriusStoneblade_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(1, "Geist of Saint Traft"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(2, "Spell Queller"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Vendilion Clique"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Dismember"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Castle Ardenvale"),
            new SampleCard(3, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Glacial Fortress"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(5, "Island"),
            new SampleCard(2, "Plains"),
            new SampleCard(2, "Scalding Tarn") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Containment Priest"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Disenchant"),
            new SampleCard(1, "Elspeth, Sun's Nemesis"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(1, "Winds of Abandon") 
        };
    }
}