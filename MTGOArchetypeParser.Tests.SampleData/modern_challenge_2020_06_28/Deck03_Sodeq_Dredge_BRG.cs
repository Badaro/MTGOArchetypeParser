using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck03_Sodeq_Dredge_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Golgari Thug"),(3, "Merchant of the Vale"),(3, "Narcomoeba"),(3, "Ox of Agonas"),(4, "Prized Amalgam"),(4, "Silversmote Ghoul"),(4, "Stinkweed Imp"),(4, "Cathartic Reunion"),(2, "Conflagrate"),(4, "Creeping Chill"),(4, "Life from the Loam"),(4, "Shriekhorn"),(2, "Blood Crypt"),(3, "Bloodstained Mire"),(1, "City of Brass"),(2, "Copperline Gorge"),(2, "Forgotten Cave"),(3, "Scalding Tarn"),(2, "Snow-Covered Mountain"),(2, "Stomping Ground"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ancient Grudge"),(1, "Blast Zone"),(2, "Leyline of the Void"),(3, "Lightning Axe"),(3, "Nature's Claim"),(1, "Pithing Needle"),(3, "Thoughtseize") }; } }
    }
}