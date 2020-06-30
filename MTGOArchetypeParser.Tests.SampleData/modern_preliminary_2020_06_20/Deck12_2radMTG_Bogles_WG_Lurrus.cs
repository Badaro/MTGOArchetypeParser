using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck12_2radMTG_Bogles_WG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Gladecover Scout"),
            new SampleCard(4, "Kor Spiritdancer"),
            new SampleCard(4, "Slippery Bogle"),
            new SampleCard(4, "Daybreak Coronet"),
            new SampleCard(4, "Ethereal Armor"),
            new SampleCard(2, "Gryff's Boon"),
            new SampleCard(4, "Hyena Umbra"),
            new SampleCard(3, "Leyline of Sanctity"),
            new SampleCard(4, "Rancor"),
            new SampleCard(3, "Spider Umbra"),
            new SampleCard(1, "Spirit Link"),
            new SampleCard(2, "Spirit Mantle"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(2, "Forest"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(2, "Plains"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(4, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(2, "Gaddock Teeg"),
            new SampleCard(1, "Lurrus of the Dream Den"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(3, "Pithing Needle"),
            new SampleCard(3, "Suppression Field") 
        };
    }
}