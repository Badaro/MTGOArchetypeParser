using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07
{
    public class Deck11_Kurusu_KikiChord_WRG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(2, "Eternal Witness"),
            new SampleCard(2, "Gilded Goose"),
            new SampleCard(1, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(4, "Restoration Angel"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Voice of Resurgence"),
            new SampleCard(4, "Wall of Blossoms"),
            new SampleCard(2, "Eldritch Evolution"),
            new SampleCard(4, "Chord of Calling"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(1, "Grove of the Burnwillows"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(2, "Prismatic Vista"),
            new SampleCard(1, "Razorverge Thicket"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(1, "Sunbaked Canyon"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Boil"),
            new SampleCard(3, "Fiery Justice"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}