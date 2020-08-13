using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck03_cccaspar_WhiteDevotion_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Elspeth, Sun's Champion"),
            new SampleCard(4, "Auriok Champion"),
            new SampleCard(2, "Daxos, Blessed by the Sun"),
            new SampleCard(3, "Giver of Runes"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(2, "Knight of the White Orchid"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(4, "Weathered Wayfarer"),
            new SampleCard(4, "Fieldmist Borderpost"),
            new SampleCard(3, "Wildfield Borderpost"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(4, "Mastery of the Unseen"),
            new SampleCard(3, "Runed Halo"),
            new SampleCard(4, "Nykthos, Shrine to Nyx"),
            new SampleCard(14, "Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Runed Halo"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(4, "Grand Abolisher"),
            new SampleCard(2, "Leonin Relic-Warder"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(1, "Worship") 
        };
    }
}