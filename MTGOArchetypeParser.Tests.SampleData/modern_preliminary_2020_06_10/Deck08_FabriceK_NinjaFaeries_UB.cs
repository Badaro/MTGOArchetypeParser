using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10
{
    public class Deck08_FabriceK_NinjaFaeries_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Changeling Outcast"),(4, "Faerie Seer"),(4, "Ingenious Infiltrator"),(3, "Mist-Syndicate Naga"),(4, "Ninja of the Deep Hours"),(1, "Snapcaster Mage"),(3, "Spectral Sailor"),(2, "Spellstutter Sprite"),(2, "Dismember"),(4, "Fatal Push"),(3, "Force of Negation"),(1, "Heartless Act"),(1, "Logic Knot"),(2, "Mana Leak"),(3, "Darkslick Shores"),(4, "Drowned Catacomb"),(4, "Polluted Delta"),(1, "Scalding Tarn"),(6, "Snow-Covered Island"),(2, "Snow-Covered Swamp"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Heartless Act"),(2, "Aether Gust"),(3, "Ceremonious Rejection"),(2, "Collective Brutality"),(1, "Countersquall"),(1, "Engineered Explosives"),(2, "Flusterstorm"),(3, "Relic of Progenitus") }; } }
    }
}