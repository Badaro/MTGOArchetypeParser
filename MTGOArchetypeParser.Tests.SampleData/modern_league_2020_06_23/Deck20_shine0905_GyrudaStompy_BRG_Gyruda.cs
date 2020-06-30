using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck20_shine0905_GyrudaStompy_BRG_Gyruda : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Chandra, Torch of Defiance"),(2, "Inferno Titan"),(1, "Kogla, the Titan Ape"),(4, "Primeval Titan"),(4, "Sakura-Tribe Elder"),(2, "Sire of Insanity"),(3, "Wurmcoil Engine"),(4, "Explore"),(4, "Farseek"),(3, "Mwonvuli Acid-Moss"),(3, "Chalice of the Void"),(1, "Blast Zone"),(1, "Blood Crypt"),(1, "Bojuka Bog"),(4, "Castle Garenbrig"),(3, "Cavern of Souls"),(2, "Field of the Dead"),(2, "Forest"),(4, "Gemstone Caverns"),(1, "Ghost Quarter"),(1, "Mosswort Bridge"),(1, "Overgrown Tomb"),(1, "Radiant Fountain"),(1, "Snow-Covered Forest"),(1, "Snow-Covered Swamp"),(2, "Stomping Ground"),(1, "Swamp"),(2, "Verdant Catacombs") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Cavern of Souls"),(1, "Radiant Fountain"),(1, "Chalice of the Void"),(2, "Boil"),(1, "Collector Ouphe"),(2, "Damping Sphere"),(2, "Engineered Explosives"),(1, "Gyruda, Doom of Depths"),(2, "Pyroclasm"),(2, "Ravenous Trap") }; } }
    }
}