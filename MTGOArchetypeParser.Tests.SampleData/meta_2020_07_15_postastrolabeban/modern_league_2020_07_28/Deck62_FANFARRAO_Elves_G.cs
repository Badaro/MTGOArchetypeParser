using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck62_FANFARRAO_Elves_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Dwynen's Elite"),
            new SampleCard(4, "Elvish Archdruid"),
            new SampleCard(4, "Elvish Champion"),
            new SampleCard(4, "Elvish Clancaller"),
            new SampleCard(4, "Elvish Mystic"),
            new SampleCard(2, "Ezuri, Renegade Leader"),
            new SampleCard(4, "Heritage Druid"),
            new SampleCard(4, "Imperious Perfect"),
            new SampleCard(4, "Llanowar Elves"),
            new SampleCard(4, "Lead the Stampede"),
            new SampleCard(18, "Forest") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(4, "Heroic Intervention"),
            new SampleCard(4, "Reclamation Sage"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}