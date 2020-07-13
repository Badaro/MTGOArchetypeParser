using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23
{
    public class Deck09_Somniloquist_DeathsShadow_SuicideShadow_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Traverse the Ulvenwald"),
            new SampleCard(2, "Become Immense"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Mutagenic Growth"),
            new SampleCard(3, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ancient Grudge"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(1, "Duress"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(1, "Liliana of the Veil"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}