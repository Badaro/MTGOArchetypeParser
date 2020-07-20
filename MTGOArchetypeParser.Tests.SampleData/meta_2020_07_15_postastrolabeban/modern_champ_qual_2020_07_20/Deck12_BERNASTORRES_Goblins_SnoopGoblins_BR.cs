using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20
{
    public class Deck12_BERNASTORRES_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(3, "Dark Confidant"),
            new SampleCard(1, "Frogtosser Banneret"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(3, "Unearth"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(4, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(2, "Marsh Flats"),
            new SampleCard(2, "Mountain"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(1, "Goblin Rabblemaster"),
            new SampleCard(4, "Nihil Spellbomb") 
        };
    }
}