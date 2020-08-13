using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_24
{
    public class Deck07_tia05_PrimevalTitan_TitanShift_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arboreal Grazer"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(2, "Radha, Heart of Keld"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(2, "Scapeshift"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(3, "Summoner's Pact"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(4, "Castle Garenbrig"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Cinder Glade"),
            new SampleCard(1, "Dwarven Mine"),
            new SampleCard(3, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Sheltered Thicket"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(3, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(1, "Vesuva"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Courser of Kruphix"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(2, "Seal of Primordium"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}