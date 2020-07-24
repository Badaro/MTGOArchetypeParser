using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24
{
    public class Deck26_Albyz_SnowControl_SultaiSnow_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(3, "Cling to Dust"),
            new SampleCard(3, "Drown in the Loch"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Pulse of Murasa"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Creeping Tar Pit"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Pulse of Murasa"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(1, "Bitterblossom"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(3, "Plague Engineer"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}