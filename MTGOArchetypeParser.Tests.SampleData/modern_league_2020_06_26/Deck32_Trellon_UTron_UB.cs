using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck32_Trellon_UTron_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Karn, Scion of Urza"),(1, "Ugin, the Spirit Dragon"),(1, "Myr Battlesphere"),(1, "Sundering Titan"),(1, "Treasure Mage"),(1, "Trinket Mage"),(2, "Walking Ballista"),(1, "Wurmcoil Engine"),(4, "Condescend"),(1, "Cyclonic Rift"),(1, "Dismember"),(4, "Remand"),(2, "Repeal"),(1, "Spatial Contortion"),(4, "Thirst for Knowledge"),(1, "Chalice of the Void"),(4, "Expedition Map"),(1, "Mindslaver"),(1, "Oblivion Stone"),(1, "Relic of Progenitus"),(2, "Talisman of Dominance"),(1, "Academy Ruins"),(1, "Blast Zone"),(2, "Gemstone Caverns"),(5, "Island"),(1, "Oboro, Palace in the Clouds"),(1, "River of Tears"),(1, "Tolaria West"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Chalice of the Void"),(1, "Dismember"),(2, "Relic of Progenitus"),(2, "Spatial Contortion"),(2, "Aether Gust"),(2, "Ceremonious Rejection"),(1, "Engineered Explosives"),(1, "Grafdigger's Cage"),(2, "Mystical Dispute"),(1, "Trinisphere") }; } }
    }
}