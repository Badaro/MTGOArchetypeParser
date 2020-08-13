using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_31
{
    public class Deck51_PieGonti_DeathsShadow_SuicideShadow_BRG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(1, "Dreadhorde Arcanist"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(1, "Soul-Scar Mage"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(3, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Mutagenic Growth"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Seal of Fire"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(2, "Kiln Fiend"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Unearth"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}