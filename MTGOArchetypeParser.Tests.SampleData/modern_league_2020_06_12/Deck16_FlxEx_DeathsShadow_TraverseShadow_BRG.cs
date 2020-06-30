using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck16_FlxEx_DeathsShadow_TraverseShadow_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Liliana of the Veil"),
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(1, "Lurrus of the Dream Den"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Traverse the Ulvenwald"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(1, "Forest"),
            new SampleCard(4, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(1, "Temur Battle Rage"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(4, "Collective Brutality"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(1, "Fulminator Mage"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(1, "Rampaging Ferocidon"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(1, "Yixlid Jailer") 
        };
    }
}