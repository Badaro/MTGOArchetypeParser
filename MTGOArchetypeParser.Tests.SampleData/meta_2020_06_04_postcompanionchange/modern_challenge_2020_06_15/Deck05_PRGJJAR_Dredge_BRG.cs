using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_challenge_2020_06_15
{
    public class Deck05_PRGJJAR_Dredge_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Bloodghast"),
            new SampleCard(3, "Golgari Thug"),
            new SampleCard(3, "Merchant of the Vale"),
            new SampleCard(4, "Narcomoeba"),
            new SampleCard(3, "Ox of Agonas"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(4, "Stinkweed Imp"),
            new SampleCard(4, "Cathartic Reunion"),
            new SampleCard(1, "Conflagrate"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(3, "Life from the Loam"),
            new SampleCard(4, "Shriekhorn"),
            new SampleCard(3, "Arid Mesa"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(2, "Copperline Gorge"),
            new SampleCard(1, "Dakmor Salvage"),
            new SampleCard(2, "Forgotten Cave"),
            new SampleCard(1, "Gemstone Mine"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Conflagrate"),
            new SampleCard(2, "Ancient Grudge"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(3, "Lightning Axe"),
            new SampleCard(2, "Nature's Claim"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Thoughtseize") 
        };
    }
}