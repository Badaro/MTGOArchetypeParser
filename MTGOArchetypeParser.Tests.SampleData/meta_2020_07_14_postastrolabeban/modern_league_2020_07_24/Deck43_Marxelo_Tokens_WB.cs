using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_24
{
    public class Deck43_Marxelo_Tokens_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Venerated Loxodon"),
            new SampleCard(4, "Gather the Townsfolk"),
            new SampleCard(4, "Lingering Souls"),
            new SampleCard(2, "Servo Exhibition"),
            new SampleCard(4, "Spectral Procession"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Raise the Alarm"),
            new SampleCard(4, "Force of Virtue"),
            new SampleCard(4, "Intangible Virtue"),
            new SampleCard(4, "Legion's Landing"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(9, "Plains"),
            new SampleCard(3, "Shefet Dunes"),
            new SampleCard(4, "Silent Clearing"),
            new SampleCard(2, "Windbrisk Heights") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Auriok Champion"),
            new SampleCard(2, "Conclave Tribunal"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(3, "Stony Silence"),
            new SampleCard(2, "Sundering Growth") 
        };
    }
}