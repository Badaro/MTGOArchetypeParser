using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_21
{
    public class Deck46_EdB_Skelementals_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Flamekin Harbinger"),
            new SampleCard(3, "Insolent Neonate"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(2, "Rix Maadi Reveler"),
            new SampleCard(1, "Spitebellows"),
            new SampleCard(4, "Thunderkin Awakener"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(4, "Unearth"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Seal of Fire"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(4, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Marsh Flats"),
            new SampleCard(2, "Mountain"),
            new SampleCard(3, "Sunbaked Canyon"),
            new SampleCard(2, "Swamp"),
            new SampleCard(3, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Spitebellows"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(1, "Fulminator Mage"),
            new SampleCard(3, "Goblin Cratermaker"),
            new SampleCard(1, "Leyline of the Void"),
            new SampleCard(4, "Nihil Spellbomb") 
        };
    }
}