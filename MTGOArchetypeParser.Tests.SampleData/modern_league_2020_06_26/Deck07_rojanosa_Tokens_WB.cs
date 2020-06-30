using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck07_rojanosa_Tokens_WB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Gideon, Ally of Zendikar"),(2, "Sorin, Solemn Visitor"),(4, "Stoneforge Mystic"),(4, "Tidehollow Sculler"),(4, "Inquisition of Kozilek"),(4, "Lingering Souls"),(4, "Spectral Procession"),(3, "Fatal Push"),(4, "Path to Exile"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(1, "Sword of Fire and Ice"),(4, "Bitterblossom"),(3, "Caves of Koilos"),(4, "Concealed Courtyard"),(2, "Godless Shrine"),(2, "Plains"),(4, "Shambling Vent"),(2, "Silent Clearing"),(1, "Swamp"),(1, "Vault of the Archangel"),(4, "Windbrisk Heights") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Duress"),(2, "Kaya's Guile"),(1, "Orzhov Pontiff"),(2, "Relic of Progenitus"),(2, "Stony Silence"),(2, "Sundering Growth"),(1, "Timely Reinforcements"),(2, "Wrath of God") }; } }
    }
}