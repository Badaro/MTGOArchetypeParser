using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_01
{
    public class Deck09_MlckyB_Bogles_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Gladecover Scout"),
            new SampleCard(4, "Kor Spiritdancer"),
            new SampleCard(4, "Slippery Bogle"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Daybreak Coronet"),
            new SampleCard(4, "Ethereal Armor"),
            new SampleCard(3, "Gryff's Boon"),
            new SampleCard(4, "Hyena Umbra"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(4, "Rancor"),
            new SampleCard(2, "Sentinel's Eyes"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(1, "Forest"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(2, "Plains"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(3, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Path to Exile"),
            new SampleCard(3, "Force of Vigor"),
            new SampleCard(3, "Gaddock Teeg"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Suppression Field"),
            new SampleCard(3, "Torpor Orb") 
        };
    }
}