using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_07_13
{
    public class Deck02_sfitz_ThopterUrza_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Emry, Lurker of the Loch"),
            new SampleCard(4, "Goblin Engineer"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(3, "Galvanic Blast"),
            new SampleCard(3, "Metallic Rebuke"),
            new SampleCard(4, "Whir of Invention"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Sword of the Meek"),
            new SampleCard(1, "Talisman of Dominance"),
            new SampleCard(4, "Thopter Foundry"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(7, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Metallic Rebuke"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(2, "Tezzeret, Agent of Bolas") 
        };
    }
}