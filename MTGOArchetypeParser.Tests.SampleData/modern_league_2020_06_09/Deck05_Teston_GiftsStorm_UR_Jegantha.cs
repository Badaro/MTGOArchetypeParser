using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck05_Teston_GiftsStorm_UR_Jegantha : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Baral, Chief of Compliance"),(4, "Goblin Electromancer"),(2, "Grapeshot"),(2, "Past in Flames"),(4, "Serum Visions"),(1, "Sleight of Hand"),(4, "Desperate Ritual"),(4, "Gifts Ungiven"),(4, "Manamorphose"),(4, "Opt"),(1, "Peer Through Depths"),(4, "Pyretic Ritual"),(3, "Remand"),(1, "Repeal"),(1, "Fiery Islet"),(1, "Island"),(1, "Misty Rainforest"),(1, "Polluted Delta"),(4, "Scalding Tarn"),(2, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(4, "Spirebluff Canal"),(3, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(2, "Aria of Flame"),(3, "Blood Moon"),(1, "Echoing Truth"),(2, "Empty the Warrens"),(1, "Jegantha, the Wellspring"),(1, "Mystical Dispute"),(2, "Pieces of the Puzzle"),(1, "Shattering Spree") }; } }
    }
}