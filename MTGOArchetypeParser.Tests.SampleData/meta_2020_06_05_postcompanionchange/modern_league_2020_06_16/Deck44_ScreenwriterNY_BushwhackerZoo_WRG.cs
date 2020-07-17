using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16
{
    public class Deck44_ScreenwriterNY_BushwhackerZoo_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Burning-Tree Emissary"),
            new SampleCard(3, "Gallia of the Endless Dance"),
            new SampleCard(2, "Ghor-Clan Rampager"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(1, "Hexdrinker"),
            new SampleCard(4, "Hidden Herbalists"),
            new SampleCard(4, "Narnam Renegade"),
            new SampleCard(4, "Reckless Bushwhacker"),
            new SampleCard(2, "Tarmogoyf"),
            new SampleCard(4, "Wild Nacatl"),
            new SampleCard(4, "Atarka's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(3, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills"),
            new SampleCard(1, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Tarmogoyf"),
            new SampleCard(1, "Dismember"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(2, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Tormod's Crypt") 
        };
    }
}