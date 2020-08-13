using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_06_29
{
    public class Deck30_sora1248_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(1, "Goblin Chieftain"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(3, "Goblin Matron"),
            new SampleCard(2, "Goblin Piledriver"),
            new SampleCard(3, "Goblin Ringleader"),
            new SampleCard(3, "Goblin Warchief"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(1, "Mogg Fanatic"),
            new SampleCard(3, "Mogg War Marshal"),
            new SampleCard(3, "Munitions Expert"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Prismatic Vista"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(1, "Swamp"),
            new SampleCard(3, "Unclaimed Territory") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Postmortem Lunge"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(2, "Tarfire") 
        };
    }
}