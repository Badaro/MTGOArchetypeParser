using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck56_Iceman76_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(1, "Goblin Chieftain"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(3, "Goblin Ringleader"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(3, "Mogg War Marshal"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(1, "Pashalik Mons"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(2, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Goblin Chainwhirler"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(4, "Relic of Progenitus") 
        };
    }
}