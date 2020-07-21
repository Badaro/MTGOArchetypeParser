using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_19
{
    public class Deck11_ManavonRX_RakdosMidrange_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(4, "Dark Confidant"),
            new SampleCard(4, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Ransack the Lab"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Unearth"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "Castle Locthwain"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(3, "Snow-Covered Swamp"),
            new SampleCard(1, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(1, "Damnation"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(2, "Kalitas, Traitor of Ghet") 
        };
    }
}