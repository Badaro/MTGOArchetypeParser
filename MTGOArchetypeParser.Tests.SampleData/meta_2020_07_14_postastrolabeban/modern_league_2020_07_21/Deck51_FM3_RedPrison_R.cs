using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck51_FM3_RedPrison_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(3, "Abrade"),
            new SampleCard(4, "Desperate Ritual"),
            new SampleCard(1, "Pyretic Ritual"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(3, "Ensnaring Bridge"),
            new SampleCard(4, "Mind Stone"),
            new SampleCard(4, "Blood Moon"),
            new SampleCard(2, "Blast Zone"),
            new SampleCard(3, "Gemstone Caverns"),
            new SampleCard(12, "Mountain"),
            new SampleCard(4, "Zhalfirin Void") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Chandra, Awakened Inferno"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Darksteel Citadel"),
            new SampleCard(1, "God-Pharaoh's Statue"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(3, "Pillage"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Torpor Orb"),
            new SampleCard(1, "Walking Ballista") 
        };
    }
}