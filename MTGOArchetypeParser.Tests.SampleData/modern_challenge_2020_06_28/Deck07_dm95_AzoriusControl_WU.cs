using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck07_dm95_AzoriusControl_WU : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Jace, the Mind Sculptor"),(2, "Teferi, Time Raveler"),(3, "Snapcaster Mage"),(4, "Stoneforge Mystic"),(1, "Vendilion Clique"),(1, "Oust"),(2, "Supreme Verdict"),(1, "Archmage's Charm"),(2, "Cryptic Command"),(3, "Force of Negation"),(2, "Mana Leak"),(4, "Opt"),(4, "Path to Exile"),(1, "Spell Snare"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(1, "Shark Typhoon"),(2, "Celestial Colonnade"),(3, "Field of Ruin"),(4, "Flooded Strand"),(2, "Glacial Fortress"),(2, "Hallowed Fountain"),(7, "Island"),(1, "Mystic Sanctuary"),(1, "Plains"),(2, "Polluted Delta") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Batterskull"),(3, "Aether Gust"),(1, "Ashiok, Dream Render"),(1, "Ceremonious Rejection"),(2, "Containment Priest"),(1, "Damping Sphere"),(1, "Dovin's Veto"),(1, "Mystical Dispute"),(2, "Rest in Peace"),(2, "Timely Reinforcements") }; } }
    }
}