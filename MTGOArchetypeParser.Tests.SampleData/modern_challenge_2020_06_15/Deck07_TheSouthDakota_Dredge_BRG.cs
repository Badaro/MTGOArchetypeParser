using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck07_TheSouthDakota_Dredge_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Bloodghast"),(3, "Golgari Thug"),(3, "Merchant of the Vale"),(4, "Narcomoeba"),(3, "Ox of Agonas"),(4, "Prized Amalgam"),(4, "Stinkweed Imp"),(4, "Cathartic Reunion"),(1, "Conflagrate"),(4, "Creeping Chill"),(3, "Life from the Loam"),(4, "Shriekhorn"),(4, "Arid Mesa"),(2, "Blood Crypt"),(3, "Bloodstained Mire"),(1, "City of Brass"),(3, "Copperline Gorge"),(1, "Dakmor Salvage"),(2, "Forgotten Cave"),(2, "Mountain"),(2, "Stomping Ground") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ancient Grudge"),(1, "Blast Zone"),(2, "Leyline of Sanctity"),(3, "Lightning Axe"),(3, "Nature's Claim"),(2, "Pithing Needle"),(2, "Thoughtseize") }; } }
    }
}