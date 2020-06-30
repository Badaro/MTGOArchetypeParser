using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck41_marcofabrizi_SnowControl_SultaiSnow_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Nightmare Muse"),
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(2, "Rise // Fall"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Creeping Tar Pit"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Waterlogged Grove"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(3, "Tarmogoyf"),
            new SampleCard(2, "Tireless Tracker"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}