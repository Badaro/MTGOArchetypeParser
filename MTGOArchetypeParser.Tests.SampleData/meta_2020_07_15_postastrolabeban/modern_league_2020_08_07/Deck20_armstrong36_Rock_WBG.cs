using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck20_armstrong36_Rock_WBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(4, "Grim Flayer"),
            new SampleCard(1, "Questing Beast"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(2, "Stoneforge Mystic"),
            new SampleCard(3, "Tarmogoyf"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(2, "Lingering Souls"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Traverse the Ulvenwald"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(3, "Mishra's Bauble"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Sword of Light and Shadow"),
            new SampleCard(3, "Blooming Marsh"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(3, "Marsh Flats"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Swamp"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(1, "Treetop Village"),
            new SampleCard(3, "Verdant Catacombs"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(1, "Qasali Pridemage") 
        };
    }
}