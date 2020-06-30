using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck16_Trellon_UTron_U : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Karn, the Great Creator"),(1, "Ugin, the Spirit Dragon"),(2, "Walking Ballista"),(2, "Wurmcoil Engine"),(4, "Condescend"),(1, "Dismember"),(4, "Remand"),(3, "Repeal"),(4, "Thirst for Knowledge"),(1, "Chalice of the Void"),(4, "Expedition Map"),(1, "Mindslaver"),(4, "Relic of Progenitus"),(2, "Talisman of Dominance"),(1, "Academy Ruins"),(1, "Blast Zone"),(2, "Gemstone Caverns"),(6, "Island"),(1, "Oboro, Palace in the Clouds"),(1, "Tolaria West"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Walking Ballista"),(1, "Wurmcoil Engine"),(1, "Chalice of the Void"),(1, "Dismember"),(3, "Aether Gust"),(1, "Ensnaring Bridge"),(1, "Liquimetal Coating"),(4, "Spreading Seas"),(1, "Sundering Titan"),(1, "Trinisphere") }; } }
    }
}