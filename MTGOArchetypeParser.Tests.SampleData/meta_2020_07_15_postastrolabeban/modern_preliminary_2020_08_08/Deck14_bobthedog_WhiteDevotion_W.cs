using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_08_08
{
    public class Deck14_bobthedog_WhiteDevotion_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Auriok Champion"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(4, "Knight of the White Orchid"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(4, "Weathered Wayfarer"),
            new SampleCard(2, "Fieldmist Borderpost"),
            new SampleCard(2, "Wildfield Borderpost"),
            new SampleCard(2, "Dawn of Hope"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(3, "Mastery of the Unseen"),
            new SampleCard(4, "On Thin Ice"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(3, "Nykthos, Shrine to Nyx"),
            new SampleCard(12, "Snow-Covered Plains"),
            new SampleCard(1, "Tectonic Edge") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(1, "Tectonic Edge"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Deafening Silence"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Pithing Needle"),
            new SampleCard(2, "Runed Halo"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(2, "Winds of Abandon") 
        };
    }
}