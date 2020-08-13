using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_06_29
{
    public class Deck17_stainerson_Elves_GolgariElves_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Dwynen's Elite"),
            new SampleCard(2, "Elves of Deep Shadow"),
            new SampleCard(4, "Elvish Archdruid"),
            new SampleCard(3, "Elvish Clancaller"),
            new SampleCard(4, "Elvish Mystic"),
            new SampleCard(2, "Ezuri, Renegade Leader"),
            new SampleCard(4, "Heritage Druid"),
            new SampleCard(4, "Llanowar Elves"),
            new SampleCard(2, "Nettle Sentinel"),
            new SampleCard(4, "Shaman of the Pack"),
            new SampleCard(4, "Winding Way"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(3, "Forest"),
            new SampleCard(4, "Gilt-Leaf Palace"),
            new SampleCard(3, "Llanowar Wastes"),
            new SampleCard(4, "Nurturing Peatland"),
            new SampleCard(1, "Pendelhaven") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(2, "Choke"),
            new SampleCard(3, "Collector Ouphe"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(4, "Yixlid Jailer") 
        };
    }
}