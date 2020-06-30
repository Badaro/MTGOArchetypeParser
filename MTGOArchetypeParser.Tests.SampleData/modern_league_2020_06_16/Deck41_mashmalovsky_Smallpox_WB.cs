using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck41_mashmalovsky_Smallpox_WB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Elspeth, Sun's Nemesis"),(1, "Gideon, Ally of Zendikar"),(1, "Kaya, Orzhov Usurper"),(4, "Liliana of the Veil"),(4, "Stoneforge Mystic"),(4, "Inquisition of Kozilek"),(4, "Lingering Souls"),(4, "Smallpox"),(3, "Thoughtseize"),(4, "Fatal Push"),(2, "Kaya's Guile"),(1, "Path to Exile"),(1, "Batterskull"),(1, "Sword of Fire and Ice"),(1, "Castle Locthwain"),(2, "Fetid Heath"),(4, "Flagstones of Trokair"),(3, "Godless Shrine"),(4, "Marsh Flats"),(1, "Plains"),(2, "Shambling Vent"),(2, "Silent Clearing"),(3, "Swamp"),(3, "Urborg, Tomb of Yawgmoth") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Kaya's Guile"),(2, "Ashiok, Dream Render"),(2, "Collective Brutality"),(1, "Damnation"),(1, "Damping Sphere"),(1, "Disenchant"),(3, "Fulminator Mage"),(2, "Plague Engineer"),(2, "Rest in Peace") }; } }
    }
}