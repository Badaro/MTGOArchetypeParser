using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_19
{
    public class Deck17_Jositoshekel_Bogles_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Gladecover Scout"),
            new SampleCard(4, "Kor Spiritdancer"),
            new SampleCard(4, "Slippery Bogle"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Daybreak Coronet"),
            new SampleCard(4, "Ethereal Armor"),
            new SampleCard(2, "Gryff's Boon"),
            new SampleCard(2, "Hyena Umbra"),
            new SampleCard(4, "Rancor"),
            new SampleCard(4, "Spider Umbra"),
            new SampleCard(3, "Spirit Mantle"),
            new SampleCard(2, "Unflinching Courage"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(1, "Forest"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(3, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Path to Exile"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(3, "Gaddock Teeg"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(2, "Spirit Link") 
        };
    }
}