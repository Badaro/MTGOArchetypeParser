using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_03
{
    public class Deck16_mrounds1216_Elves_GolgariElves_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Beast Whisperer"),
            new SampleCard(4, "Dwynen's Elite"),
            new SampleCard(2, "Elves of Deep Shadow"),
            new SampleCard(4, "Elvish Archdruid"),
            new SampleCard(3, "Elvish Clancaller"),
            new SampleCard(4, "Elvish Mystic"),
            new SampleCard(1, "Ezuri, Renegade Leader"),
            new SampleCard(4, "Heritage Druid"),
            new SampleCard(4, "Llanowar Elves"),
            new SampleCard(2, "Nettle Sentinel"),
            new SampleCard(4, "Shaman of the Pack"),
            new SampleCard(4, "Winding Way"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(3, "Forest"),
            new SampleCard(4, "Gilt-Leaf Palace"),
            new SampleCard(4, "Nurturing Peatland"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(1, "Westvale Abbey") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Reclamation Sage"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(2, "Stain the Mind"),
            new SampleCard(2, "Thoughtseize") 
        };
    }
}