using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck10_Xenowan_Inverter_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, Wielder of Mysteries"),(4, "Inverter of Truth"),(1, "Snapcaster Mage"),(4, "Thassa's Oracle"),(3, "Inquisition of Kozilek"),(3, "Thoughtseize"),(1, "Dismember"),(4, "Fatal Push"),(4, "Opt"),(4, "Remand"),(3, "Relic of Progenitus"),(4, "Omen of the Sea"),(4, "Darkslick Shores"),(3, "Drowned Catacomb"),(3, "Eldrazi Temple"),(1, "Island"),(3, "Polluted Delta"),(4, "River of Tears"),(1, "Swamp"),(4, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Relic of Progenitus"),(3, "Aether Gust"),(2, "Ashiok, Dream Render"),(2, "Collective Brutality"),(1, "Damping Sphere"),(1, "Disdainful Stroke"),(2, "Flusterstorm"),(1, "Liliana, the Last Hope"),(2, "Mystical Dispute") }; } }
    }
}