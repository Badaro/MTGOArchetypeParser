using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_19
{
    public class Deck15_rn17_ThopterUrza_UBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Emry, Lurker of the Loch"),(4, "Goblin Engineer"),(4, "Urza, Lord High Artificer"),(2, "Whir of Invention"),(1, "Aether Spellbomb"),(4, "Arcum's Astrolabe"),(2, "Engineered Explosives"),(1, "Ensnaring Bridge"),(4, "Mishra's Bauble"),(2, "Mox Amber"),(1, "Nihil Spellbomb"),(2, "Pentad Prism"),(1, "Pithing Needle"),(2, "Sword of the Meek"),(4, "Thopter Foundry"),(4, "Flooded Strand"),(1, "Inventors' Fair"),(1, "Misty Rainforest"),(4, "Polluted Delta"),(8, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(1, "Steam Vents"),(1, "Sunken Hollow"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(2, "Ceremonious Rejection"),(1, "Collective Brutality"),(1, "Damping Sphere"),(2, "Galvanic Blast"),(1, "Grafdigger's Cage"),(2, "Mystical Dispute"),(1, "Tezzeret, Agent of Bolas"),(3, "Thoughtseize") }; } }
    }
}