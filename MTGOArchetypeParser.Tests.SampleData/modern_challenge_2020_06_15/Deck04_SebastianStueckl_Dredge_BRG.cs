using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck04_SebastianStueckl_Dredge_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Bloodghast"),(4, "Merchant of the Vale"),(4, "Narcomoeba"),(2, "Ox of Agonas"),(4, "Prized Amalgam"),(4, "Stinkweed Imp"),(4, "Cathartic Reunion"),(1, "Conflagrate"),(4, "Creeping Chill"),(4, "Life from the Loam"),(1, "Darkblast"),(4, "Shriekhorn"),(2, "Arid Mesa"),(2, "Blood Crypt"),(2, "Bloodstained Mire"),(4, "Copperline Gorge"),(1, "Dakmor Salvage"),(2, "Forgotten Cave"),(2, "Mountain"),(3, "Stomping Ground"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Darkblast"),(1, "Ancient Grudge"),(1, "Blast Zone"),(2, "Blood Moon"),(3, "Leyline of the Void"),(3, "Lightning Axe"),(4, "Nature's Claim") }; } }
    }
}