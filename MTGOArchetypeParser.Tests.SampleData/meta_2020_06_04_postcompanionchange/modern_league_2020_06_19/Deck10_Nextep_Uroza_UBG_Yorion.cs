using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_19
{
    public class Deck10_Nextep_Uroza_UBG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(4, "Gilded Goose"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Metallic Rebuke"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Engineered Explosives"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(4, "Abundant Growth"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(3, "Prismatic Vista"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}