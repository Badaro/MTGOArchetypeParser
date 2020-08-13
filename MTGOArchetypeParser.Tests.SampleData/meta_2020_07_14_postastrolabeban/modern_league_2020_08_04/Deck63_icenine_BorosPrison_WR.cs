using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck63_icenine_BorosPrison_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Goblin Dark-Dwellers"),
            new SampleCard(2, "Magus of the Tabernacle"),
            new SampleCard(4, "Boom // Bust"),
            new SampleCard(4, "Molten Rain"),
            new SampleCard(3, "Oust"),
            new SampleCard(4, "Pillage"),
            new SampleCard(4, "Stone Rain"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(4, "Mana Tithe"),
            new SampleCard(2, "Thrill of Possibility"),
            new SampleCard(3, "Ghostly Prison"),
            new SampleCard(3, "Suppression Field"),
            new SampleCard(2, "Battlefield Forge"),
            new SampleCard(3, "Cascading Cataracts"),
            new SampleCard(4, "Flagstones of Trokair"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(2, "Mountain"),
            new SampleCard(4, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ghostly Prison"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(1, "Suppression Field"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Boseiju, Who Shelters All"),
            new SampleCard(1, "Gemstone Caverns"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(3, "Trinisphere") 
        };
    }
}