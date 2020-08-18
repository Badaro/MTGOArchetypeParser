using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck22_sfitz_ThopterUrza_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Emry, Lurker of the Loch"),
            new SampleCard(4, "Goblin Engineer"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(3, "Galvanic Blast"),
            new SampleCard(2, "Metallic Rebuke"),
            new SampleCard(4, "Whir of Invention"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Sword of the Meek"),
            new SampleCard(1, "Talisman of Dominance"),
            new SampleCard(4, "Thopter Foundry"),
            new SampleCard(4, "Witching Well"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Metallic Rebuke"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(1, "Aether Gust"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Pyrite Spellbomb"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(2, "Tezzeret, Agent of Bolas") 
        };
    }
}