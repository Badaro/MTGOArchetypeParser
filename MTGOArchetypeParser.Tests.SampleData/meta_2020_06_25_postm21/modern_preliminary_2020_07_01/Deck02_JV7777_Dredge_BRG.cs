using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_01
{
    public class Deck02_JV7777_Dredge_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bloodghast"),
            new SampleCard(2, "Golgari Thug"),
            new SampleCard(3, "Merchant of the Vale"),
            new SampleCard(3, "Narcomoeba"),
            new SampleCard(2, "Ox of Agonas"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(4, "Stinkweed Imp"),
            new SampleCard(4, "Cathartic Reunion"),
            new SampleCard(2, "Conflagrate"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(4, "Life from the Loam"),
            new SampleCard(4, "Shriekhorn"),
            new SampleCard(1, "Blackcleave Cliffs"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(1, "Copperline Gorge"),
            new SampleCard(1, "Dakmor Salvage"),
            new SampleCard(2, "Forgotten Cave"),
            new SampleCard(1, "Mana Confluence"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(3, "Lightning Axe"),
            new SampleCard(2, "Nature's Claim"),
            new SampleCard(2, "Shenanigans"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}