using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck55_takutin09007_BushwhackerZoo_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Burning-Tree Emissary"),
            new SampleCard(3, "Gallia of the Endless Dance"),
            new SampleCard(1, "Ghor-Clan Rampager"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(2, "Legion Loyalist"),
            new SampleCard(4, "Narnam Renegade"),
            new SampleCard(4, "Pelt Collector"),
            new SampleCard(4, "Reckless Bushwhacker"),
            new SampleCard(4, "Vexing Devil"),
            new SampleCard(4, "Wild Nacatl"),
            new SampleCard(4, "Atarka's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(1, "Forest"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Thalia, Guardian of Thraben"),
            new SampleCard(3, "Weather the Storm") 
        };
    }
}