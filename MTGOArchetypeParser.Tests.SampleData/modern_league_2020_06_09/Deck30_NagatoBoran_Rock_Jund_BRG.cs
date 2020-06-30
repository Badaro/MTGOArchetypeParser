using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck30_NagatoBoran_Rock_Jund_BRG : ISampleDeck
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
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Boil"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(3, "Pillage"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Weather the Storm") 
        };
    }
}