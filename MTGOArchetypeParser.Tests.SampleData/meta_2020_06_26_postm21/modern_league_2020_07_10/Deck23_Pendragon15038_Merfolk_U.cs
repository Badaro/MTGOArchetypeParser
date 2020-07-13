using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_10
{
    public class Deck23_Pendragon15038_Merfolk_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Kumena's Speaker"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(4, "Merfolk Mistbinder"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(4, "Unsettled Mariner"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(2, "Spreading Seas"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(2, "Island"),
            new SampleCard(2, "Mutavault"),
            new SampleCard(4, "Unclaimed Territory"),
            new SampleCard(4, "Wanderwine Hub"),
            new SampleCard(4, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(2, "Damping Matrix"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Torpor Orb") 
        };
    }
}