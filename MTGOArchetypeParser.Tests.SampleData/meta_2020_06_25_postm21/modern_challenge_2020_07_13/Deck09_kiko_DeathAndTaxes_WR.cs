using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_07_13
{
    public class Deck09_kiko_DeathAndTaxes_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Dire Fleet Daredevil"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(2, "Giver of Runes"),
            new SampleCard(3, "Goblin Cratermaker"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Sword of Light and Shadow"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(3, "Inspiring Vantage"),
            new SampleCard(7, "Plains"),
            new SampleCard(4, "Sacred Foundry"),
            new SampleCard(3, "Sunbaked Canyon"),
            new SampleCard(3, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Dire Fleet Daredevil"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(2, "Auriok Champion"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(3, "Remorseful Cleric"),
            new SampleCard(1, "Shadowspear"),
            new SampleCard(2, "Spirit of the Labyrinth"),
            new SampleCard(2, "Tormod's Crypt") 
        };
    }
}