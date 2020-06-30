using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck21_Mercenario_Dredge_UBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Bloodghast"),(2, "Golgari Thug"),(3, "Merchant of the Vale"),(4, "Narcomoeba"),(2, "Ox of Agonas"),(4, "Prized Amalgam"),(4, "Stinkweed Imp"),(4, "Cathartic Reunion"),(1, "Conflagrate"),(4, "Creeping Chill"),(4, "Life from the Loam"),(4, "Shriekhorn"),(2, "Blood Crypt"),(3, "Bloodstained Mire"),(1, "City of Brass"),(2, "Copperline Gorge"),(1, "Dakmor Salvage"),(2, "Forgotten Cave"),(2, "Mountain"),(1, "Steam Vents"),(2, "Stomping Ground"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Conflagrate"),(1, "Blast Zone"),(3, "Leyline of the Void"),(4, "Lightning Axe"),(3, "Nature's Claim"),(1, "Shenanigans"),(2, "Thoughtseize") }; } }
    }
}