using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck16_fupalorda_ElectroBalance_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Brazen Borrower"),(3, "Greater Gargadon"),(4, "Simian Spirit Guide"),(3, "Ancestral Vision"),(4, "Crashing Footfalls"),(1, "Finale of Promise"),(4, "Restore Balance"),(3, "Serum Visions"),(1, "Abrade"),(4, "Electrodominance"),(1, "Force of Negation"),(1, "Izzet Charm"),(3, "Lightning Bolt"),(4, "Opt"),(2, "Spell Snare"),(4, "As Foretold"),(3, "Fiery Islet"),(1, "Mountain"),(4, "Scalding Tarn"),(1, "Snow-Covered Island"),(4, "Spirebluff Canal"),(3, "Steam Vents"),(1, "Stomping Ground") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Anger of the Gods"),(2, "Blood Moon"),(3, "Grafdigger's Cage"),(4, "Leyline of Sanctity"),(2, "Shattering Spree"),(2, "Veil of Summer") }; } }
    }
}