using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_16
{
    public class Deck18_Delthar_Mill_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Archive Trap"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Crypt Incursion"),
            new SampleCard(4, "Drown in the Loch"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(4, "Surgical Extraction"),
            new SampleCard(4, "Visions of Beyond"),
            new SampleCard(4, "Mesmeric Orb"),
            new SampleCard(2, "Fraying Sanity"),
            new SampleCard(2, "Darkslick Shores"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(3, "Island"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Prismatic Vista"),
            new SampleCard(2, "Shelldock Isle"),
            new SampleCard(2, "Swamp"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(2, "Echoing Truth"),
            new SampleCard(2, "Ensnaring Bridge"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(1, "Set Adrift") 
        };
    }
}