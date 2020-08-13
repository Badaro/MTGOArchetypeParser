using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_06_28
{
    public class Deck21_Mercenario_Dredge_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bloodghast"),
            new SampleCard(2, "Golgari Thug"),
            new SampleCard(3, "Merchant of the Vale"),
            new SampleCard(4, "Narcomoeba"),
            new SampleCard(2, "Ox of Agonas"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(4, "Stinkweed Imp"),
            new SampleCard(4, "Cathartic Reunion"),
            new SampleCard(1, "Conflagrate"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(4, "Life from the Loam"),
            new SampleCard(4, "Shriekhorn"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(1, "City of Brass"),
            new SampleCard(2, "Copperline Gorge"),
            new SampleCard(1, "Dakmor Salvage"),
            new SampleCard(2, "Forgotten Cave"),
            new SampleCard(2, "Mountain"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Conflagrate"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(4, "Lightning Axe"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(1, "Shenanigans"),
            new SampleCard(2, "Thoughtseize") 
        };
    }
}