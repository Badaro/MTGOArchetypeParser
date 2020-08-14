using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck13_BigDadChad_GreenDevotion_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Garruk Wildspeaker"),
            new SampleCard(2, "Nissa, Who Shakes the World"),
            new SampleCard(1, "Acidic Slime"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(4, "Burning-Tree Emissary"),
            new SampleCard(1, "Carnage Tyrant"),
            new SampleCard(1, "Craterhoof Behemoth"),
            new SampleCard(3, "Eternal Witness"),
            new SampleCard(1, "Hornet Queen"),
            new SampleCard(2, "Hydroid Krasis"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(2, "Voyaging Satyr"),
            new SampleCard(3, "Wistful Selkie"),
            new SampleCard(3, "Primal Command"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(10, "Forest"),
            new SampleCard(4, "Hinterland Harbor"),
            new SampleCard(4, "Nykthos, Shrine to Nyx"),
            new SampleCard(2, "Yavimaya Coast") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Carnage Tyrant"),
            new SampleCard(4, "Chord of Calling"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Courser of Kruphix"),
            new SampleCard(2, "Summoning Trap"),
            new SampleCard(2, "Thragtusk"),
            new SampleCard(2, "Thrashing Brontodon") 
        };
    }
}