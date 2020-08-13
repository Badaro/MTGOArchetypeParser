using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_07_13
{
    public class Deck32_Erik157751_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(3, "Bloodbraid Elf"),
            new SampleCard(2, "Dark Confidant"),
            new SampleCard(3, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(1, "Barren Moor"),
            new SampleCard(3, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Raging Ravine"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Swamp"),
            new SampleCard(4, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Choke"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(2, "Stone Rain"),
            new SampleCard(3, "Surgical Extraction"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}