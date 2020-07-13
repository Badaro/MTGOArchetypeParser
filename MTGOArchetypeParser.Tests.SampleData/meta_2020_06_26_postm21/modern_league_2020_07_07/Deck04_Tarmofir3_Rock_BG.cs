using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07
{
    public class Deck04_Tarmofir3_Rock_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(4, "Dark Confidant"),
            new SampleCard(3, "Grim Flayer"),
            new SampleCard(3, "Hexdrinker"),
            new SampleCard(3, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(2, "Forest"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(4, "Overgrown Tomb"),
            new SampleCard(3, "Swamp"),
            new SampleCard(1, "Treetop Village"),
            new SampleCard(4, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Choke"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(1, "Kitchen Finks"),
            new SampleCard(1, "Nature's Claim"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Thrun, the Last Troll") 
        };
    }
}