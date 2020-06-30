using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck18_YBLime_ThopterUrza_WUBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Teferi, Time Raveler"),(4, "Emry, Lurker of the Loch"),(3, "Goblin Engineer"),(3, "Lurrus of the Dream Den"),(4, "Urza, Lord High Artificer"),(3, "Whir of Invention"),(4, "Arcum's Astrolabe"),(1, "Damping Sphere"),(1, "Engineered Explosives"),(4, "Mishra's Bauble"),(1, "Mox Amber"),(1, "Nihil Spellbomb"),(1, "Pithing Needle"),(2, "Pyrite Spellbomb"),(1, "Sword of the Meek"),(4, "Thopter Foundry"),(1, "Flooded Strand"),(1, "Hallowed Fountain"),(3, "Polluted Delta"),(4, "Prismatic Vista"),(1, "Scalding Tarn"),(6, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(1, "Snow-Covered Plains"),(2, "Snow-Covered Swamp"),(1, "Steam Vents"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Teferi, Time Raveler"),(1, "Ashiok, Dream Render"),(2, "Battle at the Bridge"),(1, "Blood Moon"),(2, "Goblin Cratermaker"),(3, "Light of Hope"),(1, "Seal of Fire"),(3, "Spell Pierce") }; } }
    }
}