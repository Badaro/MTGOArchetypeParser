using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck01_aooaaooa_Lantern_UBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Emry, Lurker of the Loch"),(2, "Simian Spirit Guide"),(4, "Inquisition of Kozilek"),(2, "Thoughtseize"),(4, "Whir of Invention"),(4, "Codex Shredder"),(1, "Engineered Explosives"),(2, "Ensnaring Bridge"),(1, "Ghoulcaller's Bell"),(4, "Lantern of Insight"),(4, "Mishra's Bauble"),(1, "Pithing Needle"),(1, "Pyxis of Pandemonium"),(1, "Soul-Guide Lantern"),(3, "Sword of the Meek"),(3, "Thopter Foundry"),(1, "Academy Ruins"),(2, "Botanical Sanctum"),(4, "Darkslick Shores"),(4, "Glimmervoid"),(1, "Inventors' Fair"),(2, "Island"),(2, "River of Tears"),(4, "Spire of Industry") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Pithing Needle"),(2, "Soul-Guide Lantern"),(1, "Bontu's Last Reckoning"),(2, "Choke"),(2, "Collective Brutality"),(2, "Leyline of Sanctity"),(2, "Spell Pierce"),(1, "Tezzeret, Agent of Bolas"),(2, "Welding Jar") }; } }
    }
}