using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck53_Nekonii_Elves_GolgariElves_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(4, "Dwynen's Elite"),
            new SampleCard(4, "Elvish Archdruid"),
            new SampleCard(4, "Elvish Clancaller"),
            new SampleCard(4, "Elvish Mystic"),
            new SampleCard(3, "Ezuri, Renegade Leader"),
            new SampleCard(4, "Heritage Druid"),
            new SampleCard(4, "Llanowar Elves"),
            new SampleCard(4, "Shaman of the Pack"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(3, "Leyline of Abundance"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(4, "Gilt-Leaf Palace"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(5, "Snow-Covered Forest") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(3, "Dismember"),
            new SampleCard(2, "Reclamation Sage"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}