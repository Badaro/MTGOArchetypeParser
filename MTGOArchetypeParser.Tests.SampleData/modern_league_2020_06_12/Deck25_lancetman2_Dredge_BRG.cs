using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck25_lancetman2_Dredge_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Bloodghast"),(3, "Golgari Thug"),(3, "Merchant of the Vale"),(4, "Narcomoeba"),(2, "Ox of Agonas"),(4, "Prized Amalgam"),(4, "Stinkweed Imp"),(4, "Cathartic Reunion"),(2, "Conflagrate"),(4, "Creeping Chill"),(3, "Life from the Loam"),(4, "Shriekhorn"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(2, "Copperline Gorge"),(1, "Dakmor Salvage"),(2, "Forgotten Cave"),(1, "Gemstone Caverns"),(2, "Mountain"),(2, "Stomping Ground"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Ancient Grudge"),(1, "Blast Zone"),(1, "Blood Moon"),(2, "Leyline of Sanctity"),(3, "Lightning Axe"),(3, "Nature's Claim"),(2, "Pithing Needle"),(2, "Thoughtseize") }; } }
    }
}