using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_28
{
    public class Deck50_MHayashi_Merfolk_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Brazen Borrower"),
            new SampleCard(4, "Harbinger of the Tides"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(4, "Smuggler's Copter"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(4, "Castle Vantress"),
            new SampleCard(12, "Island"),
            new SampleCard(4, "Mutavault") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(4, "Deprive"),
            new SampleCard(4, "Dismember"),
            new SampleCard(4, "Relic of Progenitus") 
        };
    }
}