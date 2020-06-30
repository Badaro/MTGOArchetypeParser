using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck31_anamika_GruulCompany_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Ahn-Crop Crasher"),
            new SampleCard(3, "Birds of Paradise"),
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(1, "Gallia of the Endless Dance"),
            new SampleCard(3, "Goblin Chieftain"),
            new SampleCard(4, "Goblin Rabblemaster"),
            new SampleCard(3, "Hexdrinker"),
            new SampleCard(4, "Legion Warboss"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(3, "Scavenging Ooze"),
            new SampleCard(1, "Seasoned Pyromancer"),
            new SampleCard(1, "Abrade"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(1, "Bloodstained Mire"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Forest"),
            new SampleCard(2, "Kessig Wolf Run"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Izzet Staticaster"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}