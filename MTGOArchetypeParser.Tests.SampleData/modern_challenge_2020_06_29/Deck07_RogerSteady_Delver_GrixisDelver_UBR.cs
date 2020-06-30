using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck07_RogerSteady_Delver_GrixisDelver_UBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Brazen Borrower"),(4, "Delver of Secrets"),(3, "Snapcaster Mage"),(4, "Thieves' Guild Enforcer"),(3, "Vantress Gargoyle"),(3, "Inquisition of Kozilek"),(4, "Serum Visions"),(1, "Thoughtseize"),(4, "Drown in the Loch"),(1, "Force of Negation"),(1, "Into the Story"),(2, "Kolaghan's Command"),(4, "Lightning Bolt"),(2, "Mana Leak"),(1, "Spell Pierce"),(1, "Spell Snare"),(4, "Thought Scour"),(1, "Blood Crypt"),(1, "Island"),(1, "Mystic Sanctuary"),(4, "Polluted Delta"),(4, "Scalding Tarn"),(2, "Steam Vents"),(1, "Swamp"),(3, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Spell Snare"),(2, "Bitterblossom"),(2, "Ceremonious Rejection"),(3, "Collective Brutality"),(2, "Fatal Push"),(2, "Mystical Dispute"),(3, "Surgical Extraction") }; } }
    }
}