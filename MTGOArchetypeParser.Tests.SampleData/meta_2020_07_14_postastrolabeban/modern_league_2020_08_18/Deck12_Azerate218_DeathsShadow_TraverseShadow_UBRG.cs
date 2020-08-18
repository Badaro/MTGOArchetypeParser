using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck12_Azerate218_DeathsShadow_TraverseShadow_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(3, "Traverse the Ulvenwald"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Stubborn Denial"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}