using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck31_GodsShadow_GrixisControl_UBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Bonecrusher Giant"),(2, "Brazen Borrower"),(2, "Jace, Vryn's Prodigy"),(2, "Kroxa, Titan of Death's Hunger"),(4, "Snapcaster Mage"),(2, "Tasigur, the Golden Fang"),(2, "Cling to Dust"),(4, "Cryptic Command"),(2, "Fatal Push"),(4, "Kolaghan's Command"),(4, "Lightning Bolt"),(2, "Logic Knot"),(2, "Terminate"),(4, "Thought Scour"),(1, "Blood Crypt"),(1, "Cascade Bluffs"),(2, "Creeping Tar Pit"),(3, "Island"),(1, "Mountain"),(4, "Polluted Delta"),(4, "Scalding Tarn"),(2, "Steam Vents"),(2, "Swamp"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Collective Brutality"),(2, "Countersquall"),(2, "Fulminator Mage"),(2, "Kalitas, Traitor of Ghet"),(1, "Massacre Wurm"),(2, "Plague Engineer"),(2, "Spell Snare"),(2, "Thoughtseize") }; } }
    }
}