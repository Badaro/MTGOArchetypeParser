using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck26_unicornparadise_Tokens_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Gideon, Ally of Zendikar"),
            new SampleCard(4, "Venerated Loxodon"),
            new SampleCard(3, "Battle Screech"),
            new SampleCard(4, "Gather the Townsfolk"),
            new SampleCard(2, "Servo Exhibition"),
            new SampleCard(4, "Spectral Procession"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Raise the Alarm"),
            new SampleCard(4, "Force of Virtue"),
            new SampleCard(4, "Intangible Virtue"),
            new SampleCard(4, "Legion's Landing"),
            new SampleCard(14, "Plains"),
            new SampleCard(2, "Shefet Dunes"),
            new SampleCard(1, "Silent Clearing"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Auriok Champion"),
            new SampleCard(4, "Damping Sphere"),
            new SampleCard(2, "Disenchant"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(2, "Unbreakable Formation") 
        };
    }
}