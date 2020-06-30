using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck21_RockStar_Prowess_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abbot of Keral Keep"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(1, "Crash Through"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(2, "Unearth"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Seal of Fire"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(3, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(3, "Sunbaked Canyon"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Angrath's Rampage"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(3, "Molten Rain"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}