using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck28_Pirika_MarduPyromancer_WBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Kaya, Orzhov Usurper"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Young Pyromancer"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Lingering Souls"),
            new SampleCard(2, "Ransack the Lab"),
            new SampleCard(4, "Smallpox"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Cling to Dust"),
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Castle Locthwain"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Urborg, Tomb of Yawgmoth") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Bedevil"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(3, "Ensnaring Bridge"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Nihil Spellbomb") 
        };
    }
}