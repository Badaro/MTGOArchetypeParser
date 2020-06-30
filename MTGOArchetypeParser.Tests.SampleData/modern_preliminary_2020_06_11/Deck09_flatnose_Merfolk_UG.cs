using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_11
{
    public class Deck09_flatnose_Merfolk_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Brazen Borrower"),(4, "Kumena's Speaker"),(4, "Lord of Atlantis"),(4, "Master of the Pearl Trident"),(4, "Merfolk Mistbinder"),(4, "Merfolk Trickster"),(4, "Silvergill Adept"),(2, "Dismember"),(4, "Force of Negation"),(4, "Aether Vial"),(4, "Spreading Seas"),(4, "Botanical Sanctum"),(1, "Breeding Pool"),(2, "Cavern of Souls"),(2, "Flooded Strand"),(4, "Island"),(3, "Mutavault"),(4, "Waterlogged Grove") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Ashiok, Dream Render"),(3, "Chalice of the Void"),(3, "Deprive"),(4, "Relic of Progenitus"),(4, "Tidebinder Mage") }; } }
    }
}