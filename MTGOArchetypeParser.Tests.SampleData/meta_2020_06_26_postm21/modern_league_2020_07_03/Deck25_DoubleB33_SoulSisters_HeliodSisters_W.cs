using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_03
{
    public class Deck25_DoubleB33_SoulSisters_HeliodSisters_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(4, "Martyr of Sands"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(2, "Serra Ascendant"),
            new SampleCard(2, "Soul Warden"),
            new SampleCard(2, "Soul's Attendant"),
            new SampleCard(4, "Speaker of the Heavens"),
            new SampleCard(4, "Squadron Hawk"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(3, "Walking Ballista"),
            new SampleCard(2, "Castle Ardenvale"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(16, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Authority of the Consuls"),
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(2, "Containment Priest"),
            new SampleCard(2, "Deafening Silence"),
            new SampleCard(2, "Leonin Relic-Warder"),
            new SampleCard(3, "On Thin Ice"),
            new SampleCard(3, "Rest in Peace") 
        };
    }
}