using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck23_iuriper_Merfolk_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Benthic Biomancer"),(4, "Cursecatcher"),(4, "Lord of Atlantis"),(4, "Master of the Pearl Trident"),(4, "Merfolk Trickster"),(3, "Merrow Reejerey"),(4, "Silvergill Adept"),(3, "Dismember"),(3, "Force of Negation"),(4, "Aether Vial"),(4, "Spreading Seas"),(4, "Cavern of Souls"),(3, "Darkslick Shores"),(3, "Mutavault"),(1, "Oboro, Palace in the Clouds"),(9, "Snow-Covered Island") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(3, "Chalice of the Void"),(2, "Damping Sphere"),(2, "Flusterstorm"),(1, "Grafdigger's Cage"),(2, "Relic of Progenitus"),(3, "Tidebinder Mage") }; } }
    }
}