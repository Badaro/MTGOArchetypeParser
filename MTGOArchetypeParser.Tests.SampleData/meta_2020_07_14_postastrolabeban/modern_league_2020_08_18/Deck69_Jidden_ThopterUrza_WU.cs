using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck69_Jidden_ThopterUrza_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(2, "Sai, Master Thopterist"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(1, "Cryptic Command"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Whir of Invention"),
            new SampleCard(2, "Chromatic Star"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Mox Amber"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Sword of the Meek"),
            new SampleCard(2, "Talisman of Progress"),
            new SampleCard(3, "Thopter Foundry"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Glacial Fortress"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(1, "Lonely Sandbar"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Dispel"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Tormod's Crypt") 
        };
    }
}