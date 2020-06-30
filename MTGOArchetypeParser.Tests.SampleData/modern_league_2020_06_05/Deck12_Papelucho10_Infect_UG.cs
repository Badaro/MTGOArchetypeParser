using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck12_Papelucho10_Infect_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Blighted Agent"),(4, "Glistener Elf"),(4, "Noble Hierarch"),(1, "Spellskite"),(3, "Distortion Strike"),(4, "Scale Up"),(1, "Sylvan Scrying"),(1, "Become Immense"),(4, "Blossoming Defense"),(4, "Groundswell"),(4, "Might of Old Krosa"),(2, "Spell Pierce"),(4, "Vines of Vastwood"),(2, "Breeding Pool"),(1, "Dryad Arbor"),(4, "Inkmoth Nexus"),(1, "Misty Rainforest"),(2, "Pendelhaven"),(2, "Snow-Covered Forest"),(2, "Waterlogged Grove"),(3, "Windswept Heath"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Sylvan Scrying"),(2, "Dismember"),(2, "Force of Vigor"),(2, "Mystical Dispute"),(2, "Pithing Needle"),(1, "Postmortem Lunge"),(3, "Veil of Summer"),(2, "Viridian Corrupter") }; } }
    }
}