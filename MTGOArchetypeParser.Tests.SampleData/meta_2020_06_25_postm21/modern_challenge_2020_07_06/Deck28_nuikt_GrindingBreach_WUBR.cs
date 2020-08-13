using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_07_06
{
    public class Deck28_nuikt_GrindingBreach_WUBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(1, "Thassa's Oracle"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(2, "Unearth"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Chromatic Star"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(4, "Grinding Station"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Mox Amber"),
            new SampleCard(1, "Pyrite Spellbomb"),
            new SampleCard(2, "Seal of Fire"),
            new SampleCard(4, "Underworld Breach"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Minamo, School at Water's Edge"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Urborg, Tomb of Yawgmoth"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(3, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(1, "Tormod's Crypt") 
        };
    }
}