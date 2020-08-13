using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_23
{
    public class Deck11_Snipersarebums_BringToNiv_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(3, "Niv-Mizzet Reborn"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Bring to Light"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(1, "Unmoored Ego"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(4, "Kaya's Guile"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(3, "Lightning Helix"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(1, "Indatha Triome"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(3, "Pillar of the Paruns"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(3, "Prismatic Vista"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Unmoored Ego"),
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Boil"),
            new SampleCard(1, "Deafening Clarion"),
            new SampleCard(1, "Izzet Staticaster"),
            new SampleCard(2, "Meddling Mage"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Wheel of Sun and Moon") 
        };
    }
}