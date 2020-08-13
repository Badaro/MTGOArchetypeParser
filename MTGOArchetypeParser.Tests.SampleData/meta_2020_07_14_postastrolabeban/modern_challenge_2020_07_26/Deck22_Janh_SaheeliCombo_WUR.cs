using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_07_26
{
    public class Deck22_Janh_SaheeliCombo_WUR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Saheeli Rai"),
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(4, "Felidar Guardian"),
            new SampleCard(2, "Seasoned Pyromancer"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Lightning Helix"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(3, "Remand"),
            new SampleCard(2, "Omen of the Sea"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(2, "Celestial Colonnade"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Raugrin Triome"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(2, "Sulfur Falls") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Lightning Helix"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(3, "Flusterstorm"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}