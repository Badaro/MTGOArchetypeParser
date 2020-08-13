using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_06_30
{
    public class Deck46_Deulotar_Rock_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(4, "Dark Confidant"),
            new SampleCard(3, "Hexdrinker"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(2, "Forest"),
            new SampleCard(3, "Ghost Quarter"),
            new SampleCard(2, "Hissing Quagmire"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(3, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(3, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(2, "Fulminator Mage"),
            new SampleCard(1, "Golgari Charm"),
            new SampleCard(2, "Kalitas, Traitor of Ghet"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Torpor Orb"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}