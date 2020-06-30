using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck25_Jidden_ThopterUrza_WU : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Teferi, Time Raveler"),(4, "Urza, Lord High Artificer"),(3, "Archmage's Charm"),(2, "Cryptic Command"),(1, "Deprive"),(3, "Path to Exile"),(3, "Whir of Invention"),(4, "Arcum's Astrolabe"),(1, "Ensnaring Bridge"),(4, "Mishra's Bauble"),(1, "Pithing Needle"),(2, "Relic of Progenitus"),(1, "Sword of the Meek"),(3, "Talisman of Progress"),(3, "Thopter Foundry"),(4, "Flooded Strand"),(1, "Hallowed Fountain"),(2, "Lonely Sandbar"),(3, "Mystic Sanctuary"),(3, "Polluted Delta"),(2, "Scalding Tarn"),(6, "Snow-Covered Island"),(1, "Snow-Covered Plains") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ceremonious Rejection"),(2, "Damping Sphere"),(1, "Dispel"),(1, "Engineered Explosives"),(2, "Grafdigger's Cage"),(1, "Jace, the Mind Sculptor"),(2, "Leyline of Sanctity"),(1, "Mystical Dispute"),(1, "Sorcerous Spyglass"),(2, "Timely Reinforcements") }; } }
    }
}