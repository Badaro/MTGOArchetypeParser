using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_14
{
    public class Deck06_Boin_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(1, "Goblin Chieftain"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(2, "Goblin Ringleader"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(4, "Mogg War Marshal"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(1, "Pashalik Mons"),
            new SampleCard(2, "Skirk Prospector"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(3, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(1, "Goblin Chainwhirler"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(2, "Tarfire") 
        };
    }
}