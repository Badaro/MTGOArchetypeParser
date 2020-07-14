using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_14
{
    public class Deck06_Trellon_GTron_OrreryTron_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(3, "Kiora, Behemoth Beckoner"),
            new SampleCard(3, "Filigree Sages"),
            new SampleCard(4, "Vizier of Tumbling Sands"),
            new SampleCard(3, "Walking Ballista"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Sylvan Scrying"),
            new SampleCard(3, "Chromatic Orrery"),
            new SampleCard(4, "Chromatic Sphere"),
            new SampleCard(4, "Chromatic Star"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(4, "Botanical Sanctum"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Tolaria West"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Filigree Sages"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Chromatic Orrery"),
            new SampleCard(3, "Defense Grid"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Platinum Angel"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(1, "Spine of Ish Sah"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Welding Jar") 
        };
    }
}