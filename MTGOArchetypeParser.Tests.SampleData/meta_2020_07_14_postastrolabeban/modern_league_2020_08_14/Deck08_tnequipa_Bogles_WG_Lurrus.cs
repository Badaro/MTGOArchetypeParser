using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck08_tnequipa_Bogles_WG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Gladecover Scout"),
            new SampleCard(4, "Kor Spiritdancer"),
            new SampleCard(4, "Slippery Bogle"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "All That Glitters"),
            new SampleCard(1, "Cartouche of Solidarity"),
            new SampleCard(4, "Daybreak Coronet"),
            new SampleCard(4, "Ethereal Armor"),
            new SampleCard(2, "Gryff's Boon"),
            new SampleCard(3, "Hyena Umbra"),
            new SampleCard(4, "Rancor"),
            new SampleCard(4, "Spider Umbra"),
            new SampleCard(1, "Spirit Link"),
            new SampleCard(2, "Spirit Mantle"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(1, "Forest"),
            new SampleCard(2, "Plains"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(4, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Gaddock Teeg"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Seal of Primordium") 
        };
    }
}