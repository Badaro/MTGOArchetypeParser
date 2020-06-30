using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck45_Lucabireskusku_Inverter_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Jace, Wielder of Mysteries"),(4, "Inverter of Truth"),(4, "Thassa's Oracle"),(3, "Inquisition of Kozilek"),(3, "Thoughtseize"),(4, "Fatal Push"),(4, "Opt"),(4, "Remand"),(3, "Relic of Progenitus"),(4, "Omen of the Sea"),(4, "Darkslick Shores"),(4, "Drowned Catacomb"),(3, "Eldrazi Temple"),(1, "Island"),(2, "Polluted Delta"),(2, "River of Tears"),(2, "Shelldock Isle"),(1, "Swamp"),(4, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Aether Gust"),(1, "Cavern of Souls"),(2, "Ceremonious Rejection"),(2, "Collective Brutality"),(1, "Cry of the Carnarium"),(3, "Mystical Dispute"),(1, "Narset, Parter of Veils"),(1, "Negate"),(3, "Spreading Seas") }; } }
    }
}