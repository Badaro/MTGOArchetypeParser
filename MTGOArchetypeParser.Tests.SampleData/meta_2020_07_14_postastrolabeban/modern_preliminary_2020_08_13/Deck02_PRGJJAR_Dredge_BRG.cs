using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_13
{
    public class Deck02_PRGJJAR_Dredge_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bloodghast"),
            new SampleCard(2, "Golgari Thug"),
            new SampleCard(3, "Merchant of the Vale"),
            new SampleCard(4, "Narcomoeba"),
            new SampleCard(3, "Ox of Agonas"),
            new SampleCard(3, "Prized Amalgam"),
            new SampleCard(4, "Stinkweed Imp"),
            new SampleCard(4, "Cathartic Reunion"),
            new SampleCard(1, "Conflagrate"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(4, "Life from the Loam"),
            new SampleCard(4, "Shriekhorn"),
            new SampleCard(3, "Arid Mesa"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(2, "Copperline Gorge"),
            new SampleCard(1, "Dakmor Salvage"),
            new SampleCard(2, "Forgotten Cave"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Conflagrate"),
            new SampleCard(2, "Ancient Grudge"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Leyline of Sanctity"),
            new SampleCard(3, "Lightning Axe"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}