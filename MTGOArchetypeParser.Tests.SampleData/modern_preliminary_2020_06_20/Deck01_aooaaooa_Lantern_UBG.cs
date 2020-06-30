using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck01_aooaaooa_Lantern_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Emry, Lurker of the Loch"),
            new SampleCard(2, "Simian Spirit Guide"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(4, "Whir of Invention"),
            new SampleCard(4, "Codex Shredder"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Ensnaring Bridge"),
            new SampleCard(1, "Ghoulcaller's Bell"),
            new SampleCard(4, "Lantern of Insight"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Pyxis of Pandemonium"),
            new SampleCard(1, "Soul-Guide Lantern"),
            new SampleCard(3, "Sword of the Meek"),
            new SampleCard(3, "Thopter Foundry"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(2, "Botanical Sanctum"),
            new SampleCard(4, "Darkslick Shores"),
            new SampleCard(4, "Glimmervoid"),
            new SampleCard(1, "Inventors' Fair"),
            new SampleCard(2, "Island"),
            new SampleCard(2, "River of Tears"),
            new SampleCard(4, "Spire of Industry") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Soul-Guide Lantern"),
            new SampleCard(1, "Bontu's Last Reckoning"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Leyline of Sanctity"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(1, "Tezzeret, Agent of Bolas"),
            new SampleCard(2, "Welding Jar") 
        };
    }
}