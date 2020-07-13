using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_12
{
    public class Deck12_jimdownside_Aristocrats_WB_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blood Artist"),
            new SampleCard(4, "Carrion Feeder"),
            new SampleCard(4, "Cruel Celebrant"),
            new SampleCard(4, "Doomed Traveler"),
            new SampleCard(2, "Hunted Witness"),
            new SampleCard(4, "Priest of Forgotten Gods"),
            new SampleCard(4, "Stitcher's Supplier"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Tidehollow Sculler"),
            new SampleCard(3, "Viscera Seer"),
            new SampleCard(4, "Return to the Ranks"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(4, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(3, "Snow-Covered Plains"),
            new SampleCard(3, "Snow-Covered Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Burrenton Forge-Tender"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(4, "Leonin Relic-Warder"),
            new SampleCard(1, "Lurrus of the Dream Den"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}