using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck42_mstanzione_ElectroBalance_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Greater Gargadon"),(4, "Simian Spirit Guide"),(3, "Ancestral Vision"),(4, "Crashing Footfalls"),(3, "Finale of Promise"),(4, "Restore Balance"),(3, "Serum Visions"),(4, "Electrodominance"),(2, "Force of Negation"),(4, "Izzet Charm"),(3, "Opt"),(2, "Spell Pierce"),(4, "As Foretold"),(1, "Bloodstained Mire"),(4, "Fiery Islet"),(1, "Island"),(1, "Mountain"),(4, "Scalding Tarn"),(4, "Spirebluff Canal"),(2, "Steam Vents"),(1, "Stomping Ground") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Force of Negation"),(3, "Abrade"),(4, "Goblin Rabblemaster"),(3, "Leyline of Sanctity"),(2, "Leyline of the Void"),(2, "Mystical Dispute") }; } }
    }
}