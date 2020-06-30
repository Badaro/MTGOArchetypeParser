using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck06_3HaLeX1_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(4, "Gurmag Angler"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Drown in the Loch"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Stubborn Denial"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Island"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Drown in the Loch"),
            new SampleCard(1, "Aether Gust"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Force of Negation"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(1, "Nihil Spellbomb") 
        };
    }
}