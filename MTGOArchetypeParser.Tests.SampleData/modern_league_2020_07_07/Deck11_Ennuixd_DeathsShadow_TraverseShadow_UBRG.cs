using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_07
{
    public class Deck11_Ennuixd_DeathsShadow_TraverseShadow_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(1, "Ghor-Clan Rampager"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Traverse the Ulvenwald"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(3, "Stubborn Denial"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(2, "Wooded Foothills"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(2, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(1, "Stubborn Denial"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(2, "Delay"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(1, "The Royal Scions"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}