using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_19
{
    public class Deck11_ManavonRX_Skelementals_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Liliana of the Veil"),(4, "Dark Confidant"),(4, "Kroxa, Titan of Death's Hunger"),(4, "Lightning Skelemental"),(2, "Inquisition of Kozilek"),(4, "Ransack the Lab"),(4, "Thoughtseize"),(4, "Unearth"),(3, "Fatal Push"),(2, "Kolaghan's Command"),(4, "Lightning Bolt"),(4, "Blackcleave Cliffs"),(3, "Blood Crypt"),(4, "Bloodstained Mire"),(2, "Castle Locthwain"),(2, "Polluted Delta"),(2, "Snow-Covered Mountain"),(3, "Snow-Covered Swamp"),(1, "Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(2, "Anger of the Gods"),(3, "Ashiok, Dream Render"),(1, "Damnation"),(2, "Damping Sphere"),(3, "Dragon's Claw"),(2, "Kalitas, Traitor of Ghet") }; } }
    }
}