using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck44_JimmySetzer_Goblins_SnoopGoblins_BR : ISampleDeck
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
            new SampleCard(2, "Munitions Expert"),
            new SampleCard(1, "Pashalik Mons"),
            new SampleCard(3, "Skirk Prospector"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Goblin Ringleader"),
            new SampleCard(2, "Munitions Expert"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}