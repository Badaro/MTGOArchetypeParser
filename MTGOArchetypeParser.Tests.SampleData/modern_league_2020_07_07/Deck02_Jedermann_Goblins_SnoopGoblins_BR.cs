using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_07
{
    public class Deck02_Jedermann_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(1, "Goblin Chieftain"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(1, "Goblin Piledriver"),
            new SampleCard(3, "Goblin Ringleader"),
            new SampleCard(4, "Goblin Warchief"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(2, "Mogg War Marshal"),
            new SampleCard(3, "Munitions Expert"),
            new SampleCard(4, "Skirk Prospector"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(5, "Mountain"),
            new SampleCard(4, "Unclaimed Territory") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Goblin Ringleader"),
            new SampleCard(1, "Munitions Expert"),
            new SampleCard(1, "Boil"),
            new SampleCard(1, "Goblin Chainwhirler"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(1, "Tarfire"),
            new SampleCard(4, "Thoughtseize") 
        };
    }
}