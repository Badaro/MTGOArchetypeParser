using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14
{
    public class Deck02_SvenSveeterSven_BlueMoon_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "The Royal Scions"),(2, "Bonecrusher Giant"),(2, "Brazen Borrower"),(3, "Snapcaster Mage"),(3, "Thing in the Ice"),(4, "Serum Visions"),(4, "Archmage's Charm"),(2, "Force of Negation"),(4, "Lightning Bolt"),(1, "Magmatic Sinkhole"),(4, "Opt"),(4, "Remand"),(2, "Spell Pierce"),(1, "Cascade Bluffs"),(1, "Fiery Islet"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(4, "Scalding Tarn"),(8, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(2, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Bonecrusher Giant"),(1, "Brazen Borrower"),(2, "Aether Gust"),(2, "Blood Moon"),(2, "Ceremonious Rejection"),(2, "Flusterstorm"),(1, "Forked Bolt"),(1, "Improbable Alliance"),(1, "Spell Snare"),(2, "Surgical Extraction") }; } }
    }
}