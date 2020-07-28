using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck63_Enigma01_Merfolk_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Benthic Biomancer"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(4, "Master of Waves"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(3, "Merrow Reejerey"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(2, "Tidebinder Mage"),
            new SampleCard(3, "Dismember"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(2, "Spreading Seas"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(13, "Island"),
            new SampleCard(4, "Mutavault"),
            new SampleCard(1, "Oboro, Palace in the Clouds") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Tidebinder Mage"),
            new SampleCard(1, "Spreading Seas"),
            new SampleCard(3, "Deprive"),
            new SampleCard(2, "Kira, Great Glass-Spinner"),
            new SampleCard(2, "Mistcaller"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(2, "Repeal") 
        };
    }
}