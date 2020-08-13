using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck22_Hiyori9_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(3, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(2, "Maelstrom Pulse"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Terminate"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(3, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(2, "Raging Ravine"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(2, "Terminate"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(2, "Nihil Spellbomb") 
        };
    }
}