using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck45_Drakanar_Merfolk_UG : ISampleDeck
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
            new SampleCard(4, "Dismember"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(2, "Smuggler's Copter"),
            new SampleCard(4, "Spreading Seas"),
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
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(3, "Weather the Storm") 
        };
    }
}