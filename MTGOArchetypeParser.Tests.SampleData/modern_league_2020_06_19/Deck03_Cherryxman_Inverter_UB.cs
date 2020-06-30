using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck03_Cherryxman_Inverter_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, Wielder of Mysteries"),(1, "Doom Whisperer"),(4, "Inverter of Truth"),(4, "Thassa's Oracle"),(2, "Inquisition of Kozilek"),(2, "Thoughtseize"),(2, "Archmage's Charm"),(4, "Fatal Push"),(4, "Opt"),(4, "Remand"),(1, "Shadow of Doubt"),(3, "Relic of Progenitus"),(4, "Omen of the Sea"),(4, "Darkslick Shores"),(4, "Drowned Catacomb"),(3, "Eldrazi Temple"),(2, "Polluted Delta"),(4, "River of Tears"),(1, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(4, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(1, "Cavern of Souls"),(1, "Ceremonious Rejection"),(2, "Collective Brutality"),(1, "Crypt Incursion"),(1, "Damnation"),(1, "Disdainful Stroke"),(1, "Legion's End"),(2, "Mystical Dispute"),(1, "Negate"),(1, "Spreading Seas"),(1, "Vendilion Clique") }; } }
    }
}