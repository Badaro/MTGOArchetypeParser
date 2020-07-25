using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25
{
    public class Deck06_TheLousyZoot_Goblins_SnoopGoblins_WBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(3, "Frogtosser Banneret"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(4, "Goblin Ringleader"),
            new SampleCard(1, "Goblin Smuggler"),
            new SampleCard(1, "Goblin Warchief"),
            new SampleCard(1, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(1, "Morophon, the Boundless"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(1, "Pashalik Mons"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(1, "Stingscourger"),
            new SampleCard(4, "Warren Instigator"),
            new SampleCard(3, "Arid Mesa"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(3, "Sunbaked Canyon"),
            new SampleCard(1, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(2, "Deafening Silence"),
            new SampleCard(1, "Earwig Squad"),
            new SampleCard(1, "Goblin Chainwhirler"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(4, "Thoughtseize") 
        };
    }
}