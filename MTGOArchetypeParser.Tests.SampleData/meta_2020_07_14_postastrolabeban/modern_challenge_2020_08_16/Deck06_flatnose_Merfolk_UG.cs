using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_16
{
    public class Deck06_flatnose_Merfolk_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(4, "Kumena's Speaker"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(4, "Merfolk Mistbinder"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(2, "Tidebinder Mage"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(4, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(4, "Island"),
            new SampleCard(3, "Mutavault"),
            new SampleCard(4, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Tidebinder Mage"),
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(3, "Deprive"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Master of Waves"),
            new SampleCard(3, "Relic of Progenitus") 
        };
    }
}