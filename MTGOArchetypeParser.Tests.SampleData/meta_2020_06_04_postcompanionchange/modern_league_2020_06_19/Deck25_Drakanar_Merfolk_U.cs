using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_19
{
    public class Deck25_Drakanar_Merfolk_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Benthic Biomancer"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(3, "Master of Waves"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(4, "Merrow Reejerey"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(3, "Dismember"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(2, "Spreading Seas"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(4, "Mutavault"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(11, "Snow-Covered Island"),
            new SampleCard(3, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Master of Waves"),
            new SampleCard(1, "Force of Negation"),
            new SampleCard(1, "Spreading Seas"),
            new SampleCard(3, "Damping Matrix"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Deprive"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Relic of Progenitus") 
        };
    }
}