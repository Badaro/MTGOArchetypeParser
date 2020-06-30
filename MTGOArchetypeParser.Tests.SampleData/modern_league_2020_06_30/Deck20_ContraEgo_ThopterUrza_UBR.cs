using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck20_ContraEgo_ThopterUrza_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Goblin Engineer"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(3, "Galvanic Blast"),
            new SampleCard(2, "Metallic Rebuke"),
            new SampleCard(3, "Whir of Invention"),
            new SampleCard(1, "Aether Spellbomb"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Pentad Prism"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Sword of the Meek"),
            new SampleCard(1, "Talisman of Dominance"),
            new SampleCard(4, "Thopter Foundry"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(1, "Flooded Strand"),
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
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Dreadbore"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(1, "Ghirapur Aether Grid"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Herald of Anguish"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(2, "Thoughtseize") 
        };
    }
}