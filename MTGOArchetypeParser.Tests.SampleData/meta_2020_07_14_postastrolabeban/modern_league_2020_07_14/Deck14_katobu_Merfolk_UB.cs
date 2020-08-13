using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_14
{
    public class Deck14_katobu_Merfolk_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Benthic Biomancer"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(2, "Harbinger of the Tides"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(4, "Merrow Reejerey"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(1, "Aquitect's Will"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(2, "Spreading Seas"),
            new SampleCard(3, "Cavern of Souls"),
            new SampleCard(2, "Darkslick Shores"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(7, "Island"),
            new SampleCard(4, "Mutavault"),
            new SampleCard(1, "Oboro, Palace in the Clouds") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Dismember"),
            new SampleCard(2, "Spreading Seas"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(4, "Tidebinder Mage") 
        };
    }
}