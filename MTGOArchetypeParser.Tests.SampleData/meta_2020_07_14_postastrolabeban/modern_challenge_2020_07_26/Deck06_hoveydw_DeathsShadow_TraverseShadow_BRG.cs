using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_07_26
{
    public class Deck06_hoveydw_DeathsShadow_TraverseShadow_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(1, "Ghor-Clan Rampager"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Traverse the Ulvenwald"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Blood Crypt"),
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
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Wrenn and Six") 
        };
    }
}