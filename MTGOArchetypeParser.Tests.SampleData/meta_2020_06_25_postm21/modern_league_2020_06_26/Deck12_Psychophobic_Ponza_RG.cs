using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_06_26
{
    public class Deck12_Psychophobic_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Domri, Anarch of Bolas"),
            new SampleCard(2, "Kiora, Behemoth Beckoner"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(1, "Birds of Paradise"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(4, "Bonecrusher Giant"),
            new SampleCard(2, "Glorybringer"),
            new SampleCard(2, "Klothys, God of Destiny"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(2, "Ox of Agonas"),
            new SampleCard(1, "Questing Beast"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Vengevine"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(8, "Forest"),
            new SampleCard(1, "Kessig Wolf Run"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Cindervines"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(1, "Fracturing Gust"),
            new SampleCard(2, "Obstinate Baloth"),
            new SampleCard(1, "Ruric Thar, the Unbowed"),
            new SampleCard(2, "Slagstorm"),
            new SampleCard(2, "Trinisphere"),
            new SampleCard(3, "Wheel of Sun and Moon") 
        };
    }
}