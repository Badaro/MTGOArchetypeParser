using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck40_EladWin_JeskaiControl_JeskaiStoneblade_WUR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Lightning Helix"),
            new SampleCard(4, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(2, "Celestial Colonnade"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Dovin's Veto"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Timely Reinforcements") 
        };
    }
}