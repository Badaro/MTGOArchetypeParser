using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_14
{
    public class Deck21_Kurusu_KikiChord_WURG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(1, "Corridor Monitor"),
            new SampleCard(2, "Eternal Witness"),
            new SampleCard(1, "Ethersworn Canonist"),
            new SampleCard(2, "Gilded Goose"),
            new SampleCard(1, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(1, "Phyrexian Revoker"),
            new SampleCard(1, "Prime Speaker Vannifar"),
            new SampleCard(1, "Renegade Rallier"),
            new SampleCard(4, "Restoration Angel"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Tribute Mage"),
            new SampleCard(4, "Voice of Resurgence"),
            new SampleCard(1, "Wall of Roots"),
            new SampleCard(3, "Eldritch Evolution"),
            new SampleCard(4, "Chord of Calling"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(3, "Utopia Sprawl"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(2, "Grove of the Burnwillows"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(1, "Raugrin Triome"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Eternal Witness"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(2, "Fiery Justice"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}