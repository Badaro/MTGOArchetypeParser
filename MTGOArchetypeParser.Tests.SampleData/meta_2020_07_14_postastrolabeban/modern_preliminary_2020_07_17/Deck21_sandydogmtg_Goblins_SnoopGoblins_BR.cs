using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_17
{
    public class Deck21_sandydogmtg_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(1, "Goblin Chieftain"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(4, "Goblin Ringleader"),
            new SampleCard(1, "Goblin Warchief"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(3, "Mogg War Marshal"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(2, "Skirk Prospector"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Sunbaked Canyon"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(2, "Goblin Chainwhirler"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(4, "Leyline of the Void"),
            new SampleCard(4, "Thoughtseize") 
        };
    }
}