using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_07_05
{
    public class Deck10_Zxrogue_DeathsShadow_TraverseShadow_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(3, "Traverse the Ulvenwald"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Stubborn Denial"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Watery Grave"),
            new SampleCard(1, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}