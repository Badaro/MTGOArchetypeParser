using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16
{
    public class Deck26_shine0905_GyrudaStompy_BRG_Gyruda : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Inferno Titan"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(1, "Ruric Thar, the Unbowed"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(2, "Sire of Insanity"),
            new SampleCard(4, "Sylvan Caryatid"),
            new SampleCard(3, "Wurmcoil Engine"),
            new SampleCard(4, "Explore"),
            new SampleCard(2, "Mwonvuli Acid-Moss"),
            new SampleCard(1, "Deathsprout"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(4, "Castle Garenbrig"),
            new SampleCard(3, "Cavern of Souls"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(4, "Gemstone Caverns"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Mosswort Bridge"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(2, "Boil"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Gyruda, Doom of Depths"),
            new SampleCard(2, "Pyroclasm"),
            new SampleCard(2, "Slaughter Games") 
        };
    }
}