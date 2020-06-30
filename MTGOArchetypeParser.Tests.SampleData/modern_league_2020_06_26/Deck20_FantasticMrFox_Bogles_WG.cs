using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck20_FantasticMrFox_Bogles_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Gladecover Scout"),
            new SampleCard(4, "Kor Spiritdancer"),
            new SampleCard(4, "Slippery Bogle"),
            new SampleCard(2, "All That Glitters"),
            new SampleCard(4, "Daybreak Coronet"),
            new SampleCard(4, "Ethereal Armor"),
            new SampleCard(4, "Gryff's Boon"),
            new SampleCard(2, "Hyena Umbra"),
            new SampleCard(4, "Rancor"),
            new SampleCard(4, "Spider Umbra"),
            new SampleCard(2, "Spirit Link"),
            new SampleCard(2, "Spirit Mantle"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(1, "Forest"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(2, "Plains"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Gaddock Teeg"),
            new SampleCard(4, "Kor Firewalker"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(3, "Seal of Primordium"),
            new SampleCard(3, "Soul-Guide Lantern") 
        };
    }
}