using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck14_WotCAndrewB_ThaliaStoneblade_W : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Blade Splicer"),(4, "Flickerwisp"),(4, "Giver of Runes"),(4, "Restoration Angel"),(4, "Stoneforge Mystic"),(4, "Thalia, Guardian of Thraben"),(4, "Thraben Inspector"),(4, "Aether Vial"),(1, "Batterskull"),(4, "Smuggler's Copter"),(1, "Sword of Feast and Famine"),(1, "Sword of Fire and Ice"),(2, "Cavern of Souls"),(4, "Field of Ruin"),(4, "Ghost Quarter"),(11, "Snow-Covered Plains") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Damping Sphere"),(3, "Kor Firewalker"),(2, "Mirran Crusader"),(4, "Path to Exile"),(3, "Rest in Peace") }; } }
    }
}