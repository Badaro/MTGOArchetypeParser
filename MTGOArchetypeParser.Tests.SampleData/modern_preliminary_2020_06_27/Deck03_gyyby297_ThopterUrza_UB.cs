using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27
{
    public class Deck03_gyyby297_ThopterUrza_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Jace, the Mind Sculptor"),(4, "Urza, Lord High Artificer"),(2, "Inquisition of Kozilek"),(2, "Thoughtseize"),(3, "Archmage's Charm"),(2, "Cryptic Command"),(1, "Drown in the Loch"),(3, "Fatal Push"),(2, "Remand"),(3, "Whir of Invention"),(4, "Arcum's Astrolabe"),(4, "Mishra's Bauble"),(1, "Nihil Spellbomb"),(1, "Pithing Needle"),(1, "Sword of the Meek"),(3, "Talisman of Dominance"),(2, "Thopter Foundry"),(1, "Field of Ruin"),(1, "Flooded Strand"),(2, "Misty Rainforest"),(3, "Mystic Sanctuary"),(4, "Polluted Delta"),(2, "Scalding Tarn"),(5, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(1, "Sunken Hollow"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Fatal Push"),(1, "Aether Gust"),(2, "Ashiok, Dream Render"),(2, "Battle at the Bridge"),(3, "Ceremonious Rejection"),(1, "Damnation"),(2, "Damping Sphere"),(1, "Grafdigger's Cage"),(2, "Mystical Dispute") }; } }
    }
}