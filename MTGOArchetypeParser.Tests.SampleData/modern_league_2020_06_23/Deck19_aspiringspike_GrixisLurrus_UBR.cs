using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck19_aspiringspike_GrixisLurrus_UBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Lurrus of the Dream Den"),(3, "Snapcaster Mage"),(4, "Sprite Dragon"),(2, "Unearth"),(3, "Archmage's Charm"),(1, "Cling to Dust"),(2, "Drown in the Loch"),(4, "Force of Negation"),(4, "Lightning Bolt"),(2, "Mana Leak"),(2, "Spell Snare"),(4, "Thought Scour"),(4, "Mishra's Bauble"),(1, "Seal of Fire"),(1, "Blood Crypt"),(3, "Darkslick Shores"),(2, "Island"),(4, "Polluted Delta"),(4, "Scalding Tarn"),(2, "Spirebluff Canal"),(2, "Steam Vents"),(3, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Seal of Fire"),(1, "Unearth"),(3, "Aether Gust"),(3, "Collective Brutality"),(1, "Fatal Push"),(2, "Flusterstorm"),(1, "Nihil Spellbomb"),(2, "Tormod's Crypt") }; } }
    }
}