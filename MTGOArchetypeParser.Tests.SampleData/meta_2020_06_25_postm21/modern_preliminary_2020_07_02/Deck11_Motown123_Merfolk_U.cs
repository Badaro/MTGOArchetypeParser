using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_02
{
    public class Deck11_Motown123_Merfolk_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Benthic Biomancer"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(3, "Master of Waves"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(3, "Merrow Reejerey"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(3, "Spreading Seas"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(13, "Island"),
            new SampleCard(3, "Mutavault"),
            new SampleCard(2, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Dismember"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Damping Matrix"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Deprive"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Tidebinder Mage") 
        };
    }
}