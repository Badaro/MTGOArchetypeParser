using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck22_toondoslav_Dredge_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Bloodghast"),(2, "Golgari Thug"),(3, "Merchant of the Vale"),(4, "Narcomoeba"),(3, "Ox of Agonas"),(4, "Prized Amalgam"),(4, "Stinkweed Imp"),(4, "Cathartic Reunion"),(1, "Conflagrate"),(4, "Creeping Chill"),(4, "Life from the Loam"),(4, "Shriekhorn"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "City of Brass"),(2, "Copperline Gorge"),(1, "Dakmor Salvage"),(2, "Forgotten Cave"),(2, "Mountain"),(2, "Stomping Ground"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Conflagrate"),(2, "Ancient Grudge"),(1, "Blast Zone"),(3, "Leyline of the Void"),(3, "Lightning Axe"),(2, "Nature's Claim"),(1, "Pithing Needle"),(2, "Thoughtseize") }; } }
    }
}