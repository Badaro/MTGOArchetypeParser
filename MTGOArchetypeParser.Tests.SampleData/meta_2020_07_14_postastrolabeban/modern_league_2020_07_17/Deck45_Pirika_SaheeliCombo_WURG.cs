using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_17
{
    public class Deck45_Pirika_SaheeliCombo_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Saheeli Rai"),
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(4, "Felidar Guardian"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(1, "Venser, Shaper Savant"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Lightning Helix"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Glacial Fortress"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(3, "Island"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(1, "Sulfur Falls") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Dovin's Veto"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(3, "Thing in the Ice") 
        };
    }
}