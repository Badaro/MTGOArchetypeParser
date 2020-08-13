using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_12
{
    public class Deck30_kaikalbuquerque_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(3, "Scavenging Ooze"),
            new SampleCard(2, "Seasoned Pyromancer"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Barren Moor"),
            new SampleCard(3, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Raging Ravine"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Swamp"),
            new SampleCard(1, "Twilight Mire"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(2, "Boil"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Weather the Storm") 
        };
    }
}