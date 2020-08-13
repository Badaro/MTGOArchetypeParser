using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_17
{
    public class Deck09_mac121711_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(4, "Goblin Cratermaker"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(3, "Goblin Ringleader"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(3, "Auntie's Hovel"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(5, "Mountain"),
            new SampleCard(2, "Mutavault"),
            new SampleCard(2, "Sunbaked Canyon"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Boil"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(3, "Plague Engineer"),
            new SampleCard(2, "Warren Weirding") 
        };
    }
}