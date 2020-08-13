using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_14
{
    public class Deck31_Borjillamtg10_Goblins_SnoopGoblins_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(4, "Goblin Ringleader"),
            new SampleCard(1, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(4, "Mogg War Marshal"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(2, "Skirk Prospector"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(1, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Boil"),
            new SampleCard(1, "Earwig Squad"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(3, "Tarfire") 
        };
    }
}