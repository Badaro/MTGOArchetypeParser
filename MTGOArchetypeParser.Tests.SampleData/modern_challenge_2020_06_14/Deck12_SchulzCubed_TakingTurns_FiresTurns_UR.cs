using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14
{
    public class Deck12_SchulzCubed_TakingTurns_FiresTurns_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(1, "Jace Beleren"),
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Narset, Parter of Veils"),
            new SampleCard(1, "Simian Spirit Guide"),
            new SampleCard(2, "Exhaustion"),
            new SampleCard(4, "Savor the Moment"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Time Warp"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(1, "Opt"),
            new SampleCard(3, "Howling Mine"),
            new SampleCard(2, "Dictate of Kruphix"),
            new SampleCard(4, "Fires of Invention"),
            new SampleCard(2, "Castle Vantress"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(1, "Mikokoro, Center of the Sea"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(7, "Snow-Covered Island"),
            new SampleCard(3, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(1, "Abrade"),
            new SampleCard(1, "Aetherspouts"),
            new SampleCard(1, "Defense Grid"),
            new SampleCard(1, "Dispel"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Keranos, God of Storms"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Negate"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(1, "Pyroclasm"),
            new SampleCard(1, "Spell Pierce") 
        };
    }
}