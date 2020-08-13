using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_14
{
    public class Deck37_TheNobodys_ThopterUrza_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(3, "Emry, Lurker of the Loch"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(2, "Battle at the Bridge"),
            new SampleCard(4, "Whir of Invention"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(2, "Chromatic Star"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Soul-Guide Lantern"),
            new SampleCard(2, "Sword of the Meek"),
            new SampleCard(4, "Thopter Foundry"),
            new SampleCard(1, "Darkslick Shores"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(1, "Seachrome Coast"),
            new SampleCard(7, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Battle at the Bridge"),
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(2, "Anguished Unmaking"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Dead of Winter"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(3, "Spell Pierce"),
            new SampleCard(1, "Unmoored Ego") 
        };
    }
}