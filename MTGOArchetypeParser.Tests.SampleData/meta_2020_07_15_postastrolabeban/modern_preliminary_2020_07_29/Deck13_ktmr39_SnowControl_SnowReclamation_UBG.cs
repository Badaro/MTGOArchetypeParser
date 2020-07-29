using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_29
{
    public class Deck13_ktmr39_SnowControl_SnowReclamation_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(2, "Eliminate"),
            new SampleCard(3, "Fact or Fiction"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(2, "Remand"),
            new SampleCard(1, "Search for Azcanta"),
            new SampleCard(3, "Wilderness Reclamation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Nightpack Ambusher"),
            new SampleCard(1, "Shark Typhoon"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}