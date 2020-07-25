using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25
{
    public class Deck03_chengyiw_Dredge_WBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Golgari Thug"),
            new SampleCard(2, "Merchant of the Vale"),
            new SampleCard(3, "Narcomoeba"),
            new SampleCard(3, "Ox of Agonas"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(4, "Silversmote Ghoul"),
            new SampleCard(4, "Stinkweed Imp"),
            new SampleCard(4, "Cathartic Reunion"),
            new SampleCard(1, "Conflagrate"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(3, "Life from the Loam"),
            new SampleCard(1, "Smiting Helix"),
            new SampleCard(4, "Shriekhorn"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "City of Brass"),
            new SampleCard(2, "Copperline Gorge"),
            new SampleCard(1, "Forgotten Cave"),
            new SampleCard(1, "Gemstone Mine"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ancient Grudge"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(4, "Lightning Axe"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}