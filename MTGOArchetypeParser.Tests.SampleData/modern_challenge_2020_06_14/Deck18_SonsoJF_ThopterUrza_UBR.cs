using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14
{
    public class Deck18_SonsoJF_ThopterUrza_UBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Emry, Lurker of the Loch"),(3, "Goblin Engineer"),(4, "Urza, Lord High Artificer"),(1, "Galvanic Blast"),(2, "Whir of Invention"),(4, "Arcum's Astrolabe"),(2, "Engineered Explosives"),(1, "Ensnaring Bridge"),(4, "Mishra's Bauble"),(2, "Mox Amber"),(1, "Nihil Spellbomb"),(2, "Pentad Prism"),(1, "Pithing Needle"),(1, "Pyrite Spellbomb"),(2, "Sword of the Meek"),(4, "Thopter Foundry"),(1, "Inventors' Fair"),(4, "Polluted Delta"),(4, "Scalding Tarn"),(7, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(2, "Snow-Covered Swamp"),(1, "Steam Vents"),(1, "Sunken Hollow"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Galvanic Blast"),(3, "Aether Gust"),(1, "Damping Sphere"),(1, "Fatal Push"),(1, "Grafdigger's Cage"),(2, "Mystical Dispute"),(3, "Thoughtseize") }; } }
    }
}