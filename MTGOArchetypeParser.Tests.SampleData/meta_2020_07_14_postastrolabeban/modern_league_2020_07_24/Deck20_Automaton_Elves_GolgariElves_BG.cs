using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_24
{
    public class Deck20_Automaton_Elves_GolgariElves_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Dwynen's Elite"),
            new SampleCard(4, "Elvish Archdruid"),
            new SampleCard(4, "Elvish Champion"),
            new SampleCard(4, "Elvish Clancaller"),
            new SampleCard(4, "Elvish Mystic"),
            new SampleCard(2, "Ezuri, Renegade Leader"),
            new SampleCard(4, "Heritage Druid"),
            new SampleCard(4, "Imperious Perfect"),
            new SampleCard(4, "Llanowar Elves"),
            new SampleCard(4, "Shaman of the Pack"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(4, "Forest"),
            new SampleCard(4, "Gilt-Leaf Palace"),
            new SampleCard(4, "Nurturing Peatland"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(1, "Westvale Abbey") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(4, "Heroic Intervention"),
            new SampleCard(4, "Natural State"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}