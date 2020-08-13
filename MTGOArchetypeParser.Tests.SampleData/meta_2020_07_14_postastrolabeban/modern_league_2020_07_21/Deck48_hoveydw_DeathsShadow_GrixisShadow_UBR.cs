using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck48_hoveydw_DeathsShadow_GrixisShadow_UBR : ISampleDeck
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
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(4, "Stubborn Denial"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(1, "Terminate"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Terminate"),
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}