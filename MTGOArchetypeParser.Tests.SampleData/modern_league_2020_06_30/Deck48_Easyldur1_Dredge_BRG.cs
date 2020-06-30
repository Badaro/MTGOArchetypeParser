using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck48_Easyldur1_Dredge_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Golgari Thug"),(3, "Merchant of the Vale"),(3, "Narcomoeba"),(3, "Ox of Agonas"),(4, "Prized Amalgam"),(4, "Silversmote Ghoul"),(4, "Stinkweed Imp"),(4, "Cathartic Reunion"),(2, "Conflagrate"),(4, "Creeping Chill"),(4, "Life from the Loam"),(4, "Shriekhorn"),(4, "Arid Mesa"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "City of Brass"),(2, "Copperline Gorge"),(2, "Forgotten Cave"),(2, "Mountain"),(2, "Stomping Ground") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ancient Grudge"),(1, "Blast Zone"),(2, "Leyline of the Void"),(3, "Lightning Axe"),(3, "Nature's Claim"),(1, "Pithing Needle"),(3, "Thoughtseize") }; } }
    }
}