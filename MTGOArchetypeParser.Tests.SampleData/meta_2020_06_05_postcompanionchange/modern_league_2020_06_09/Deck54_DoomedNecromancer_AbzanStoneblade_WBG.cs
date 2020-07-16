using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_09
{
    public class Deck54_DoomedNecromancer_AbzanStoneblade_WBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Siege Rhino"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Voice of Resurgence"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Lingering Souls"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(4, "Assassin's Trophy"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Sword of Light and Shadow"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Gavony Township"),
            new SampleCard(1, "Indatha Triome"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(2, "Plains"),
            new SampleCard(1, "Stirring Wildwood"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Choke"),
            new SampleCard(1, "Damnation"),
            new SampleCard(2, "Eidolon of Rhetoric"),
            new SampleCard(1, "Elspeth, Sun's Champion"),
            new SampleCard(1, "Fracturing Gust"),
            new SampleCard(2, "Gaddock Teeg"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Stony Silence") 
        };
    }
}