using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck24_DoorDie_GTron_KGCTron_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(4, "Ugin, the Ineffable"),
            new SampleCard(2, "Ugin, the Spirit Dragon"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(2, "Wurmcoil Engine"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Sylvan Scrying"),
            new SampleCard(2, "Warping Wail"),
            new SampleCard(3, "Ensnaring Bridge"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(2, "Mazemind Tome"),
            new SampleCard(1, "Possessed Portal"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Blast Zone"),
            new SampleCard(1, "Drownyard Temple"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(8, "Forest"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Possessed Portal"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(1, "Crucible of Worlds"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Trinisphere"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(3, "Wilt"),
            new SampleCard(1, "Witchbane Orb") 
        };
    }
}