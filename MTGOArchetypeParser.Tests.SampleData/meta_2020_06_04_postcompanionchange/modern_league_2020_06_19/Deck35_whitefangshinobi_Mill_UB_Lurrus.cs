using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_19
{
    public class Deck35_whitefangshinobi_Mill_UB_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(1, "Jace, Vryn's Prodigy"),
            new SampleCard(4, "Jace's Phantasm"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Archive Trap"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(3, "Surgical Extraction"),
            new SampleCard(4, "Visions of Beyond"),
            new SampleCard(4, "Mesmeric Orb"),
            new SampleCard(1, "Darkslick Shores"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Shelldock Isle"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(3, "Crypt Incursion"),
            new SampleCard(2, "Damnation"),
            new SampleCard(2, "Echoing Truth"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(1, "Set Adrift"),
            new SampleCard(1, "Torpor Orb"),
            new SampleCard(1, "Unmoored Ego") 
        };
    }
}