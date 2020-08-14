using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck07_bobthedog_SoulSisters_HeliodSisters_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Ajani's Pridemate"),
            new SampleCard(4, "Auriok Champion"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(4, "Martyr of Sands"),
            new SampleCard(1, "Ranger-Captain of Eos"),
            new SampleCard(4, "Serra Ascendant"),
            new SampleCard(2, "Soul Warden"),
            new SampleCard(2, "Soul's Attendant"),
            new SampleCard(4, "Speaker of the Heavens"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Cavern of Souls"),
            new SampleCard(17, "Snow-Covered Plains"),
            new SampleCard(3, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Dawn of Hope"),
            new SampleCard(1, "Deafening Silence"),
            new SampleCard(1, "Elspeth, Knight-Errant"),
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "On Thin Ice"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(1, "Worship") 
        };
    }
}