using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck53_Yanti_Bogles_WU_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Invisible Stalker"),
            new SampleCard(3, "Kor Spiritdancer"),
            new SampleCard(4, "Slippery Bogle"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(4, "Arcane Flight"),
            new SampleCard(4, "Curious Obsession"),
            new SampleCard(4, "Daybreak Coronet"),
            new SampleCard(4, "Ethereal Armor"),
            new SampleCard(4, "Hyena Umbra"),
            new SampleCard(2, "Spirit Mantle"),
            new SampleCard(3, "Staggering Insight"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(4, "Hallowed Fountain"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(3, "Plains"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(3, "Leyline of Sanctity"),
            new SampleCard(1, "Lurrus of the Dream Den"),
            new SampleCard(2, "Revoke Existence"),
            new SampleCard(2, "Silence"),
            new SampleCard(2, "Soul-Guide Lantern"),
            new SampleCard(2, "Suppression Field") 
        };
    }
}