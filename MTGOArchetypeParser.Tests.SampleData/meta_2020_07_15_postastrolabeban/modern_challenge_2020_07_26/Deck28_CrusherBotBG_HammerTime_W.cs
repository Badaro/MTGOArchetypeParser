using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_26
{
    public class Deck28_CrusherBotBG_HammerTime_W : ISampleDeck
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
            new SampleCard(2, "On Thin Ice"),
            new SampleCard(3, "Burrenton Forge-Tender"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Disenchant"),
            new SampleCard(3, "Pithing Needle"),
            new SampleCard(2, "Relic of Progenitus") 
        };
    }
}