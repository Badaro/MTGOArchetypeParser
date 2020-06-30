using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck02_katobu_Merfolk_WU_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Benthic Biomancer"),(4, "Harbinger of the Tides"),(4, "Lord of Atlantis"),(4, "Master of the Pearl Trident"),(4, "Merfolk Trickster"),(4, "Silvergill Adept"),(1, "Sygg, River Guide"),(4, "Unsettled Mariner"),(3, "Force of Negation"),(1, "Spell Snare"),(4, "Aether Vial"),(3, "Spreading Seas"),(2, "Cavern of Souls"),(2, "Hallowed Fountain"),(4, "Island"),(4, "Mutavault"),(4, "Seachrome Coast"),(4, "Wanderwine Hub") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Spreading Seas"),(2, "Aether Gust"),(2, "Celestial Purge"),(2, "Ceremonious Rejection"),(2, "Disenchant"),(1, "Grafdigger's Cage"),(1, "Lurrus of the Dream Den"),(1, "Mystical Dispute"),(3, "Relic of Progenitus") }; } }
    }
}