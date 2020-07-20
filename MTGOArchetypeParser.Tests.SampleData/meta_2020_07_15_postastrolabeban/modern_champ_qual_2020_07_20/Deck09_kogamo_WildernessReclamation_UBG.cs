using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20
{
    public class Deck09_kogamo_WildernessReclamation_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Fact or Fiction"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Growth Spiral"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Wilderness Reclamation"),
            new SampleCard(3, "Breeding Pool"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(7, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Ashiok, Nightmare Muse"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Dead of Winter"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}