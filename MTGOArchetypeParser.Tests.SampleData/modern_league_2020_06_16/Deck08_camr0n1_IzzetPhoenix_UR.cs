using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck08_camr0n1_IzzetPhoenix_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Arclight Phoenix"),(1, "Bedlam Reveler"),(4, "Merchant of the Vale"),(4, "Thing in the Ice"),(2, "Chart a Course"),(2, "Finale of Promise"),(4, "Serum Visions"),(1, "Sleight of Hand"),(2, "Izzet Charm"),(2, "Lightning Axe"),(4, "Lightning Bolt"),(4, "Manamorphose"),(4, "Opt"),(4, "Thought Scour"),(1, "Fiery Islet"),(3, "Island"),(2, "Misty Rainforest"),(2, "Mountain"),(4, "Scalding Tarn"),(4, "Spirebluff Canal"),(2, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(2, "Aether Gust"),(2, "Aria of Flame"),(2, "Blood Moon"),(2, "Force of Negation"),(1, "Jace, the Mind Sculptor"),(3, "Mystical Dispute"),(1, "Surgical Extraction") }; } }
    }
}