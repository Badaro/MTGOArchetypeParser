using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck40_ary31415_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Barren Moor"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(2, "Raging Ravine"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Fulminator Mage"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(1, "Huntmaster of the Fells"),
            new SampleCard(2, "Pillage"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}