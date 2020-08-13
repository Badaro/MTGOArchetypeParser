using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_07_19
{
    public class Deck20_Jokersrwild_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(1, "Goblin Chieftain"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(2, "Goblin Ringleader"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(4, "Mogg War Marshal"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(2, "Mountain"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Goblin Ringleader"),
            new SampleCard(2, "Boil"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(3, "Relic of Progenitus") 
        };
    }
}