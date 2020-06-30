using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck12_jimdownside_Aristocrats_WB_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Blood Artist"),(4, "Carrion Feeder"),(4, "Cruel Celebrant"),(4, "Doomed Traveler"),(2, "Hunted Witness"),(4, "Priest of Forgotten Gods"),(4, "Stitcher's Supplier"),(3, "Thalia, Guardian of Thraben"),(4, "Tidehollow Sculler"),(3, "Viscera Seer"),(4, "Return to the Ranks"),(4, "Concealed Courtyard"),(4, "Godless Shrine"),(4, "Marsh Flats"),(2, "Silent Clearing"),(3, "Snow-Covered Plains"),(3, "Snow-Covered Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Burrenton Forge-Tender"),(2, "Collective Brutality"),(2, "Fatal Push"),(4, "Leonin Relic-Warder"),(1, "Lurrus of the Dream Den"),(3, "Thoughtseize") }; } }
    }
}