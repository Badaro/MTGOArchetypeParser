using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck35_whitefangshinobi_Mill_UB_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Hedron Crab"),(1, "Jace, Vryn's Prodigy"),(4, "Jace's Phantasm"),(2, "Snapcaster Mage"),(4, "Glimpse the Unthinkable"),(3, "Inquisition of Kozilek"),(4, "Archive Trap"),(2, "Drown in the Loch"),(3, "Fatal Push"),(3, "Surgical Extraction"),(4, "Visions of Beyond"),(4, "Mesmeric Orb"),(1, "Darkslick Shores"),(3, "Field of Ruin"),(4, "Flooded Strand"),(1, "Oboro, Palace in the Clouds"),(4, "Polluted Delta"),(1, "Shelldock Isle"),(4, "Snow-Covered Island"),(2, "Snow-Covered Swamp"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Drown in the Loch"),(2, "Collective Brutality"),(3, "Crypt Incursion"),(2, "Damnation"),(2, "Echoing Truth"),(1, "Lurrus of the Dream Den"),(1, "Set Adrift"),(1, "Torpor Orb"),(1, "Unmoored Ego") }; } }
    }
}