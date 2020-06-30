using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck11_sneakyrobot_Infect_WG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Giver of Runes"),(4, "Glistener Elf"),(4, "Ichorclaw Myr"),(4, "Noble Hierarch"),(4, "Scale Up"),(4, "Blossoming Defense"),(3, "Groundswell"),(4, "Might of Old Krosa"),(3, "Mutagenic Growth"),(4, "Vines of Vastwood"),(2, "Rancor"),(4, "Horizon Canopy"),(4, "Inkmoth Nexus"),(1, "Pendelhaven"),(4, "Razorverge Thicket"),(3, "Snow-Covered Forest"),(3, "Temple Garden"),(1, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Burrenton Forge-Tender"),(1, "Choke"),(2, "Force of Vigor"),(1, "Grafdigger's Cage"),(1, "Kor Firewalker"),(2, "Path to Exile"),(4, "Silhana Ledgewalker"),(1, "Spellskite"),(1, "Veil of Summer"),(1, "Wild Defiance") }; } }
    }
}