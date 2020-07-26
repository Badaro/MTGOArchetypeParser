using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05
{
    public class Deck20_wambocombo2020_JundSmallpox_BRG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(2, "Chevill, Bane of Monsters"),
            new SampleCard(3, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Crack the Earth"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Smallpox"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(2, "Unearth"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(3, "Seal of Fire"),
            new SampleCard(1, "Barren Moor"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(2, "Prismatic Vista"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Boil"),
            new SampleCard(1, "Cindervines"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(3, "Pillage"),
            new SampleCard(1, "Veil of Summer"),
            new SampleCard(1, "Weather the Storm") 
        };
    }
}