using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_07
{
    public class Deck42_DFrank_ThopterUrza_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(3, "Whir of Invention"),
            new SampleCard(2, "Aether Spellbomb"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Executioner's Capsule"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Mox Amber"),
            new SampleCard(1, "Necrogen Spellbomb"),
            new SampleCard(2, "Pithing Needle"),
            new SampleCard(2, "Sword of the Meek"),
            new SampleCard(4, "Thopter Foundry"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(3, "Prismatic Vista"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(3, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(2, "Deprive"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Monastery Mentor"),
            new SampleCard(3, "Spell Pierce"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Torpor Orb") 
        };
    }
}