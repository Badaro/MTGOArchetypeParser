using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck27_waru_Merfolk_WU_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Benthic Biomancer"),(2, "Harbinger of the Tides"),(4, "Lord of Atlantis"),(4, "Master of the Pearl Trident"),(4, "Merfolk Trickster"),(4, "Silvergill Adept"),(4, "Unsettled Mariner"),(1, "Cryptic Command"),(3, "Force of Negation"),(2, "Path to Exile"),(4, "Aether Vial"),(4, "Spreading Seas"),(2, "Hallowed Fountain"),(1, "Misty Rainforest"),(4, "Mutavault"),(4, "Seachrome Coast"),(5, "Snow-Covered Island"),(4, "Wanderwine Hub") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Lurrus of the Dream Den"),(1, "Phyrexian Revoker"),(1, "Spellskite"),(2, "Stony Silence"),(4, "Tidebinder Mage"),(4, "Tormod's Crypt"),(2, "Wizard's Retort") }; } }
    }
}