using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20
{
    public class Deck11_Logic_DeathsShadow_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Liliana of the Veil"),
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(3, "Dreadhorde Arcanist"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Unearth"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(4, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Castle Locthwain"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Sulfurous Springs"),
            new SampleCard(2, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Fulminator Mage"),
            new SampleCard(2, "Liliana, the Last Hope"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Temur Battle Rage") 
        };
    }
}