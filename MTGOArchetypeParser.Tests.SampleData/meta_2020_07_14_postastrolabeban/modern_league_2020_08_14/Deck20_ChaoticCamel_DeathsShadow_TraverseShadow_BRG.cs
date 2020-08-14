using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck20_ChaoticCamel_DeathsShadow_TraverseShadow_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(1, "Grim Flayer"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(3, "Traverse the Ulvenwald"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Seal of Fire"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(3, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(1, "Wooded Foothills"),
            new SampleCard(1, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Fulminator Mage"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}