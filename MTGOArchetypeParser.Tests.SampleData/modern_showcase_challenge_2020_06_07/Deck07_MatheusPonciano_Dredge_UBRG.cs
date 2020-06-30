using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck07_MatheusPonciano_Dredge_UBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Bloodghast"),(2, "Golgari Thug"),(3, "Merchant of the Vale"),(4, "Narcomoeba"),(2, "Ox of Agonas"),(4, "Prized Amalgam"),(4, "Stinkweed Imp"),(4, "Cathartic Reunion"),(2, "Conflagrate"),(4, "Creeping Chill"),(4, "Life from the Loam"),(4, "Shriekhorn"),(1, "Arid Mesa"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "City of Brass"),(1, "Dakmor Salvage"),(2, "Forgotten Cave"),(2, "Mountain"),(1, "Steam Vents"),(2, "Stomping Ground"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Blast Zone"),(1, "Blood Moon"),(2, "Leyline of Sanctity"),(3, "Lightning Axe"),(3, "Nature's Claim"),(1, "Pithing Needle"),(2, "Shenanigans"),(2, "Thoughtseize") }; } }
    }
}