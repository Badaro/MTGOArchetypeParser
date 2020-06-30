using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck17_stainerson_Elves_GolgariElves_BG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Dwynen's Elite"),(2, "Elves of Deep Shadow"),(4, "Elvish Archdruid"),(3, "Elvish Clancaller"),(4, "Elvish Mystic"),(2, "Ezuri, Renegade Leader"),(4, "Heritage Druid"),(4, "Llanowar Elves"),(2, "Nettle Sentinel"),(4, "Shaman of the Pack"),(4, "Winding Way"),(4, "Collected Company"),(4, "Blooming Marsh"),(3, "Forest"),(4, "Gilt-Leaf Palace"),(3, "Llanowar Wastes"),(4, "Nurturing Peatland"),(1, "Pendelhaven") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Assassin's Trophy"),(2, "Choke"),(3, "Collector Ouphe"),(3, "Damping Sphere"),(4, "Yixlid Jailer") }; } }
    }
}