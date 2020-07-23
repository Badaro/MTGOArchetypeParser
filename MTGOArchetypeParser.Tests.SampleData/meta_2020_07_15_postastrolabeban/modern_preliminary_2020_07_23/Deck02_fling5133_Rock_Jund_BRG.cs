using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_23
{
    public class Deck02_fling5133_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(2, "Bloodbraid Elf"),
            new SampleCard(2, "Klothys, God of Destiny"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(3, "Seasoned Pyromancer"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(1, "Canyon Slough"),
            new SampleCard(2, "Forest"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Raging Ravine"),
            new SampleCard(1, "Sheltered Thicket"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(2, "Doom Blade"),
            new SampleCard(4, "Dragon's Claw"),
            new SampleCard(3, "Grafdigger's Cage") 
        };
    }
}