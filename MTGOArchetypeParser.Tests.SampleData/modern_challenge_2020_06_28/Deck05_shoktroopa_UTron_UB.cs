using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck05_shoktroopa_UTron_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Ugin, the Spirit Dragon"),(2, "Snapcaster Mage"),(1, "Sundering Titan"),(1, "Thought-Knot Seer"),(1, "Trinket Mage"),(2, "Walking Ballista"),(1, "Wurmcoil Engine"),(1, "Fabricate"),(4, "Condescend"),(1, "Cyclonic Rift"),(3, "Remand"),(3, "Repeal"),(2, "Spatial Contortion"),(4, "Thirst for Knowledge"),(1, "Chalice of the Void"),(4, "Expedition Map"),(2, "Mindslaver"),(2, "Talisman of Dominance"),(1, "Trading Post"),(1, "Academy Ruins"),(1, "Blast Zone"),(1, "Cavern of Souls"),(1, "Field of Ruin"),(1, "Gemstone Caverns"),(4, "Island"),(1, "Oboro, Palace in the Clouds"),(1, "River of Tears"),(1, "Tolaria West"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Thought-Knot Seer"),(1, "Chalice of the Void"),(2, "Spatial Contortion"),(3, "Dismember"),(1, "Eldrazi Temple"),(1, "Engineered Explosives"),(1, "Relic of Progenitus"),(1, "Spell Pierce"),(2, "Surgical Extraction") }; } }
    }
}