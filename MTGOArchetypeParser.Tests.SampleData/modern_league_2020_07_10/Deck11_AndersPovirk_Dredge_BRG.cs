using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10
{
    public class Deck11_AndersPovirk_Dredge_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bloodghast"),
            new SampleCard(3, "Golgari Thug"),
            new SampleCard(3, "Merchant of the Vale"),
            new SampleCard(3, "Narcomoeba"),
            new SampleCard(3, "Ox of Agonas"),
            new SampleCard(3, "Prized Amalgam"),
            new SampleCard(4, "Stinkweed Imp"),
            new SampleCard(4, "Cathartic Reunion"),
            new SampleCard(1, "Conflagrate"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(4, "Life from the Loam"),
            new SampleCard(4, "Shriekhorn"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "City of Brass"),
            new SampleCard(1, "Copperline Gorge"),
            new SampleCard(1, "Dakmor Salvage"),
            new SampleCard(2, "Forgotten Cave"),
            new SampleCard(2, "Mountain"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ancient Grudge"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Darkblast"),
            new SampleCard(2, "Leyline of the Void"),
            new SampleCard(3, "Lightning Axe"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(1, "Shenanigans"),
            new SampleCard(2, "Thoughtseize") 
        };
    }
}