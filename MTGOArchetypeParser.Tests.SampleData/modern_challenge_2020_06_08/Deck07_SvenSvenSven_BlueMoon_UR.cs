using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck07_SvenSvenSven_BlueMoon_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "The Royal Scions"),(2, "Bonecrusher Giant"),(2, "Brazen Borrower"),(3, "Snapcaster Mage"),(3, "Thing in the Ice"),(4, "Serum Visions"),(4, "Archmage's Charm"),(2, "Force of Negation"),(4, "Lightning Bolt"),(1, "Magmatic Sinkhole"),(4, "Opt"),(4, "Remand"),(2, "Spell Pierce"),(1, "Cascade Bluffs"),(8, "Island"),(1, "Mountain"),(2, "Mystic Sanctuary"),(4, "Polluted Delta"),(4, "Scalding Tarn"),(2, "Steam Vents"),(1, "Sulfur Falls") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Cascade Bluffs"),(1, "Bonecrusher Giant"),(1, "Brazen Borrower"),(1, "Magmatic Sinkhole"),(1, "Aether Gust"),(2, "Blood Moon"),(2, "Ceremonious Rejection"),(1, "Disdainful Stroke"),(1, "Flashfreeze"),(2, "Flusterstorm"),(2, "Relic of Progenitus") }; } }
    }
}