using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_21
{
    public class Deck06_FabriceK_GruulEldrazi_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(3, "Bonecrusher Giant"),
            new SampleCard(4, "Eldrazi Obligator"),
            new SampleCard(4, "Matter Reshaper"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Questing Beast"),
            new SampleCard(4, "Reality Smasher"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(1, "Flame Slash"),
            new SampleCard(1, "Dismember"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(4, "Grove of the Burnwillows"),
            new SampleCard(4, "Karplusan Forest"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Wastes"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Dismember"),
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(2, "Alpine Moon"),
            new SampleCard(1, "Boil"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(1, "Destructive Revelry"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Weather the Storm") 
        };
    }
}