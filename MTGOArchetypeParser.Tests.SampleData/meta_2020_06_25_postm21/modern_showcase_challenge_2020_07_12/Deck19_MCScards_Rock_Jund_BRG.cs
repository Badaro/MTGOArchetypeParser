using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_showcase_challenge_2020_07_12
{
    public class Deck19_MCScards_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Liliana of the Veil"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(2, "Bloodbraid Elf"),
            new SampleCard(1, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(1, "Seal of Fire"),
            new SampleCard(3, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(2, "Raging Ravine"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Liliana of the Veil"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Plague Engineer") 
        };
    }
}