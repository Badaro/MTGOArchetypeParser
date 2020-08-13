using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_03
{
    public class Deck48_MadMaxErnst_SnowControl_SultaiSnow_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(1, "Rise // Fall"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(1, "Drown in the Loch"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Creeping Tar Pit"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
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
            new SampleCard(1, "Dead of Winter"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}