using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_06_26
{
    public class Deck27_SightWinner_HollowOne_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bloodghast"),
            new SampleCard(4, "Flameblade Adept"),
            new SampleCard(4, "Flamewake Phoenix"),
            new SampleCard(4, "Gurmag Angler"),
            new SampleCard(4, "Hollow One"),
            new SampleCard(2, "Insolent Neonate"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(2, "Tasigur, the Golden Fang"),
            new SampleCard(4, "Burning Inquiry"),
            new SampleCard(1, "Go for Blood"),
            new SampleCard(4, "Goblin Lore"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Arid Mesa"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(3, "Mountain"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(3, "Boil"),
            new SampleCard(4, "Boom // Bust"),
            new SampleCard(4, "Collective Brutality"),
            new SampleCard(2, "Slaughter Games") 
        };
    }
}