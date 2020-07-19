using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_06_30
{
    public class Deck18_Heiring_Tokens_OrzhovTokens_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(1, "Sorin, Solemn Visitor"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Tidehollow Sculler"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Lingering Souls"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Bitterblossom"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(2, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(2, "Shambling Vent"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(1, "Urborg, Tomb of Yawgmoth"),
            new SampleCard(2, "Windbrisk Heights") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(3, "Duress"),
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(2, "Wrath of God") 
        };
    }
}