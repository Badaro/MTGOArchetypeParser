using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck34_Boin_Rock_BG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Grim Flayer"),
            new SampleCard(2, "Hexdrinker"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Unearth"),
            new SampleCard(4, "Assassin's Trophy"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Dead Weight"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Swamp"),
            new SampleCard(4, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Dead Weight"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(1, "Chevill, Bane of Monsters"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Executioner's Capsule"),
            new SampleCard(1, "Lurrus of the Dream Den"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}