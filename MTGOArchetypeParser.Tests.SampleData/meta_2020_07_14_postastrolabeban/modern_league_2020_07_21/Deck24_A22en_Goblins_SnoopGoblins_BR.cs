using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck24_A22en_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(1, "Goblin Chainwhirler"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(2, "Goblin Ringleader"),
            new SampleCard(1, "Goblin Warchief"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(2, "Mogg War Marshal"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(1, "Pashalik Mons"),
            new SampleCard(1, "Skirk Prospector"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(1, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Goblin Ringleader"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(1, "Siege-Gang Commander"),
            new SampleCard(1, "Warren Weirding") 
        };
    }
}