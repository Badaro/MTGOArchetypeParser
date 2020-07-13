using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07
{
    public class Deck51_Brunister_Dredge_WBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Golgari Thug"),
            new SampleCard(3, "Merchant of the Vale"),
            new SampleCard(4, "Narcomoeba"),
            new SampleCard(2, "Ox of Agonas"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(4, "Silversmote Ghoul"),
            new SampleCard(4, "Stinkweed Imp"),
            new SampleCard(4, "Cathartic Reunion"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(3, "Smiting Helix"),
            new SampleCard(1, "Darkblast"),
            new SampleCard(3, "Shriekhorn"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "City of Brass"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Sacred Foundry") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(4, "Ethersworn Canonist"),
            new SampleCard(3, "Lightning Axe"),
            new SampleCard(2, "Stony Silence"),
            new SampleCard(4, "Wear // Tear") 
        };
    }
}