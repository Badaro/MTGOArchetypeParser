using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck33_Mhawaii05_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Dark Confidant"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(3, "Lightning Skelemental"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(1, "Unearth"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(1, "Seal of Fire"),
            new SampleCard(3, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Raging Ravine"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(1, "Seal of Fire"),
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Kalitas, Traitor of Ghet"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Weather the Storm") 
        };
    }
}