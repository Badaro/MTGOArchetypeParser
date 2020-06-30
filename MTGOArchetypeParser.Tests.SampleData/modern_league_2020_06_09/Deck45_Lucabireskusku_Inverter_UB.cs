using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck45_Lucabireskusku_Inverter_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Jace, Wielder of Mysteries"),
            new SampleCard(4, "Inverter of Truth"),
            new SampleCard(4, "Thassa's Oracle"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(4, "Omen of the Sea"),
            new SampleCard(4, "Darkslick Shores"),
            new SampleCard(4, "Drowned Catacomb"),
            new SampleCard(3, "Eldrazi Temple"),
            new SampleCard(1, "Island"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(2, "River of Tears"),
            new SampleCard(2, "Shelldock Isle"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Aether Gust"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Cry of the Carnarium"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(1, "Narset, Parter of Veils"),
            new SampleCard(1, "Negate"),
            new SampleCard(3, "Spreading Seas") 
        };
    }
}