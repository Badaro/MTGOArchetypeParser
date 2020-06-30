using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck11_alnash_SnowControl_SnowTitan_UBG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Tamiyo, Collector of Tales"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Primeval Titan"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(2, "Thragtusk"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Venser, Shaper Savant"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(3, "Remand"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(4, "Breeding Pool"),
            new SampleCard(1, "Castle Vantress"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(1, "Flooded Grove"),
            new SampleCard(2, "Hinterland Harbor"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(7, "Snow-Covered Island"),
            new SampleCard(2, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Nature's Claim"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(2, "Tireless Tracker"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}