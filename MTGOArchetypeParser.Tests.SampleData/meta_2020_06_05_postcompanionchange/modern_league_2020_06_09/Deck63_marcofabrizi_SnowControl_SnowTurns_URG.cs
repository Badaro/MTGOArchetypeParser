using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_09
{
    public class Deck63_marcofabrizi_SnowControl_SnowTurns_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Tamiyo, Collector of Tales"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Entrancing Melody"),
            new SampleCard(4, "Time Warp"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Arcum's Astrolabe"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Entrancing Melody"),
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Blood Moon"),
            new SampleCard(1, "Force of Vigor"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Voracious Hydra"),
            new SampleCard(1, "Weather the Storm"),
            new SampleCard(1, "Wilt") 
        };
    }
}