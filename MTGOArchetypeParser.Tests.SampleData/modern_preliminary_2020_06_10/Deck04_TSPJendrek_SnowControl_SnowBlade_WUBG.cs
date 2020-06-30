using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10
{
    public class Deck04_TSPJendrek_SnowControl_SnowBlade_WUBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Jace, the Mind Sculptor"),(3, "Ice-Fang Coatl"),(1, "Snapcaster Mage"),(4, "Stoneforge Mystic"),(2, "Uro, Titan of Nature's Wrath"),(2, "Abrupt Decay"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(1, "Deprive"),(4, "Fatal Push"),(3, "Force of Negation"),(1, "Kaya's Guile"),(1, "Mana Leak"),(1, "Spell Snare"),(4, "Arcum's Astrolabe"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(1, "Breeding Pool"),(4, "Flooded Strand"),(1, "Hallowed Fountain"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(2, "Polluted Delta"),(1, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Snow-Covered Swamp"),(1, "Temple Garden"),(1, "Watery Grave"),(1, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Kaya's Guile"),(2, "Aether Gust"),(1, "Ashiok, Dream Render"),(1, "Dovin's Veto"),(1, "Mystical Dispute"),(1, "Nihil Spellbomb"),(2, "Notion Thief"),(1, "Supreme Verdict"),(2, "Veil of Summer"),(2, "Vendilion Clique") }; } }
    }
}