using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_29
{
    public class Deck17_Littlemastercz_GruulEldrazi_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Domri, Anarch of Bolas"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(3, "Bonecrusher Giant"),
            new SampleCard(4, "Eldrazi Obligator"),
            new SampleCard(2, "Elvish Mystic"),
            new SampleCard(3, "Gruul Spellbreaker"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Questing Beast"),
            new SampleCard(4, "Reality Smasher"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Smuggler's Copter"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(2, "Forest"),
            new SampleCard(4, "Grove of the Burnwillows"),
            new SampleCard(4, "Karplusan Forest"),
            new SampleCard(1, "Kessig Wolf Run"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Alpine Moon"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Kitchen Finks"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(1, "Relic of Progenitus") 
        };
    }
}