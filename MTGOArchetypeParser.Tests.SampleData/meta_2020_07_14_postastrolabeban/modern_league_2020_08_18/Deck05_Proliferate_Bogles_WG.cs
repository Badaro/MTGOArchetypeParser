using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck05_Proliferate_Bogles_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Gladecover Scout"),
            new SampleCard(4, "Kor Spiritdancer"),
            new SampleCard(4, "Slippery Bogle"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(4, "Daybreak Coronet"),
            new SampleCard(4, "Ethereal Armor"),
            new SampleCard(1, "Gryff's Boon"),
            new SampleCard(4, "Hyena Umbra"),
            new SampleCard(3, "Leyline of Sanctity"),
            new SampleCard(4, "Rancor"),
            new SampleCard(3, "Spider Umbra"),
            new SampleCard(1, "Spirit Link"),
            new SampleCard(2, "Spirit Mantle"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(1, "Forest"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(4, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Leyline of Sanctity"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Gaddock Teeg"),
            new SampleCard(3, "Hushbringer"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Seal of Primordium"),
            new SampleCard(3, "Suppression Field") 
        };
    }
}