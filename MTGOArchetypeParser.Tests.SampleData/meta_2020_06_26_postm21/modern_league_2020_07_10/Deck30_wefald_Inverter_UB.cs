using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_10
{
    public class Deck30_wefald_Inverter_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, Wielder of Mysteries"),
            new SampleCard(4, "Inverter of Truth"),
            new SampleCard(4, "Thassa's Oracle"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(1, "Murderous Cut"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(4, "Omen of the Sea"),
            new SampleCard(4, "Darkslick Shores"),
            new SampleCard(3, "Drowned Catacomb"),
            new SampleCard(3, "Eldrazi Temple"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(4, "River of Tears"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(4, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Spreading Seas") 
        };
    }
}