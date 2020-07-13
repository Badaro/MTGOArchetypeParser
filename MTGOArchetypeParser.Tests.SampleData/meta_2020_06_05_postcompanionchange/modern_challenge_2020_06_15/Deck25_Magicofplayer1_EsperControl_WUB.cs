using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_15
{
    public class Deck25_Magicofplayer1_EsperControl_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(1, "Delay"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(1, "Logic Knot"),
            new SampleCard(1, "Mana Leak"),
            new SampleCard(3, "Opt"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Shark Typhoon"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(1, "Wrath of God") 
        };
    }
}