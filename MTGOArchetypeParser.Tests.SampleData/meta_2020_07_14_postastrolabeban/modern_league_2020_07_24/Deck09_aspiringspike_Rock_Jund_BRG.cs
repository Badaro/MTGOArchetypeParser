using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_24
{
    public class Deck09_aspiringspike_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Barren Moor"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Forgotten Cave"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Raging Ravine"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Swamp"),
            new SampleCard(3, "Verdant Catacombs"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Boil"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(4, "Madcap Experiment"),
            new SampleCard(4, "Pillage"),
            new SampleCard(2, "Platinum Emperion"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}