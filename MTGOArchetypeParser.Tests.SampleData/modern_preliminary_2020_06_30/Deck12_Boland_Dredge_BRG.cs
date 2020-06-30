using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_30
{
    public class Deck12_Boland_Dredge_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Bloodghast"),(3, "Golgari Thug"),(4, "Narcomoeba"),(3, "Ox of Agonas"),(4, "Prized Amalgam"),(4, "Stinkweed Imp"),(4, "Cathartic Reunion"),(1, "Conflagrate"),(4, "Creeping Chill"),(3, "Life from the Loam"),(2, "Dangerous Wager"),(4, "Shriekhorn"),(3, "Arid Mesa"),(2, "Blood Crypt"),(2, "Bloodstained Mire"),(2, "Copperline Gorge"),(1, "Dakmor Salvage"),(2, "Forgotten Cave"),(1, "Gemstone Mine"),(2, "Snow-Covered Mountain"),(2, "Stomping Ground"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ancient Grudge"),(2, "Damping Sphere"),(1, "Darkblast"),(2, "Gemstone Caverns"),(4, "Leyline of the Void"),(1, "Lightning Axe"),(2, "Nature's Claim"),(1, "Shenanigans") }; } }
    }
}