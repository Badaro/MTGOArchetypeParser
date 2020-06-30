using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck17_FranPi_GiftsStorm_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Baral, Chief of Compliance"),(3, "Goblin Electromancer"),(2, "Grapeshot"),(2, "Past in Flames"),(1, "Pieces of the Puzzle"),(4, "Serum Visions"),(2, "Sleight of Hand"),(4, "Desperate Ritual"),(4, "Gifts Ungiven"),(4, "Manamorphose"),(4, "Opt"),(4, "Pyretic Ritual"),(3, "Remand"),(1, "Repeal"),(1, "Fiery Islet"),(2, "Island"),(4, "Shivan Reef"),(2, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(4, "Spirebluff Canal"),(4, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Pieces of the Puzzle"),(1, "Abrade"),(2, "Aria of Flame"),(1, "Dismember"),(2, "Empty the Warrens"),(3, "Lightning Bolt"),(3, "Mystical Dispute"),(1, "Shenanigans") }; } }
    }
}