using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14
{
    public class Deck12_SchulzCubed_TakingTurns_FiresTurns_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Chandra, Torch of Defiance"),(1, "Jace Beleren"),(2, "Jace, the Mind Sculptor"),(2, "Narset, Parter of Veils"),(1, "Simian Spirit Guide"),(2, "Exhaustion"),(4, "Savor the Moment"),(4, "Serum Visions"),(4, "Time Warp"),(2, "Cryptic Command"),(2, "Lightning Bolt"),(1, "Opt"),(3, "Howling Mine"),(2, "Dictate of Kruphix"),(4, "Fires of Invention"),(2, "Castle Vantress"),(2, "Flooded Strand"),(1, "Mikokoro, Center of the Sea"),(1, "Misty Rainforest"),(4, "Mystic Sanctuary"),(2, "Polluted Delta"),(2, "Scalding Tarn"),(7, "Snow-Covered Island"),(3, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Lightning Bolt"),(1, "Abrade"),(1, "Aetherspouts"),(1, "Defense Grid"),(1, "Dispel"),(2, "Engineered Explosives"),(1, "Keranos, God of Storms"),(2, "Mystical Dispute"),(1, "Negate"),(1, "Nexus of Fate"),(1, "Pyroclasm"),(1, "Spell Pierce") }; } }
    }
}