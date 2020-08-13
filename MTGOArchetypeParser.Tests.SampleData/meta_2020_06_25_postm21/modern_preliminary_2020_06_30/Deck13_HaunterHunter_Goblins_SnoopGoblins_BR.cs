using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_06_30
{
    public class Deck13_HaunterHunter_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(4, "Goblin Ringleader"),
            new SampleCard(1, "Goblin Warchief"),
            new SampleCard(1, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(1, "Krenko, Mob Boss"),
            new SampleCard(4, "Mogg War Marshal"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(1, "Pashalik Mons"),
            new SampleCard(2, "Skirk Prospector"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Unclaimed Territory"),
            new SampleCard(1, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Goblin Warchief"),
            new SampleCard(1, "Tarfire"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(1, "Goblin Chainwhirler"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(1, "Goblin Piledriver"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}