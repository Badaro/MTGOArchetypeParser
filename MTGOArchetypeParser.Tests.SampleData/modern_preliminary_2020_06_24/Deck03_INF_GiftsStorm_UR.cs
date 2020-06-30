using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_24
{
    public class Deck03_INF_GiftsStorm_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Baral, Chief of Compliance"),(4, "Goblin Electromancer"),(2, "Grapeshot"),(2, "Past in Flames"),(4, "Serum Visions"),(4, "Sleight of Hand"),(4, "Desperate Ritual"),(4, "Gifts Ungiven"),(4, "Manamorphose"),(4, "Opt"),(4, "Pyretic Ritual"),(2, "Remand"),(1, "Repeal"),(1, "Fiery Islet"),(2, "Island"),(1, "Mountain"),(3, "Shivan Reef"),(2, "Snow-Covered Island"),(4, "Spirebluff Canal"),(4, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Abrade"),(3, "Aria of Flame"),(3, "Empty the Warrens"),(2, "Flusterstorm"),(3, "Lightning Bolt"),(2, "Pieces of the Puzzle"),(1, "Shenanigans") }; } }
    }
}