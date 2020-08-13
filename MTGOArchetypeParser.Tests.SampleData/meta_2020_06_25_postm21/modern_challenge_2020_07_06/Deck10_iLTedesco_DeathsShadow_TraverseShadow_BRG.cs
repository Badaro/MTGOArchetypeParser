using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_07_06
{
    public class Deck10_iLTedesco_DeathsShadow_TraverseShadow_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Liliana of the Veil"),
            new SampleCard(1, "Wrenn and Six"),
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Traverse the Ulvenwald"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Seal of Fire"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(1, "Forest"),
            new SampleCard(3, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Wooded Foothills"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(1, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Boil"),
            new SampleCard(1, "Choke"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Grim Lavamancer"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(1, "Veil of Summer"),
            new SampleCard(1, "Yixlid Jailer") 
        };
    }
}