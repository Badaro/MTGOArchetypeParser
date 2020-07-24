using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24
{
    public class Deck36_junghans_Devoted_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Birds of Paradise"),
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(1, "Caustic Caterpillar"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(1, "Duskwatch Recruiter"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(3, "Noble Hierarch"),
            new SampleCard(2, "Ranger-Captain of Eos"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(1, "Shalai, Voice of Plenty"),
            new SampleCard(3, "Vizier of Remedies"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(3, "Eldritch Evolution"),
            new SampleCard(4, "Finale of Devastation"),
            new SampleCard(3, "Postmortem Lunge"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(2, "Forest"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(2, "Plains"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills"),
            new SampleCard(1, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(1, "Aven Mindcensor"),
            new SampleCard(1, "Hushbringer"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Linvala, Keeper of Silence"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Questing Beast"),
            new SampleCard(1, "Sword of Light and Shadow"),
            new SampleCard(1, "Thrun, the Last Troll"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}