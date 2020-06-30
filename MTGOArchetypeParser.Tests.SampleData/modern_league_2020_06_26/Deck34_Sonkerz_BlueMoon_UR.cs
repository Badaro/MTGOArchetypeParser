using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck34_Sonkerz_BlueMoon_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Narset, Parter of Veils"),(4, "Snapcaster Mage"),(4, "Thing in the Ice"),(1, "Vendilion Clique"),(1, "Flame Slash"),(3, "Serum Visions"),(1, "Abrade"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(1, "Electrolyze"),(2, "Force of Negation"),(4, "Lightning Bolt"),(1, "Magmatic Sinkhole"),(1, "Mana Leak"),(4, "Opt"),(3, "Remand"),(2, "Spell Snare"),(2, "Cascade Bluffs"),(7, "Island"),(1, "Mountain"),(2, "Mystic Sanctuary"),(4, "Polluted Delta"),(4, "Scalding Tarn"),(2, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Flame Slash"),(3, "Aether Gust"),(2, "Anger of the Gods"),(1, "Ashiok, Dream Render"),(2, "Blood Moon"),(1, "Dragon's Claw"),(1, "Engineered Explosives"),(1, "Flusterstorm"),(1, "Mystical Dispute"),(2, "Relic of Progenitus") }; } }
    }
}