using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck48_TheDogFish_Merfolk_WU_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Benthic Biomancer"),
            new SampleCard(4, "Harbinger of the Tides"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(4, "Unsettled Mariner"),
            new SampleCard(3, "Dismember"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(3, "Spreading Seas"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(8, "Island"),
            new SampleCard(3, "Mutavault"),
            new SampleCard(3, "Seachrome Coast"),
            new SampleCard(4, "Wanderwine Hub") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Force of Negation"),
            new SampleCard(1, "Spreading Seas"),
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(2, "Echoing Truth"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(3, "Tidebinder Mage") 
        };
    }
}