using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_14
{
    public class Deck34_RealJoy_DeathsShadow_TraverseShadow_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(3, "Traverse the Ulvenwald"),
            new SampleCard(1, "Unearth"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(4, "Stubborn Denial"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Footfall Crater"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(2, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Temur Battle Rage"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(1, "Liliana of the Veil"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}