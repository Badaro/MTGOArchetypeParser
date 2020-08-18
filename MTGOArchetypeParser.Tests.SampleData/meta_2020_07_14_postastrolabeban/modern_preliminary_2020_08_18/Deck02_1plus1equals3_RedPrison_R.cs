using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18
{
    public class Deck02_1plus1equals3_RedPrison_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Chandra, Awakened Inferno"),
            new SampleCard(3, "Chandra, Torch of Defiance"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(3, "Goblin Rabblemaster"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(2, "Seasoned Pyromancer"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(2, "Pillage"),
            new SampleCard(2, "Abrade"),
            new SampleCard(4, "Desperate Ritual"),
            new SampleCard(1, "Pyretic Ritual"),
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(3, "Ensnaring Bridge"),
            new SampleCard(2, "Mazemind Tome"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(3, "Gemstone Caverns"),
            new SampleCard(18, "Snow-Covered Mountain") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(1, "Chandra, Awakened Inferno"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Witchbane Orb") 
        };
    }
}