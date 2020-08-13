using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_16
{
    public class Deck23_iuriper_Merfolk_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Benthic Biomancer"),
            new SampleCard(4, "Cursecatcher"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(3, "Merrow Reejerey"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(3, "Dismember"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(3, "Darkslick Shores"),
            new SampleCard(3, "Mutavault"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(9, "Snow-Covered Island") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(3, "Tidebinder Mage") 
        };
    }
}