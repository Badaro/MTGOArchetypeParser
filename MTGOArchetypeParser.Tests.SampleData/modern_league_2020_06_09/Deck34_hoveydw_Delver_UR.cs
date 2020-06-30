using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck34_hoveydw_Delver_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Delver of Secrets"),(4, "Monastery Swiftspear"),(4, "Young Pyromancer"),(1, "Forked Bolt"),(3, "Of One Mind"),(4, "Serum Visions"),(1, "Archmage's Charm"),(4, "Force of Negation"),(4, "Lightning Bolt"),(2, "Mana Leak"),(4, "Opt"),(4, "Remand"),(2, "Spell Snare"),(1, "Flooded Strand"),(1, "Misty Rainforest"),(2, "Mystic Sanctuary"),(1, "Polluted Delta"),(4, "Scalding Tarn"),(4, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(2, "Spirebluff Canal"),(3, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(3, "Blood Moon"),(3, "Ceremonious Rejection"),(2, "Grafdigger's Cage"),(1, "Magmatic Sinkhole"),(2, "Mystical Dispute"),(2, "Narset, Parter of Veils") }; } }
    }
}