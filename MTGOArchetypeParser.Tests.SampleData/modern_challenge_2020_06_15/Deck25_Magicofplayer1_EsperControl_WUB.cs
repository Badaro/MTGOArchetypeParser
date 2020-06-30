using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck25_Magicofplayer1_EsperControl_WUB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Jace, the Mind Sculptor"),(1, "Teferi, Hero of Dominaria"),(3, "Teferi, Time Raveler"),(2, "Snapcaster Mage"),(2, "Inquisition of Kozilek"),(2, "Supreme Verdict"),(1, "Archmage's Charm"),(3, "Cryptic Command"),(1, "Delay"),(4, "Fatal Push"),(3, "Force of Negation"),(1, "Logic Knot"),(1, "Mana Leak"),(3, "Opt"),(1, "Spell Snare"),(4, "Arcum's Astrolabe"),(4, "Field of Ruin"),(4, "Flooded Strand"),(2, "Hallowed Fountain"),(3, "Mystic Sanctuary"),(4, "Polluted Delta"),(5, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Snow-Covered Swamp"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (4, "Aether Gust"),(2, "Ceremonious Rejection"),(1, "Disdainful Stroke"),(1, "Nihil Spellbomb"),(2, "Shark Typhoon"),(2, "Thoughtseize"),(2, "Timely Reinforcements"),(1, "Wrath of God") }; } }
    }
}