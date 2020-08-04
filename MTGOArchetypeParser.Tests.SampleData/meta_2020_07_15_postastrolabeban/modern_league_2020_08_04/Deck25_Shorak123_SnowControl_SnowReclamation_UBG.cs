using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck25_Shorak123_SnowControl_SnowReclamation_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Nightmare Muse"),
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Dead of Winter"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Fact or Fiction"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Search for Azcanta"),
            new SampleCard(3, "Wilderness Reclamation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Nightmare Muse"),
            new SampleCard(1, "Dead of Winter"),
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Commence the Endgame"),
            new SampleCard(2, "Ravenous Trap"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Wurmcoil Engine") 
        };
    }
}