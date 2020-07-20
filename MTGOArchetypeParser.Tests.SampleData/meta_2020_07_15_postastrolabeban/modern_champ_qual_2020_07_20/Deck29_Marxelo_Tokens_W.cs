using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20
{
    public class Deck29_Marxelo_Tokens_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Venerated Loxodon"),
            new SampleCard(3, "Battle Screech"),
            new SampleCard(4, "Gather the Townsfolk"),
            new SampleCard(2, "Servo Exhibition"),
            new SampleCard(4, "Spectral Procession"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Raise the Alarm"),
            new SampleCard(1, "Unbreakable Formation"),
            new SampleCard(4, "Force of Virtue"),
            new SampleCard(4, "Intangible Virtue"),
            new SampleCard(4, "Legion's Landing"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(11, "Plains"),
            new SampleCard(3, "Shefet Dunes"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(2, "Sunbaked Canyon"),
            new SampleCard(2, "Windbrisk Heights") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Unbreakable Formation"),
            new SampleCard(4, "Auriok Champion"),
            new SampleCard(2, "Conclave Tribunal"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(2, "Worship") 
        };
    }
}