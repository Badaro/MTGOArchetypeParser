using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_06_26
{
    public class Deck31_SebastianStueckl_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(3, "Conspicuous Snoop"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(1, "Goblin Piledriver"),
            new SampleCard(2, "Goblin Ringleader"),
            new SampleCard(1, "Goblin Warchief"),
            new SampleCard(1, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(1, "Krenko, Mob Boss"),
            new SampleCard(4, "Mogg War Marshal"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(2, "Pashalik Mons"),
            new SampleCard(3, "Skirk Prospector"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(2, "Unearth"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Unclaimed Territory") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Blood Moon"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Earwig Squad"),
            new SampleCard(1, "Goblin Chainwhirler"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(3, "Plague Engineer") 
        };
    }
}