using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07
{
    public class Deck29_umeboshijiisan_Goblins_SnoopGoblins_WBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(2, "Frogtosser Banneret"),
            new SampleCard(2, "Goblin Chieftain"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(3, "Goblin Matron"),
            new SampleCard(3, "Goblin Ringleader"),
            new SampleCard(1, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(1, "Krenko, Mob Boss"),
            new SampleCard(3, "Mogg War Marshal"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(1, "Pashalik Mons"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(3, "Mountain"),
            new SampleCard(3, "Mutavault"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(1, "Savai Triome"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(2, "Sunbaked Canyon"),
            new SampleCard(1, "Swamp"),
            new SampleCard(3, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(2, "Boil"),
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(3, "Worship") 
        };
    }
}