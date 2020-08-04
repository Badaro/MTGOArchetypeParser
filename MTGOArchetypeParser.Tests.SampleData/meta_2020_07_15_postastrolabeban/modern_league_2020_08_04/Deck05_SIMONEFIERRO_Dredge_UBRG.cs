using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck05_SIMONEFIERRO_Dredge_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bloodghast"),
            new SampleCard(1, "Golgari Thug"),
            new SampleCard(3, "Merchant of the Vale"),
            new SampleCard(3, "Narcomoeba"),
            new SampleCard(2, "Ox of Agonas"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(4, "Stinkweed Imp"),
            new SampleCard(4, "Cathartic Reunion"),
            new SampleCard(2, "Conflagrate"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(4, "Life from the Loam"),
            new SampleCard(1, "Darkblast"),
            new SampleCard(4, "Shriekhorn"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(2, "Blackcleave Cliffs"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(1, "Bloodstained Mire"),
            new SampleCard(3, "Copperline Gorge"),
            new SampleCard(1, "Dakmor Salvage"),
            new SampleCard(2, "Forgotten Cave"),
            new SampleCard(1, "Gemstone Mine"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(3, "Lightning Axe"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(2, "Shenanigans"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}