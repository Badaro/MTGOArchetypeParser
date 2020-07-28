using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_28
{
    public class Deck14_Xwhale_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(2, "Goblin Chieftain"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(2, "Goblin Ringleader"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(2, "Mogg War Marshal"),
            new SampleCard(3, "Munitions Expert"),
            new SampleCard(3, "Sling-Gang Lieutenant"),
            new SampleCard(1, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Goblin Ringleader"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(1, "Unearth"),
            new SampleCard(2, "Warren Weirding") 
        };
    }
}