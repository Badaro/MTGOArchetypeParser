using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_09
{
    public class Deck23_ContraEgo_ThopterUrza_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Goblin Engineer"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(4, "Metallic Rebuke"),
            new SampleCard(3, "Whir of Invention"),
            new SampleCard(1, "Aether Spellbomb"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Pentad Prism"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Pyrite Spellbomb"),
            new SampleCard(2, "Sword of the Meek"),
            new SampleCard(1, "Talisman of Dominance"),
            new SampleCard(4, "Thopter Foundry"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(7, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Ashiok, Nightmare Muse"),
            new SampleCard(1, "Cryptic Command"),
            new SampleCard(1, "Dead of Winter"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Dreadbore"),
            new SampleCard(1, "Drown in the Loch"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(2, "Galvanic Blast"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Herald of Anguish"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(1, "Tezzeret, Agent of Bolas") 
        };
    }
}