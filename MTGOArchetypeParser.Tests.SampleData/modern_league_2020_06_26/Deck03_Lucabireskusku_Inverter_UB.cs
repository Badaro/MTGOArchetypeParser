using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck03_Lucabireskusku_Inverter_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Jace, Wielder of Mysteries"),(4, "Inverter of Truth"),(4, "Thassa's Oracle"),(3, "Inquisition of Kozilek"),(3, "Thoughtseize"),(1, "Cling to Dust"),(4, "Fatal Push"),(1, "Murderous Cut"),(4, "Opt"),(4, "Remand"),(3, "Relic of Progenitus"),(4, "Omen of the Sea"),(4, "Darkslick Shores"),(3, "Drowned Catacomb"),(3, "Eldrazi Temple"),(1, "Island"),(2, "Polluted Delta"),(4, "River of Tears"),(1, "Swamp"),(4, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(2, "Ashiok, Dream Render"),(2, "Collective Brutality"),(1, "Damnation"),(1, "Disdainful Stroke"),(2, "Flusterstorm"),(2, "Mystical Dispute"),(2, "Spreading Seas") }; } }
    }
}