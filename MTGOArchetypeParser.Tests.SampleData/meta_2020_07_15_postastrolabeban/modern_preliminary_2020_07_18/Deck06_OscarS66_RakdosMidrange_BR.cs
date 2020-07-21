using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_18
{
    public class Deck06_OscarS66_RakdosMidrange_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bonecrusher Giant"),
            new SampleCard(4, "Fulminator Mage"),
            new SampleCard(4, "Insolent Neonate"),
            new SampleCard(4, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Unearth"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(4, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "Mountain"),
            new SampleCard(3, "Swamp"),
            new SampleCard(4, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Dismember"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(2, "Murderous Rider"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(3, "Pyroclasm"),
            new SampleCard(2, "Waste Not") 
        };
    }
}