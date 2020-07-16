using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_16
{
    public class Deck05_rastaf_Burn_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Chandra's Incinerator"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Vexing Devil"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Rift Bolt"),
            new SampleCard(4, "Skewer the Critics"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Shard Volley"),
            new SampleCard(2, "Skullcrack"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(4, "Fiery Islet"),
            new SampleCard(14, "Mountain"),
            new SampleCard(1, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Skullcrack"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(2, "Pillage"),
            new SampleCard(4, "Smash to Smithereens"),
            new SampleCard(3, "Soul-Guide Lantern") 
        };
    }
}