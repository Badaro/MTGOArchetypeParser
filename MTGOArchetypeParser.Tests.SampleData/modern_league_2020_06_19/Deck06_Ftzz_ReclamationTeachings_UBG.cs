using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck06_Ftzz_ReclamationTeachings_UBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Ice-Fang Coatl"),(3, "Snapcaster Mage"),(1, "Abrupt Decay"),(1, "Assassin's Trophy"),(1, "Blue Sun's Zenith"),(4, "Cryptic Command"),(3, "Fatal Push"),(4, "Growth Spiral"),(1, "Logic Knot"),(3, "Mystical Teachings"),(1, "Nexus of Fate"),(4, "Opt"),(1, "Pulse of Murasa"),(4, "Remand"),(3, "Wilderness Reclamation"),(2, "Breeding Pool"),(1, "Castle Vantress"),(2, "Creeping Tar Pit"),(1, "Field of Ruin"),(2, "Hinterland Harbor"),(4, "Misty Rainforest"),(1, "Mystic Sanctuary"),(3, "Polluted Delta"),(1, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(2, "Watery Grave"),(1, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ice-Fang Coatl"),(1, "Fatal Push"),(2, "Aether Gust"),(1, "Ceremonious Rejection"),(1, "Consume the Meek"),(1, "Dispel"),(1, "Echoing Decay"),(1, "Mystical Dispute"),(1, "Ravenous Trap"),(1, "Surgical Extraction"),(1, "Veil of Summer"),(2, "Weather the Storm") }; } }
    }
}