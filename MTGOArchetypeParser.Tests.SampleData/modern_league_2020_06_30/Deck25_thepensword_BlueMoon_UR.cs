using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck25_thepensword_BlueMoon_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "The Royal Scions"),(3, "Rielle, the Everwise"),(4, "Snapcaster Mage"),(4, "Thing in the Ice"),(2, "Cryptic Command"),(2, "Force of Negation"),(4, "Lightning Bolt"),(2, "Magmatic Sinkhole"),(4, "Opt"),(4, "Remand"),(4, "Thought Scour"),(1, "Cascade Bluffs"),(6, "Island"),(1, "Mountain"),(3, "Mystic Sanctuary"),(4, "Polluted Delta"),(4, "Scalding Tarn"),(3, "Steam Vents"),(1, "Sulfur Falls") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Abrade"),(4, "Aether Gust"),(2, "Anger of the Gods"),(3, "Ashiok, Dream Render"),(3, "Blood Moon"),(2, "Narset, Parter of Veils") }; } }
    }
}