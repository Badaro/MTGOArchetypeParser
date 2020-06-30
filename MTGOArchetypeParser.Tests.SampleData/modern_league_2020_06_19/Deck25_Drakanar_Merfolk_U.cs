using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck25_Drakanar_Merfolk_U : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Benthic Biomancer"),(2, "Brazen Borrower"),(4, "Lord of Atlantis"),(4, "Master of the Pearl Trident"),(3, "Master of Waves"),(4, "Merfolk Trickster"),(4, "Merrow Reejerey"),(4, "Silvergill Adept"),(3, "Dismember"),(2, "Force of Negation"),(4, "Aether Vial"),(2, "Spreading Seas"),(1, "Cavern of Souls"),(4, "Mutavault"),(1, "Oboro, Palace in the Clouds"),(11, "Snow-Covered Island"),(3, "Waterlogged Grove") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Master of Waves"),(1, "Force of Negation"),(1, "Spreading Seas"),(3, "Damping Matrix"),(2, "Damping Sphere"),(3, "Deprive"),(2, "Grafdigger's Cage"),(2, "Relic of Progenitus") }; } }
    }
}