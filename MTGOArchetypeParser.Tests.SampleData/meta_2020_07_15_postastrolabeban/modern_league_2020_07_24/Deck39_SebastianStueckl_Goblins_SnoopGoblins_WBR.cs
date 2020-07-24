using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24
{
    public class Deck39_SebastianStueckl_Goblins_SnoopGoblins_WBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(2, "Restoration Angel"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(2, "Marsh Flats"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Restoration Angel"),
            new SampleCard(1, "Tarfire"),
            new SampleCard(2, "Boil"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(3, "Plague Engineer"),
            new SampleCard(3, "Rest in Peace") 
        };
    }
}