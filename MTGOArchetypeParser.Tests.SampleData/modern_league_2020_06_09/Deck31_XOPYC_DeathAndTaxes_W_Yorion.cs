using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck31_XOPYC_DeathAndTaxes_W_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Blade Splicer"),(2, "Charming Prince"),(4, "Flickerwisp"),(4, "Giver of Runes"),(4, "Leonin Arbiter"),(4, "Restoration Angel"),(4, "Stoneforge Mystic"),(4, "Thalia, Guardian of Thraben"),(4, "Thraben Inspector"),(4, "Path to Exile"),(4, "Aether Vial"),(4, "Arcum's Astrolabe"),(1, "Batterskull"),(2, "Smuggler's Copter"),(1, "Sword of Fire and Ice"),(1, "Sword of Light and Shadow"),(2, "Field of Ruin"),(4, "Ghost Quarter"),(3, "Silent Clearing"),(16, "Snow-Covered Plains"),(4, "Tectonic Edge") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Burrenton Forge-Tender"),(2, "Celestial Purge"),(2, "Kitchen Finks"),(2, "Phyrexian Revoker"),(1, "Remorseful Cleric"),(2, "Rest in Peace"),(3, "Winds of Abandon"),(1, "Yorion, Sky Nomad") }; } }
    }
}