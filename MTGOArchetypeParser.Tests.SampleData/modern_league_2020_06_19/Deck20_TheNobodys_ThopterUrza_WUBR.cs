using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck20_TheNobodys_ThopterUrza_WUBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(3, "Goblin Engineer"),
            new SampleCard(3, "Lurrus of the Dream Den"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(3, "Whir of Invention"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Mox Amber"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Pyrite Spellbomb"),
            new SampleCard(1, "Sword of the Meek"),
            new SampleCard(4, "Thopter Foundry"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Battle at the Bridge"),
            new SampleCard(1, "Blood Moon"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(3, "Light of Hope"),
            new SampleCard(1, "Seal of Fire"),
            new SampleCard(3, "Spell Pierce") 
        };
    }
}