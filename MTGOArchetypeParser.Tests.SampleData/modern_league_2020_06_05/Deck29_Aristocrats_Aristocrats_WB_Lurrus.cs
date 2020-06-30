using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck29_Aristocrats_Aristocrats_WB_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Blood Artist"),(4, "Carrion Feeder"),(4, "Cruel Celebrant"),(4, "Doomed Traveler"),(1, "Hunted Witness"),(4, "Priest of Forgotten Gods"),(4, "Stitcher's Supplier"),(2, "Thalia, Guardian of Thraben"),(4, "Tidehollow Sculler"),(2, "Tithe Taker"),(3, "Viscera Seer"),(4, "Return to the Ranks"),(1, "Caves of Koilos"),(4, "Concealed Courtyard"),(4, "Godless Shrine"),(4, "Marsh Flats"),(3, "Plains"),(2, "Silent Clearing"),(2, "Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Thalia, Guardian of Thraben"),(3, "Burrenton Forge-Tender"),(1, "Collective Brutality"),(2, "Fatal Push"),(3, "Judge's Familiar"),(4, "Leonin Relic-Warder"),(1, "Lurrus of the Dream Den") }; } }
    }
}