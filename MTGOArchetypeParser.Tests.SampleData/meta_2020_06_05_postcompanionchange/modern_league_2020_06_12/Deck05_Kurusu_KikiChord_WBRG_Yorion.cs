using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_12
{
    public class Deck05_Kurusu_KikiChord_WBRG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(2, "Eternal Witness"),
            new SampleCard(1, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(4, "Restoration Angel"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Voice of Resurgence"),
            new SampleCard(1, "Wall of Roots"),
            new SampleCard(4, "Eldritch Evolution"),
            new SampleCard(4, "Chord of Calling"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(1, "Grove of the Burnwillows"),
            new SampleCard(1, "Indatha Triome"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(3, "Prismatic Vista"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(1, "Savai Triome"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Fiery Justice"),
            new SampleCard(3, "Kaya's Guile"),
            new SampleCard(1, "Siege Rhino"),
            new SampleCard(1, "Sin Collector"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}