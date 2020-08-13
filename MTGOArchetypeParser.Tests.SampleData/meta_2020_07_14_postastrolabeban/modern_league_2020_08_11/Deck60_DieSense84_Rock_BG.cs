using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck60_DieSense84_Rock_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(4, "Dark Confidant"),
            new SampleCard(2, "Hexdrinker"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(1, "Traverse the Ulvenwald"),
            new SampleCard(4, "Assassin's Trophy"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(1, "Castle Locthwain"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(2, "Forest"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(3, "Swamp"),
            new SampleCard(1, "Urborg, Tomb of Yawgmoth"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(3, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Dead Weight"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}