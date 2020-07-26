using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_11
{
    public class Deck08_Charlesjacenorman_Burn_WR_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Eidolon of the Great Revel"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(1, "Grim Lavamancer"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(3, "Rift Bolt"),
            new SampleCard(3, "Skewer the Critics"),
            new SampleCard(4, "Boros Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Lightning Helix"),
            new SampleCard(3, "Searing Blaze"),
            new SampleCard(2, "Skullcrack"),
            new SampleCard(1, "Bloodstained Mire"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(3, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Deafening Silence"),
            new SampleCard(4, "Dragon's Claw"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(1, "Soul-Guide Lantern"),
            new SampleCard(2, "Wear // Tear") 
        };
    }
}