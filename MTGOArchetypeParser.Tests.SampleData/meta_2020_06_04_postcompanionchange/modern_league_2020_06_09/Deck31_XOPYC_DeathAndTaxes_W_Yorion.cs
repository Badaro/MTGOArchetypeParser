using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_09
{
    public class Deck31_XOPYC_DeathAndTaxes_W_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blade Splicer"),
            new SampleCard(2, "Charming Prince"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Restoration Angel"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thraben Inspector"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(2, "Smuggler's Copter"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Sword of Light and Shadow"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(3, "Silent Clearing"),
            new SampleCard(16, "Snow-Covered Plains"),
            new SampleCard(4, "Tectonic Edge") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Kitchen Finks"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(1, "Remorseful Cleric"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(3, "Winds of Abandon"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}