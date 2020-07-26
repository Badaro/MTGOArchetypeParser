using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_17
{
    public class Deck07_Dwagz_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(3, "Gurmag Angler"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(1, "Tasigur, the Golden Fang"),
            new SampleCard(1, "Inquisition of Kozilek"),
            new SampleCard(2, "Serum Visions"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Eliminate"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(4, "Stubborn Denial"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Island"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Eliminate"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Plague Engineer") 
        };
    }
}