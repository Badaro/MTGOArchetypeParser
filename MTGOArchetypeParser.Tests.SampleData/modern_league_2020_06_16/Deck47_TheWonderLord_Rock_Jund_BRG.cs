using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck47_TheWonderLord_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Hexdrinker"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Barren Moor"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Raging Ravine"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Boil"),
            new SampleCard(1, "Choke"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(2, "Huntmaster of the Fells"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(2, "Nihil Spellbomb") 
        };
    }
}