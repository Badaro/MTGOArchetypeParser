using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_10
{
    public class Deck03_J000111_Dredge_WBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Golgari Thug"),
            new SampleCard(3, "Merchant of the Vale"),
            new SampleCard(3, "Narcomoeba"),
            new SampleCard(3, "Ox of Agonas"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(4, "Silversmote Ghoul"),
            new SampleCard(4, "Stinkweed Imp"),
            new SampleCard(4, "Cathartic Reunion"),
            new SampleCard(2, "Conflagrate"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(4, "Life from the Loam"),
            new SampleCard(1, "Smiting Helix"),
            new SampleCard(3, "Shriekhorn"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(2, "Forgotten Cave"),
            new SampleCard(1, "Gemstone Caverns"),
            new SampleCard(1, "Gemstone Mine"),
            new SampleCard(2, "Mountain"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ancient Grudge"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(2, "Leyline of Sanctity"),
            new SampleCard(1, "Leyline of the Void"),
            new SampleCard(2, "Lightning Axe"),
            new SampleCard(2, "Nature's Claim"),
            new SampleCard(2, "Pithing Needle"),
            new SampleCard(1, "Shenanigans"),
            new SampleCard(2, "Thoughtseize") 
        };
    }
}