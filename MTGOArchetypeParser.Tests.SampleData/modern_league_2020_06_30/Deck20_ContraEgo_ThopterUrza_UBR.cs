using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck20_ContraEgo_ThopterUrza_UBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Goblin Engineer"),(4, "Urza, Lord High Artificer"),(3, "Galvanic Blast"),(2, "Metallic Rebuke"),(3, "Whir of Invention"),(1, "Aether Spellbomb"),(4, "Arcum's Astrolabe"),(1, "Damping Sphere"),(1, "Ensnaring Bridge"),(4, "Mishra's Bauble"),(1, "Nihil Spellbomb"),(2, "Pentad Prism"),(1, "Pithing Needle"),(2, "Sword of the Meek"),(1, "Talisman of Dominance"),(4, "Thopter Foundry"),(1, "Blood Crypt"),(1, "Flooded Strand"),(1, "Mystic Sanctuary"),(4, "Polluted Delta"),(4, "Scalding Tarn"),(7, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(1, "Snow-Covered Swamp"),(1, "Steam Vents"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(1, "Ashiok, Nightmare Muse"),(1, "Cryptic Command"),(2, "Dead of Winter"),(1, "Disdainful Stroke"),(1, "Dreadbore"),(1, "Fatal Push"),(1, "Ghirapur Aether Grid"),(1, "Grafdigger's Cage"),(1, "Herald of Anguish"),(1, "Sorcerous Spyglass"),(2, "Thoughtseize") }; } }
    }
}