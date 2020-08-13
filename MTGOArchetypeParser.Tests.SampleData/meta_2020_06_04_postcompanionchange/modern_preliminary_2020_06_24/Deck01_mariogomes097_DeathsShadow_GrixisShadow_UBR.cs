using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_24
{
    public class Deck01_mariogomes097_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "The Royal Scions"),
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(4, "Gurmag Angler"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(1, "Sprite Dragon"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(4, "Stubborn Denial"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Marsh Flats"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Sprite Dragon"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(1, "The Royal Scions"),
            new SampleCard(2, "Abrade"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(1, "Duress"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(2, "Nihil Spellbomb") 
        };
    }
}