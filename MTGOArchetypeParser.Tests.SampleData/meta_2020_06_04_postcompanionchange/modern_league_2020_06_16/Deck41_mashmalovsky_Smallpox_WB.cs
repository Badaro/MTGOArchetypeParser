using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_16
{
    public class Deck41_mashmalovsky_Smallpox_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Elspeth, Sun's Nemesis"),
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Lingering Souls"),
            new SampleCard(4, "Smallpox"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Castle Locthwain"),
            new SampleCard(2, "Fetid Heath"),
            new SampleCard(4, "Flagstones of Trokair"),
            new SampleCard(3, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Shambling Vent"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(3, "Swamp"),
            new SampleCard(3, "Urborg, Tomb of Yawgmoth") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Kaya's Guile"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Damnation"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Disenchant"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}