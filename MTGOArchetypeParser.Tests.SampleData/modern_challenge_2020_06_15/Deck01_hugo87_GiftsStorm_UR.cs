using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck01_hugo87_GiftsStorm_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Baral, Chief of Compliance"),(4, "Goblin Electromancer"),(2, "Grapeshot"),(2, "Past in Flames"),(4, "Serum Visions"),(4, "Sleight of Hand"),(4, "Desperate Ritual"),(4, "Gifts Ungiven"),(4, "Manamorphose"),(2, "Peer Through Depths"),(4, "Pyretic Ritual"),(3, "Remand"),(1, "Repeal"),(1, "Fiery Islet"),(1, "Flooded Strand"),(3, "Island"),(1, "Misty Rainforest"),(1, "Mountain"),(4, "Scalding Tarn"),(4, "Spirebluff Canal"),(3, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(1, "Aria of Flame"),(1, "Dismember"),(3, "Empty the Warrens"),(3, "Lightning Bolt"),(2, "Mystical Dispute"),(2, "Pieces of the Puzzle"),(1, "Shattering Spree") }; } }
    }
}