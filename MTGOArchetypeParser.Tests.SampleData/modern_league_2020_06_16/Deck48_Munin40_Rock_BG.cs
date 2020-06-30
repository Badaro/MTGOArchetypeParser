using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck48_Munin40_Rock_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(4, "Grim Flayer"),
            new SampleCard(4, "Hexdrinker"),
            new SampleCard(2, "Lurrus of the Dream Den"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(4, "Assassin's Trophy"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(2, "Forest"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(3, "Swamp"),
            new SampleCard(1, "Twilight Mire"),
            new SampleCard(4, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Dead Weight"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Nihil Spellbomb") 
        };
    }
}