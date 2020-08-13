using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_23
{
    public class Deck14_mtgmonte_DeathsShadow_TraverseShadow_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(1, "Snapcaster Mage"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(3, "Traverse the Ulvenwald"),
            new SampleCard(1, "Dismember"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Stubborn Denial"),
            new SampleCard(1, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Footfall Crater"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Forest"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(3, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Stubborn Denial"),
            new SampleCard(1, "Temur Battle Rage"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}