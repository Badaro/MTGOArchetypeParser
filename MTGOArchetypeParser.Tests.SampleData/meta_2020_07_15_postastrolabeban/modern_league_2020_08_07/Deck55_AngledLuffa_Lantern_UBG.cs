using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck55_AngledLuffa_Lantern_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(1, "Mastermind's Acquisition"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(4, "Codex Shredder"),
            new SampleCard(1, "Crucible of Worlds"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(4, "Ensnaring Bridge"),
            new SampleCard(1, "Ghoulcaller's Bell"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(4, "Lantern of Insight"),
            new SampleCard(2, "Pithing Needle"),
            new SampleCard(2, "Pyxis of Pandemonium"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(1, "Welding Jar"),
            new SampleCard(2, "Academy Ruins"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(4, "Glimmervoid"),
            new SampleCard(1, "Indatha Triome"),
            new SampleCard(2, "Inventors' Fair"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(2, "Spire of Industry"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Welding Jar"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(1, "Phyrexian Revoker"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(2, "Unmoored Ego"),
            new SampleCard(1, "Unravel the Aether"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}