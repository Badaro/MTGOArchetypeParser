using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_22
{
    public class Deck09_DarthMalak_Smallpox_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(2, "Liliana, the Last Hope"),
            new SampleCard(3, "Liliana, Waker of the Dead"),
            new SampleCard(4, "Bloodghast"),
            new SampleCard(3, "Murderous Rider"),
            new SampleCard(4, "Lingering Souls"),
            new SampleCard(2, "Raven's Crime"),
            new SampleCard(4, "Smallpox"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Ensnaring Bridge"),
            new SampleCard(2, "Blast Zone"),
            new SampleCard(2, "Castle Locthwain"),
            new SampleCard(4, "Flagstones of Trokair"),
            new SampleCard(4, "Godless Shrine"),
            new SampleCard(1, "Plains"),
            new SampleCard(7, "Swamp"),
            new SampleCard(4, "Urborg, Tomb of Yawgmoth") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(2, "Damnation"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Stony Silence"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}