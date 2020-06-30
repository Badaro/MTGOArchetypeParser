using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck13_SvenSvenSven_BlueMoon_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "The Royal Scions"),(2, "Bonecrusher Giant"),(2, "Brazen Borrower"),(3, "Snapcaster Mage"),(3, "Thing in the Ice"),(4, "Serum Visions"),(4, "Archmage's Charm"),(1, "Deprive"),(2, "Force of Negation"),(4, "Lightning Bolt"),(1, "Magmatic Sinkhole"),(4, "Opt"),(3, "Remand"),(2, "Spell Pierce"),(1, "Cascade Bluffs"),(8, "Island"),(1, "Mountain"),(2, "Mystic Sanctuary"),(4, "Polluted Delta"),(4, "Scalding Tarn"),(3, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Bonecrusher Giant"),(1, "Abrade"),(2, "Aether Gust"),(1, "Ashiok, Dream Render"),(1, "Beacon Bolt"),(2, "Blood Moon"),(3, "Ceremonious Rejection"),(1, "Flusterstorm"),(2, "Relic of Progenitus"),(1, "Spell Snare") }; } }
    }
}