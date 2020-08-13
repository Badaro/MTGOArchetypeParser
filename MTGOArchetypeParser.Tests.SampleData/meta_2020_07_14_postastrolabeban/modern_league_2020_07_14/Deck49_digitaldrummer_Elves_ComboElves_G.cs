using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_14
{
    public class Deck49_digitaldrummer_Elves_ComboElves_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Beast Whisperer"),
            new SampleCard(2, "Boreal Druid"),
            new SampleCard(1, "Craterhoof Behemoth"),
            new SampleCard(4, "Dwynen's Elite"),
            new SampleCard(4, "Elvish Archdruid"),
            new SampleCard(4, "Elvish Clancaller"),
            new SampleCard(4, "Elvish Mystic"),
            new SampleCard(4, "Elvish Visionary"),
            new SampleCard(4, "Heritage Druid"),
            new SampleCard(4, "Llanowar Elves"),
            new SampleCard(4, "Nettle Sentinel"),
            new SampleCard(4, "Commune with Nature"),
            new SampleCard(15, "Forest"),
            new SampleCard(3, "Nykthos, Shrine to Nyx") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Collected Company"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Elvish Champion"),
            new SampleCard(3, "Essence Warden"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Thorn of Amethyst") 
        };
    }
}