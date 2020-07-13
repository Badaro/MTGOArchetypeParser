using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_03
{
    public class Deck05_robedarcourt_DeathAndTaxes_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Charming Prince"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Tidehollow Sculler"),
            new SampleCard(4, "Wasteland Strangler"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(1, "Fetid Heath"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(2, "Godless Shrine"),
            new SampleCard(4, "Plains"),
            new SampleCard(2, "Shambling Vent"),
            new SampleCard(4, "Silent Clearing"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Burrenton Forge-Tender"),
            new SampleCard(2, "Containment Priest"),
            new SampleCard(1, "Gonti, Lord of Luxury"),
            new SampleCard(2, "Kunoros, Hound of Athreos"),
            new SampleCard(2, "Leonin Relic-Warder"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(1, "Spellskite") 
        };
    }
}