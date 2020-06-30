using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck09_FrancusAurelius_NayaStoneblade_WRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Ajani Steadfast"),(2, "Chandra, Torch of Defiance"),(2, "Wrenn and Six"),(2, "Birds of Paradise"),(4, "Knight of the Reliquary"),(4, "Noble Hierarch"),(2, "Seasoned Pyromancer"),(4, "Stoneforge Mystic"),(4, "Tarmogoyf"),(1, "Tireless Tracker"),(4, "Lightning Bolt"),(4, "Path to Exile"),(1, "Batterskull"),(1, "Embercleave"),(1, "Sword of Feast and Famine"),(1, "Blast Zone"),(1, "Field of Ruin"),(1, "Ghost Quarter"),(1, "Horizon Canopy"),(1, "Kessig Wolf Run"),(1, "Sacred Foundry"),(2, "Snow-Covered Forest"),(1, "Snow-Covered Mountain"),(1, "Snow-Covered Plains"),(2, "Stomping Ground"),(1, "Sunbaked Canyon"),(1, "Temple Garden"),(1, "Tranquil Thicket"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Blood Moon"),(2, "Boil"),(1, "Cindervines"),(2, "Collector Ouphe"),(2, "Force of Vigor"),(1, "Goblin Cratermaker"),(2, "Grafdigger's Cage"),(2, "Lightning Helix"),(1, "Scavenging Ooze") }; } }
    }
}