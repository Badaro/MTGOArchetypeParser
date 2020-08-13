using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_07_26
{
    public class Deck32_sultai4lyfe_DimirControl_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(4, "Narset, Parter of Veils"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(2, "Damnation"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(1, "Bloodstained Mire"),
            new SampleCard(3, "Creeping Tar Pit"),
            new SampleCard(2, "Darkslick Shores"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(2, "Geier Reach Sanitarium"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "River of Tears"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(1, "Sunken Ruins"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Hostage Taker"),
            new SampleCard(1, "Kalitas, Traitor of Ghet"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Spell Pierce") 
        };
    }
}