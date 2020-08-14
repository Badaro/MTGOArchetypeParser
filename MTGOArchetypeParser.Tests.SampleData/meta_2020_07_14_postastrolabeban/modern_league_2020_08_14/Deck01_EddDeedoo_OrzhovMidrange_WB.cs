using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck01_EddDeedoo_OrzhovMidrange_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(4, "Dark Confidant"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Tidehollow Sculler"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(3, "Lingering Souls"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(1, "Anguished Unmaking"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(2, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(2, "Shambling Vent"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(4, "Snow-Covered Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Cry of the Carnarium"),
            new SampleCard(2, "Damnation"),
            new SampleCard(1, "Despark"),
            new SampleCard(1, "Disenchant"),
            new SampleCard(1, "Elspeth, Sun's Nemesis"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(1, "Kaya's Guile") 
        };
    }
}