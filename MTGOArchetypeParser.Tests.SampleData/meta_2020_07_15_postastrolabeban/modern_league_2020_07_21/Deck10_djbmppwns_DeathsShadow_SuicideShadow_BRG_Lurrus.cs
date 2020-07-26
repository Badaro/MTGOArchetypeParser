using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_21
{
    public class Deck10_djbmppwns_DeathsShadow_SuicideShadow_BRG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(1, "Dreadhorde Arcanist"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(1, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Become Immense"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Mutagenic Growth"),
            new SampleCard(3, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Dreadhorde Arcanist"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Claim // Fame"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(1, "Night's Whisper"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}