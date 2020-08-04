using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck41_crussedull_Rock_WBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Liliana of the Veil"),
            new SampleCard(1, "Fulminator Mage"),
            new SampleCard(3, "Grim Flayer"),
            new SampleCard(2, "Hexdrinker"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(2, "Traverse the Ulvenwald"),
            new SampleCard(2, "Unearth"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(1, "Kaya's Guile"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Blooming Marsh"),
            new SampleCard(2, "Concealed Courtyard"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(2, "Marsh Flats"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Swamp"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Windswept Heath"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Fulminator Mage"),
            new SampleCard(1, "Liliana of the Veil"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(1, "Mythos of Nethroi"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Phyrexian Revoker"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(1, "Shriekmaw") 
        };
    }
}