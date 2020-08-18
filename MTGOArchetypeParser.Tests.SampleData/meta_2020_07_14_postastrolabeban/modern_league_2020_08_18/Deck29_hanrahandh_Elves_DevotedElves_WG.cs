using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck29_hanrahandh_Elves_DevotedElves_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Beast Whisperer"),
            new SampleCard(1, "Craterhoof Behemoth"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(4, "Elvish Mystic"),
            new SampleCard(3, "Elvish Visionary"),
            new SampleCard(4, "Heritage Druid"),
            new SampleCard(4, "Llanowar Elves"),
            new SampleCard(3, "Nettle Sentinel"),
            new SampleCard(2, "Vizier of Remedies"),
            new SampleCard(4, "Winding Way"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(4, "Leyline of Abundance"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(2, "Forest"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(2, "Nykthos, Shrine to Nyx"),
            new SampleCard(3, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Choke"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(4, "Relic of Progenitus") 
        };
    }
}