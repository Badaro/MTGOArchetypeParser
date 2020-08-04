using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck68_Valyan_Rock_WBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(3, "Lingering Souls"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Traverse the Ulvenwald"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Gavony Township"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(1, "Indatha Triome"),
            new SampleCard(3, "Marsh Flats"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Swamp"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(1, "Kambal, Consul of Allocation"),
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}