using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_07_26
{
    public class Deck13_Edel_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(2, "Bloodbraid Elf"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(1, "Canyon Slough"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Raging Ravine"),
            new SampleCard(1, "Sheltered Thicket"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(4, "Ashiok, Dream Render"),
            new SampleCard(3, "Boil"),
            new SampleCard(1, "Cast Down"),
            new SampleCard(2, "Maelstrom Pulse"),
            new SampleCard(1, "Sever the Bloodline") 
        };
    }
}