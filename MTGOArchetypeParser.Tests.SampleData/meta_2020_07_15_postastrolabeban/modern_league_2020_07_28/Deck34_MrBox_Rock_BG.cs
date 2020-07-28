using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck34_MrBox_Rock_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(2, "Dark Confidant"),
            new SampleCard(2, "Hexdrinker"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(1, "Unearth"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(2, "Forest"),
            new SampleCard(2, "Hissing Quagmire"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(3, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(3, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Choke"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Plague Engineer") 
        };
    }
}