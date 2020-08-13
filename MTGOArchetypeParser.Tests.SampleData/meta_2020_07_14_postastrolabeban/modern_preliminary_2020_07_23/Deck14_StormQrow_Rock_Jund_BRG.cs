using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_23
{
    public class Deck14_StormQrow_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(3, "Bloodbraid Elf"),
            new SampleCard(1, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(2, "Seasoned Pyromancer"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(3, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(2, "Raging Ravine"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Alpine Moon"),
            new SampleCard(1, "Ancient Grudge"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(4, "Fulminator Mage"),
            new SampleCard(1, "Huntmaster of the Fells"),
            new SampleCard(1, "Leyline of the Void"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Plague Engineer") 
        };
    }
}