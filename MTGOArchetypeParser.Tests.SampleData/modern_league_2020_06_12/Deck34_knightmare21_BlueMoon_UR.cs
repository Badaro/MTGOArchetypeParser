using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck34_knightmare21_BlueMoon_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "The Royal Scions"),(2, "Bonecrusher Giant"),(1, "Brazen Borrower"),(4, "Snapcaster Mage"),(3, "Thing in the Ice"),(1, "Vendilion Clique"),(4, "Serum Visions"),(3, "Archmage's Charm"),(3, "Cryptic Command"),(1, "Deprive"),(1, "Electrolyze"),(4, "Lightning Bolt"),(1, "Magmatic Sinkhole"),(4, "Opt"),(3, "Remand"),(1, "Spell Pierce"),(1, "Spell Snare"),(4, "Flooded Strand"),(7, "Island"),(1, "Mountain"),(2, "Mystic Sanctuary"),(4, "Scalding Tarn"),(2, "Steam Vents"),(2, "Sulfur Falls") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(2, "Anger of the Gods"),(2, "Ashiok, Dream Render"),(2, "Blood Moon"),(1, "Ceremonious Rejection"),(2, "Dragon's Claw"),(2, "Flusterstorm"),(2, "Relic of Progenitus") }; } }
    }
}