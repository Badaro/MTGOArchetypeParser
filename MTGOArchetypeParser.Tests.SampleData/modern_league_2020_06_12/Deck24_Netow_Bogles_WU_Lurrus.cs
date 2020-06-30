using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck24_Netow_Bogles_WU_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Invisible Stalker"),(3, "Kor Spiritdancer"),(4, "Slippery Bogle"),(4, "Force of Negation"),(1, "Path to Exile"),(4, "Arcane Flight"),(4, "Curious Obsession"),(4, "Daybreak Coronet"),(4, "Ethereal Armor"),(4, "Hyena Umbra"),(2, "Spirit Mantle"),(3, "Staggering Insight"),(4, "Flooded Strand"),(4, "Hallowed Fountain"),(1, "Horizon Canopy"),(2, "Island"),(3, "Plains"),(4, "Seachrome Coast"),(1, "Waterlogged Grove") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Path to Exile"),(4, "Leyline of Sanctity"),(1, "Lurrus of the Dream Den"),(2, "Revoke Existence"),(2, "Silence"),(2, "Soul-Guide Lantern"),(2, "Suppression Field") }; } }
    }
}