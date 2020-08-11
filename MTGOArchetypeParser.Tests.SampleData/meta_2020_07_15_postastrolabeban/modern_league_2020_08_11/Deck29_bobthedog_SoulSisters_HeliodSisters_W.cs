using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck29_bobthedog_SoulSisters_HeliodSisters_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Ajani's Pridemate"),
            new SampleCard(4, "Auriok Champion"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(4, "Martyr of Sands"),
            new SampleCard(2, "Ranger-Captain of Eos"),
            new SampleCard(4, "Serra Ascendant"),
            new SampleCard(2, "Soul Warden"),
            new SampleCard(2, "Soul's Attendant"),
            new SampleCard(4, "Speaker of the Heavens"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Castle Ardenvale"),
            new SampleCard(18, "Snow-Covered Plains"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Deafening Silence"),
            new SampleCard(3, "Honor of the Pure"),
            new SampleCard(2, "Pithing Needle"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Sorcerous Spyglass"),
            new SampleCard(2, "Worship") 
        };
    }
}