using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck50_fsst_GiftsStorm_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Baral, Chief of Compliance"),(4, "Goblin Electromancer"),(2, "Grapeshot"),(2, "Past in Flames"),(4, "Serum Visions"),(4, "Desperate Ritual"),(4, "Gifts Ungiven"),(4, "Manamorphose"),(4, "Opt"),(2, "Peer Through Depths"),(4, "Pyretic Ritual"),(3, "Remand"),(1, "Repeal"),(1, "Fiery Islet"),(2, "Island"),(1, "Mountain"),(4, "Shivan Reef"),(2, "Snow-Covered Island"),(4, "Spirebluff Canal"),(4, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Abrade"),(2, "Aria of Flame"),(1, "Dismember"),(3, "Empty the Warrens"),(3, "Lightning Bolt"),(2, "Mystical Dispute"),(2, "Pieces of the Puzzle"),(1, "Shenanigans") }; } }
    }
}