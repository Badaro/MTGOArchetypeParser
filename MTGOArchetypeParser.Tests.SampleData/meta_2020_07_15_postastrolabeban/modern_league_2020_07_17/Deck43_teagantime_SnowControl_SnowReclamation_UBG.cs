using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_17
{
    public class Deck43_teagantime_SnowControl_SnowReclamation_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Ice-Fang Coatl"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Fact or Fiction"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Frantic Inventory"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Wilderness Reclamation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(7, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Fatal Push"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Ravenous Trap"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}