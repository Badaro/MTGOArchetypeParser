using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_12
{
    public class Deck02_katobu_Merfolk_WU_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Benthic Biomancer"),
            new SampleCard(4, "Harbinger of the Tides"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(1, "Sygg, River Guide"),
            new SampleCard(4, "Unsettled Mariner"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(3, "Spreading Seas"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(4, "Island"),
            new SampleCard(4, "Mutavault"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(4, "Wanderwine Hub") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Spreading Seas"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Disenchant"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Lurrus of the Dream Den"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(3, "Relic of Progenitus") 
        };
    }
}