using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_showcase_last_chance_2020_08_12
{
    public class Deck02_CrusherBotBG_HammerTime_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Memnite"),
            new SampleCard(4, "Ornithopter"),
            new SampleCard(4, "Puresteel Paladin"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Steelshaper's Gift"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(3, "Colossus Hammer"),
            new SampleCard(2, "Cranial Plating"),
            new SampleCard(3, "Mishra's Bauble"),
            new SampleCard(2, "Paradise Mantle"),
            new SampleCard(1, "Shadowspear"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(2, "Welding Jar"),
            new SampleCard(1, "On Thin Ice"),
            new SampleCard(4, "Sigarda's Aid"),
            new SampleCard(1, "Castle Ardenvale"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(4, "Silent Clearing"),
            new SampleCard(10, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "On Thin Ice"),
            new SampleCard(3, "Burrenton Forge-Tender"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Disenchant"),
            new SampleCard(2, "Leyline of Sanctity"),
            new SampleCard(2, "Pithing Needle"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Sword of Sinew and Steel") 
        };
    }
}