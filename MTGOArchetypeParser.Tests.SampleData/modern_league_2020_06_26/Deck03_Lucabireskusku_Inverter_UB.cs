using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck03_Lucabireskusku_Inverter_UB : ISampleDeck
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
            new SampleCard(1, "Island"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(4, "River of Tears"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Damnation"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Spreading Seas") 
        };
    }
}