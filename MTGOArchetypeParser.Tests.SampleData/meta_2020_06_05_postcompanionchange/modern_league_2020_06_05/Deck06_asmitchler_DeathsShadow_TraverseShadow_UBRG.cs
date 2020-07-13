using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05
{
    public class Deck06_asmitchler_DeathsShadow_TraverseShadow_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(1, "Ghor-Clan Rampager"),
            new SampleCard(1, "Lurrus of the Dream Den"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(3, "Traverse the Ulvenwald"),
            new SampleCard(2, "Unearth"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Dismember"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Stubborn Denial"),
            new SampleCard(2, "Thought Scour"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Stubborn Denial"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(1, "Fulminator Mage"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(1, "Veil of Summer") 
        };
    }
}