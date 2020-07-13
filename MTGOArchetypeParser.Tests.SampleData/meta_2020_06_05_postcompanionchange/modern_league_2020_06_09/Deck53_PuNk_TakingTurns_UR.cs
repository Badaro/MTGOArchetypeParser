using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_09
{
    public class Deck53_PuNk_TakingTurns_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(4, "Ancestral Vision"),
            new SampleCard(4, "Temporal Mastery"),
            new SampleCard(4, "Time Warp"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(6, "Island"),
            new SampleCard(1, "Mikokoro, Center of the Sea"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(2, "Sulfur Falls") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Aether Gust"),
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Electrolyze"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(2, "Pyroclasm"),
            new SampleCard(2, "Soul-Guide Lantern"),
            new SampleCard(1, "Teferi, Mage of Zhalfir") 
        };
    }
}