using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07
{
    public class Deck14_MrJayngles_RedPrison_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(4, "Goblin Rabblemaster"),
            new SampleCard(4, "Legion Warboss"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(2, "Slagstorm"),
            new SampleCard(2, "Abrade"),
            new SampleCard(4, "Desperate Ritual"),
            new SampleCard(1, "Pyretic Ritual"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(3, "Ensnaring Bridge"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Gemstone Caverns"),
            new SampleCard(14, "Mountain"),
            new SampleCard(4, "Ramunap Ruins") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Boil"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(3, "Eidolon of the Great Revel"),
            new SampleCard(2, "Kozilek's Return"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(3, "Torpor Orb"),
            new SampleCard(1, "Walking Ballista") 
        };
    }
}