using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck04_MrJayngles_RedPrison_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Awakened Inferno"),
            new SampleCard(4, "Chandra, Torch of Defiance"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(3, "Seasoned Pyromancer"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(3, "Abrade"),
            new SampleCard(4, "Desperate Ritual"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(3, "Ensnaring Bridge"),
            new SampleCard(3, "Mazemind Tome"),
            new SampleCard(4, "Blood Moon"),
            new SampleCard(3, "Gemstone Caverns"),
            new SampleCard(15, "Mountain"),
            new SampleCard(4, "Zhalfirin Void") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(2, "Torpor Orb"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}