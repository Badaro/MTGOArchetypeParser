using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07
{
    public class Deck27_JFKDefiedBolas_MartyrProc_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Martyr of Sands"),
            new SampleCard(2, "Ranger of Eos"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(3, "Serra Ascendant"),
            new SampleCard(2, "Speaker of the Heavens"),
            new SampleCard(4, "Squadron Hawk"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Thraben Inspector"),
            new SampleCard(1, "Day of Judgment"),
            new SampleCard(1, "Proclamation of Rebirth"),
            new SampleCard(2, "Winds of Abandon"),
            new SampleCard(1, "Wrath of God"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Crucible of Worlds"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(2, "Emeria, the Sky Ruin"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Flagstones of Trokair"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(2, "Mistveil Plains"),
            new SampleCard(8, "Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Damping Sphere"),
            new SampleCard(2, "Deafening Silence"),
            new SampleCard(3, "Disenchant"),
            new SampleCard(4, "Kor Firewalker"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}