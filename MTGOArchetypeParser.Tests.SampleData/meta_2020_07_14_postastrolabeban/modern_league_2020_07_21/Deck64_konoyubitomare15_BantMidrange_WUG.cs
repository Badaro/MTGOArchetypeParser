using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck64_konoyubitomare15_BantMidrange_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(3, "Birds of Paradise"),
            new SampleCard(1, "Courser of Kruphix"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(4, "Knight of the Reliquary"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(3, "Scavenging Ooze"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(3, "Tireless Tracker"),
            new SampleCard(2, "Voice of Resurgence"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(4, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Tectonic Edge"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Deputy of Detention"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Unified Will"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Winds of Abandon"),
            new SampleCard(2, "Worship") 
        };
    }
}