using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck38_brancusi_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "The Royal Scions"),
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(4, "Gurmag Angler"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(4, "Stubborn Denial"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(1, "Island"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Liliana of the Veil"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Terminate") 
        };
    }
}