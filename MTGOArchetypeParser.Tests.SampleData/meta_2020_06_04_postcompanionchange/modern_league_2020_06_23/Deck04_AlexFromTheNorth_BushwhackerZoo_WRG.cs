using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_23
{
    public class Deck04_AlexFromTheNorth_BushwhackerZoo_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Burning-Tree Emissary"),
            new SampleCard(3, "Experiment One"),
            new SampleCard(1, "Ghor-Clan Rampager"),
            new SampleCard(3, "Goblin Guide"),
            new SampleCard(3, "Hidden Herbalists"),
            new SampleCard(2, "Kird Ape"),
            new SampleCard(4, "Narnam Renegade"),
            new SampleCard(4, "Reckless Bushwhacker"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Wild Nacatl"),
            new SampleCard(4, "Atarka's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Rancor"),
            new SampleCard(3, "Arid Mesa"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills"),
            new SampleCard(1, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Destructive Revelry"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(2, "Rampaging Ferocidon"),
            new SampleCard(2, "Tormod's Crypt") 
        };
    }
}