using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_08
{
    public class Deck07_AlabasterWolfie_Goblins_SnoopGoblins_BR : ISampleDeck
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
            new SampleCard(3, "Cavern of Souls"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Goblin Ringleader"),
            new SampleCard(2, "Boil"),
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(2, "Warren Weirding") 
        };
    }
}