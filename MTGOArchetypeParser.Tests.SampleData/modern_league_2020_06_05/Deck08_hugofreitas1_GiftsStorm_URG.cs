using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck08_hugofreitas1_GiftsStorm_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Baral, Chief of Compliance"),(3, "Goblin Electromancer"),(2, "Grapeshot"),(2, "Past in Flames"),(1, "Pieces of the Puzzle"),(4, "Serum Visions"),(4, "Sleight of Hand"),(4, "Desperate Ritual"),(4, "Gifts Ungiven"),(4, "Manamorphose"),(2, "Opt"),(4, "Pyretic Ritual"),(3, "Remand"),(1, "Repeal"),(2, "Breeding Pool"),(2, "Flooded Strand"),(1, "Island"),(1, "Mountain"),(4, "Scalding Tarn"),(1, "Snow-Covered Island"),(4, "Spirebluff Canal"),(3, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Pieces of the Puzzle"),(2, "Aria of Flame"),(2, "Empty the Warrens"),(4, "Lightning Bolt"),(2, "Shattering Spree"),(3, "Veil of Summer") }; } }
    }
}