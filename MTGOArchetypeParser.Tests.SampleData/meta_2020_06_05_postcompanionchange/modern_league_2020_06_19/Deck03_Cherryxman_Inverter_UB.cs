using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19
{
    public class Deck03_Cherryxman_Inverter_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, Wielder of Mysteries"),
            new SampleCard(1, "Doom Whisperer"),
            new SampleCard(4, "Inverter of Truth"),
            new SampleCard(4, "Thassa's Oracle"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(1, "Shadow of Doubt"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(4, "Omen of the Sea"),
            new SampleCard(4, "Darkslick Shores"),
            new SampleCard(4, "Drowned Catacomb"),
            new SampleCard(3, "Eldrazi Temple"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(4, "River of Tears"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(4, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Crypt Incursion"),
            new SampleCard(1, "Damnation"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Legion's End"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Negate"),
            new SampleCard(1, "Spreading Seas"),
            new SampleCard(1, "Vendilion Clique") 
        };
    }
}