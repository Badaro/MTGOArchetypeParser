using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck50_Gleiciano_PrimevalTitan_TitanShift_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Courser of Kruphix"),(2, "Dryad of the Ilysian Grove"),(4, "Primeval Titan"),(4, "Sakura-Tribe Elder"),(3, "Explore"),(3, "Farseek"),(3, "Scapeshift"),(4, "Search for Tomorrow"),(1, "Beast Within"),(3, "Lightning Bolt"),(3, "Summoner's Pact"),(3, "Castle Garenbrig"),(2, "Cinder Glade"),(1, "Field of the Dead"),(1, "Forest"),(3, "Mountain"),(1, "Sheltered Thicket"),(1, "Snow-Covered Forest"),(3, "Snow-Covered Mountain"),(4, "Stomping Ground"),(4, "Valakut, the Molten Pinnacle"),(2, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Anger of the Gods"),(2, "Damping Sphere"),(2, "Force of Vigor"),(1, "Fry"),(1, "Hour of Devastation"),(1, "Magmatic Sinkhole"),(2, "Obstinate Baloth"),(1, "Reclamation Sage"),(1, "Sweltering Suns"),(1, "Tireless Tracker"),(2, "Veil of Summer") }; } }
    }
}