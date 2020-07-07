using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_07
{
    public class Deck36_andresambiaze_Dredge_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Bloodghast"),
            new SampleCard(3, "Golgari Thug"),
            new SampleCard(3, "Merchant of the Vale"),
            new SampleCard(3, "Narcomoeba"),
            new SampleCard(2, "Ox of Agonas"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(2, "Silversmote Ghoul"),
            new SampleCard(4, "Stinkweed Imp"),
            new SampleCard(4, "Cathartic Reunion"),
            new SampleCard(2, "Conflagrate"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(3, "Life from the Loam"),
            new SampleCard(4, "Shriekhorn"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(1, "City of Brass"),
            new SampleCard(2, "Copperline Gorge"),
            new SampleCard(2, "Forgotten Cave"),
            new SampleCard(1, "Gemstone Mine"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ancient Grudge"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(2, "Leyline of the Void"),
            new SampleCard(3, "Lightning Axe"),
            new SampleCard(2, "Nature's Claim"),
            new SampleCard(2, "Pithing Needle"),
            new SampleCard(1, "Shenanigans"),
            new SampleCard(2, "Thoughtseize") 
        };
    }
}