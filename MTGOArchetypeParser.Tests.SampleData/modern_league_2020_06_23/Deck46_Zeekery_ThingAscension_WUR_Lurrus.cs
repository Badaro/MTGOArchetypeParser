using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck46_Zeekery_ThingAscension_WUR_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Thing in the Ice"),(4, "Serum Visions"),(4, "Sleight of Hand"),(2, "Force of Negation"),(4, "Lightning Bolt"),(4, "Lightning Helix"),(4, "Manamorphose"),(4, "Opt"),(2, "Path to Exile"),(2, "Remand"),(4, "Thought Scour"),(4, "Pyromancer Ascension"),(1, "Fiery Islet"),(3, "Flooded Strand"),(1, "Hallowed Fountain"),(1, "Raugrin Triome"),(1, "Sacred Foundry"),(4, "Scalding Tarn"),(2, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(2, "Spirebluff Canal"),(2, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(2, "Anger of the Gods"),(1, "Blessed Alliance"),(1, "Dovin's Veto"),(1, "Lurrus of the Dream Den"),(2, "Mystical Dispute"),(2, "Surgical Extraction"),(2, "Wear // Tear"),(2, "Young Pyromancer") }; } }
    }
}