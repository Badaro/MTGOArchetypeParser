using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck09_retiredcapivara_Dredge_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Bloodghast"),(2, "Golgari Thug"),(3, "Merchant of the Vale"),(4, "Narcomoeba"),(2, "Ox of Agonas"),(3, "Prized Amalgam"),(4, "Stinkweed Imp"),(4, "Cathartic Reunion"),(2, "Conflagrate"),(4, "Creeping Chill"),(4, "Life from the Loam"),(4, "Shriekhorn"),(3, "Arid Mesa"),(2, "Blood Crypt"),(2, "Bloodstained Mire"),(2, "Copperline Gorge"),(1, "Dakmor Salvage"),(2, "Forgotten Cave"),(1, "Gemstone Caverns"),(2, "Mountain"),(2, "Stomping Ground"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Ancient Grudge"),(2, "Blast Zone"),(2, "Leyline of Sanctity"),(3, "Lightning Axe"),(3, "Nature's Claim"),(2, "Pithing Needle"),(2, "Thoughtseize") }; } }
    }
}