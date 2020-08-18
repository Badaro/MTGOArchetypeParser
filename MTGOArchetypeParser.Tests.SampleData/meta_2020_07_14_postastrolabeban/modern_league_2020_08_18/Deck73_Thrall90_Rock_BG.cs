using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck73_Thrall90_Rock_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(3, "Dark Confidant"),
            new SampleCard(3, "Hexdrinker"),
            new SampleCard(3, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(1, "Hissing Quagmire"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Swamp"),
            new SampleCard(1, "Treetop Village"),
            new SampleCard(2, "Twilight Mire"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(3, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(3, "Choke"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(2, "Kalitas, Traitor of Ghet"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}