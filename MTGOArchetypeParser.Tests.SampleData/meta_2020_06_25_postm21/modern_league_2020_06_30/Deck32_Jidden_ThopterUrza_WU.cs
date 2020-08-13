using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_06_30
{
    public class Deck32_Jidden_ThopterUrza_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Deprive"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(3, "Whir of Invention"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(1, "Sword of the Meek"),
            new SampleCard(3, "Talisman of Progress"),
            new SampleCard(3, "Thopter Foundry"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(2, "Lonely Sandbar"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Dispel"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Leyline of Sanctity"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(2, "Timely Reinforcements") 
        };
    }
}