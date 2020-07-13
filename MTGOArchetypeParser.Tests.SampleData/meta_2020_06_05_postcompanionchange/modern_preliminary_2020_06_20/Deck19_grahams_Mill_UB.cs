using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20
{
    public class Deck19_grahams_Mill_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(4, "Jace's Phantasm"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Archive Trap"),
            new SampleCard(3, "Drown in the Loch"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(1, "Mission Briefing"),
            new SampleCard(3, "Surgical Extraction"),
            new SampleCard(4, "Visions of Beyond"),
            new SampleCard(4, "Mesmeric Orb"),
            new SampleCard(2, "Darkslick Shores"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(3, "Island"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Shelldock Isle"),
            new SampleCard(2, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Drown in the Loch"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Crypt Incursion"),
            new SampleCard(1, "Damnation"),
            new SampleCard(2, "Echoing Truth"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(3, "Profane Memento"),
            new SampleCard(1, "Torpor Orb") 
        };
    }
}