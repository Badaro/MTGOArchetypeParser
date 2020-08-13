using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_07_13
{
    public class Deck13_Nekonii_Elves_GolgariElves_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Dwynen's Elite"),
            new SampleCard(4, "Elvish Archdruid"),
            new SampleCard(4, "Elvish Clancaller"),
            new SampleCard(4, "Elvish Mystic"),
            new SampleCard(3, "Ezuri, Renegade Leader"),
            new SampleCard(4, "Heritage Druid"),
            new SampleCard(4, "Llanowar Elves"),
            new SampleCard(4, "Nettle Sentinel"),
            new SampleCard(4, "Shaman of the Pack"),
            new SampleCard(4, "Winding Way"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(3, "Blooming Marsh"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(4, "Gilt-Leaf Palace"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(3, "Snow-Covered Forest") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(3, "Dismember"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(1, "Rhys the Exiled"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}