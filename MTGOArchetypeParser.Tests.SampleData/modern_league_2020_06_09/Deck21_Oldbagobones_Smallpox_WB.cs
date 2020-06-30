using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck21_Oldbagobones_Smallpox_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Elspeth, Sun's Nemesis"),
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Lingering Souls"),
            new SampleCard(4, "Smallpox"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Kaya's Guile"),
            new SampleCard(1, "Mana Tithe"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(2, "Fetid Heath"),
            new SampleCard(4, "Flagstones of Trokair"),
            new SampleCard(3, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Shambling Vent"),
            new SampleCard(3, "Silent Clearing"),
            new SampleCard(3, "Swamp"),
            new SampleCard(3, "Urborg, Tomb of Yawgmoth") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Kaya's Guile"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(4, "Fulminator Mage"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(3, "Plague Engineer"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(2, "Vampire Hexmage") 
        };
    }
}