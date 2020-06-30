using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_06
{
    public class Deck07_ilsecco14_Rock_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(3, "Dark Confidant"),
            new SampleCard(3, "Grim Flayer"),
            new SampleCard(3, "Hexdrinker"),
            new SampleCard(4, "Kitchen Finks"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(2, "Forest"),
            new SampleCard(2, "Marsh Flats"),
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
            new SampleCard(1, "Nature's Claim"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Thrun, the Last Troll") 
        };
    }
}