using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck18_Heiring_Tokens_WB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Gideon, Ally of Zendikar"),(4, "Liliana of the Veil"),(1, "Sorin, Solemn Visitor"),(4, "Stoneforge Mystic"),(4, "Tidehollow Sculler"),(4, "Inquisition of Kozilek"),(4, "Lingering Souls"),(2, "Thoughtseize"),(3, "Fatal Push"),(3, "Path to Exile"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(1, "Sword of Fire and Ice"),(4, "Bitterblossom"),(4, "Concealed Courtyard"),(2, "Field of Ruin"),(2, "Godless Shrine"),(4, "Marsh Flats"),(2, "Shambling Vent"),(2, "Silent Clearing"),(2, "Snow-Covered Plains"),(2, "Snow-Covered Swamp"),(1, "Urborg, Tomb of Yawgmoth"),(2, "Windbrisk Heights") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Collective Brutality"),(3, "Duress"),(2, "Kaya's Guile"),(1, "Liliana, the Last Hope"),(3, "Relic of Progenitus"),(2, "Timely Reinforcements"),(2, "Wrath of God") }; } }
    }
}