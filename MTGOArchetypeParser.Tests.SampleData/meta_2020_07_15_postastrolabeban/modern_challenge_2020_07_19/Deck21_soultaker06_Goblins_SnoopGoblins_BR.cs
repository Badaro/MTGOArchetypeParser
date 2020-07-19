using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19
{
    public class Deck21_soultaker06_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(1, "Goblin Cratermaker"),
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
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(1, "Munitions Expert"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(2, "Earwig Squad"),
            new SampleCard(1, "Goblin Chainwhirler"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(1, "Tarfire") 
        };
    }
}