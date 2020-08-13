using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_24
{
    public class Deck01_Mordeka1ser_BringToNiv_WUBRG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(4, "Wrenn and Six"),
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(1, "Bloodbraid Elf"),
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(3, "Niv-Mizzet Reborn"),
            new SampleCard(1, "Seasoned Pyromancer"),
            new SampleCard(1, "Spell Queller"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Bring to Light"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(2, "Eladamri's Call"),
            new SampleCard(3, "Kaya's Guile"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Helix"),
            new SampleCard(4, "Abundant Growth"),
            new SampleCard(1, "Oath of Kaya"),
            new SampleCard(1, "Oath of Nissa"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Kaya's Guile"),
            new SampleCard(1, "Boil"),
            new SampleCard(1, "Deafening Clarion"),
            new SampleCard(1, "Kambal, Consul of Allocation"),
            new SampleCard(1, "Lavinia, Azorius Renegade"),
            new SampleCard(1, "Meddling Mage"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Thrun, the Last Troll"),
            new SampleCard(1, "Unmoored Ego"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(1, "Yixlid Jailer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}