using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_06
{
    public class Deck13_DoomedNecromancer_AbzanBlade_WBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Scavenging Ooze"),(4, "Siege Rhino"),(4, "Stoneforge Mystic"),(4, "Voice of Resurgence"),(2, "Inquisition of Kozilek"),(4, "Lingering Souls"),(3, "Thoughtseize"),(4, "Assassin's Trophy"),(2, "Fatal Push"),(2, "Kaya's Guile"),(4, "Path to Exile"),(1, "Batterskull"),(1, "Sword of Fire and Ice"),(1, "Sword of Light and Shadow"),(2, "Forest"),(1, "Gavony Township"),(1, "Indatha Triome"),(2, "Nurturing Peatland"),(2, "Overgrown Tomb"),(2, "Plains"),(1, "Stirring Wildwood"),(1, "Swamp"),(2, "Temple Garden"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Choke"),(1, "Damnation"),(1, "Eidolon of Rhetoric"),(2, "Fracturing Gust"),(2, "Gaddock Teeg"),(2, "Kor Firewalker"),(2, "Plague Engineer"),(2, "Rest in Peace"),(1, "Wrath of God") }; } }
    }
}