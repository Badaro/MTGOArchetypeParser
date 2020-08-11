using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck54_DethFrmAbove_Tokens_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(4, "Gather the Townsfolk"),
            new SampleCard(3, "Lingering Souls"),
            new SampleCard(2, "Servo Exhibition"),
            new SampleCard(4, "Spectral Procession"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Raise the Alarm"),
            new SampleCard(4, "Force of Virtue"),
            new SampleCard(4, "Intangible Virtue"),
            new SampleCard(4, "Legion's Landing"),
            new SampleCard(4, "Leyline of the Meek"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(9, "Plains"),
            new SampleCard(3, "Shefet Dunes"),
            new SampleCard(4, "Silent Clearing"),
            new SampleCard(2, "Windbrisk Heights") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Auriok Champion"),
            new SampleCard(1, "Conclave Tribunal"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(3, "Stony Silence"),
            new SampleCard(2, "Sundering Growth") 
        };
    }
}