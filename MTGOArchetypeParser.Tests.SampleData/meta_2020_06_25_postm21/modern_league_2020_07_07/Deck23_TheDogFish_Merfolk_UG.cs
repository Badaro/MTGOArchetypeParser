using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07
{
    public class Deck23_TheDogFish_Merfolk_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Kumena's Speaker"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(4, "Merfolk Mistbinder"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(4, "Merrow Reejerey"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(3, "Dismember"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(2, "Spreading Seas"),
            new SampleCard(4, "Botanical Sanctum"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(3, "Mutavault"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(4, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Force of Negation"),
            new SampleCard(1, "Spreading Seas"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(2, "Damping Matrix"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Deprive"),
            new SampleCard(3, "Relic of Progenitus") 
        };
    }
}