using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck21_Oldbagobones_Smallpox_WB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Elspeth, Sun's Nemesis"),(1, "Kaya, Orzhov Usurper"),(4, "Liliana of the Veil"),(4, "Stoneforge Mystic"),(4, "Inquisition of Kozilek"),(4, "Lingering Souls"),(4, "Smallpox"),(3, "Thoughtseize"),(4, "Fatal Push"),(3, "Kaya's Guile"),(1, "Mana Tithe"),(1, "Batterskull"),(1, "Sword of Fire and Ice"),(2, "Fetid Heath"),(4, "Flagstones of Trokair"),(3, "Godless Shrine"),(4, "Marsh Flats"),(1, "Plains"),(1, "Shambling Vent"),(3, "Silent Clearing"),(3, "Swamp"),(3, "Urborg, Tomb of Yawgmoth") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Kaya's Guile"),(1, "Thoughtseize"),(4, "Fulminator Mage"),(1, "Path to Exile"),(3, "Plague Engineer"),(3, "Rest in Peace"),(2, "Vampire Hexmage") }; } }
    }
}