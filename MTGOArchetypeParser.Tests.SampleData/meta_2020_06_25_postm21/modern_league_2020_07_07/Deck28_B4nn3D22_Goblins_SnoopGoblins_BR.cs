using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07
{
    public class Deck28_B4nn3D22_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(4, "Dark Confidant"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(1, "Goblin Rabblemaster"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Unearth"),
            new SampleCard(1, "Warren Weirding"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(4, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Tarfire"),
            new SampleCard(1, "Warren Weirding"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Nihil Spellbomb") 
        };
    }
}