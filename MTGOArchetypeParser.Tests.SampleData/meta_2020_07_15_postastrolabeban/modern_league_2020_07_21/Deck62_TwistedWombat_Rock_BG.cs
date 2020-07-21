using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_21
{
    public class Deck62_TwistedWombat_Rock_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(4, "Grim Flayer"),
            new SampleCard(2, "Hexdrinker"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(2, "Tireless Tracker"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(2, "Maelstrom Pulse"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Unearth"),
            new SampleCard(4, "Assassin's Trophy"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(1, "Hissing Quagmire"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(1, "Twilight Mire"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Choke"),
            new SampleCard(4, "Collective Brutality"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}