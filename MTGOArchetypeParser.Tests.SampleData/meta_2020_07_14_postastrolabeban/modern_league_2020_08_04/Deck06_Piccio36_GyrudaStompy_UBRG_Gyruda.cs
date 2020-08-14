using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck06_Piccio36_GyrudaStompy_UBRG_Gyruda : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(2, "Inferno Titan"),
            new SampleCard(1, "Kogla, the Titan Ape"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(1, "Sire of Insanity"),
            new SampleCard(4, "Solemn Simulacrum"),
            new SampleCard(3, "Wurmcoil Engine"),
            new SampleCard(4, "Explore"),
            new SampleCard(4, "Farseek"),
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(4, "Castle Garenbrig"),
            new SampleCard(3, "Cavern of Souls"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(4, "Gemstone Caverns"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(1, "Mosswort Bridge"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Boil"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Gyruda, Doom of Depths"),
            new SampleCard(4, "Leyline of the Void"),
            new SampleCard(2, "Pyroclasm"),
            new SampleCard(2, "Slaughter Games") 
        };
    }
}