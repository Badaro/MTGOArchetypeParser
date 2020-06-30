using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck08_SvenSveeterSven_BlueMoon_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "The Royal Scions"),(2, "Bonecrusher Giant"),(2, "Brazen Borrower"),(3, "Snapcaster Mage"),(3, "Thing in the Ice"),(4, "Serum Visions"),(3, "Archmage's Charm"),(3, "Force of Negation"),(1, "Glimpse of Freedom"),(4, "Lightning Bolt"),(3, "Opt"),(1, "Peek"),(4, "Remand"),(2, "Spell Snare"),(1, "Cascade Bluffs"),(8, "Island"),(4, "Misty Rainforest"),(1, "Mountain"),(2, "Mystic Sanctuary"),(4, "Scalding Tarn"),(2, "Steam Vents"),(1, "Sulfur Falls") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Bonecrusher Giant"),(1, "Brazen Borrower"),(2, "Aether Gust"),(2, "Blood Moon"),(2, "Ceremonious Rejection"),(1, "Flame Slash"),(1, "Flusterstorm"),(2, "Mindbreak Trap"),(1, "Seasoned Pyromancer"),(2, "Surgical Extraction") }; } }
    }
}