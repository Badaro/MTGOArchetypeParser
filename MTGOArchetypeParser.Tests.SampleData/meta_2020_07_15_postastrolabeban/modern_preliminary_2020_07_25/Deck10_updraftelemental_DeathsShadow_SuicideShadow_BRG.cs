using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25
{
    public class Deck10_updraftelemental_DeathsShadow_SuicideShadow_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(2, "Hooting Mandrills"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(2, "Crash Through"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Become Immense"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(4, "Mutagenic Growth"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Hooting Mandrills"),
            new SampleCard(1, "Temur Battle Rage"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(3, "Seasoned Pyromancer"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}