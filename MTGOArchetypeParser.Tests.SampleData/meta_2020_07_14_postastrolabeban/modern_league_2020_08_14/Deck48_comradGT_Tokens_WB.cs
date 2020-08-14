using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck48_comradGT_Tokens_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Signal Pest"),
            new SampleCard(4, "Venerated Loxodon"),
            new SampleCard(4, "Gather the Townsfolk"),
            new SampleCard(4, "Lingering Souls"),
            new SampleCard(2, "Servo Exhibition"),
            new SampleCard(4, "Spectral Procession"),
            new SampleCard(4, "Raise the Alarm"),
            new SampleCard(4, "Force of Virtue"),
            new SampleCard(4, "Intangible Virtue"),
            new SampleCard(4, "Legion's Landing"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(12, "Plains"),
            new SampleCard(2, "Shefet Dunes"),
            new SampleCard(4, "Silent Clearing") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Auriok Champion"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Stony Silence"),
            new SampleCard(2, "Sundering Growth") 
        };
    }
}