using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07
{
    public class Deck51_MrJayngles_RedPrison_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(4, "Goblin Rabblemaster"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(3, "Seasoned Pyromancer"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(2, "Abrade"),
            new SampleCard(4, "Desperate Ritual"),
            new SampleCard(1, "Pyretic Ritual"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(3, "Ensnaring Bridge"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(2, "Forest"),
            new SampleCard(3, "Gemstone Caverns"),
            new SampleCard(6, "Mountain"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(2, "Chandra, Awakened Inferno"),
            new SampleCard(3, "Eidolon of the Great Revel"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(1, "Walking Ballista") 
        };
    }
}