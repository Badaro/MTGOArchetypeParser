using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07
{
    public class Deck35_Delthar_Infect_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Phyrexian Crusader"),
            new SampleCard(4, "Plague Stinger"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(3, "Scale Up"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Abrupt Decay"),
            new SampleCard(2, "Become Immense"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(4, "Vines of Vastwood"),
            new SampleCard(1, "Blooming Marsh"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Urborg, Tomb of Yawgmoth"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(3, "Kitchen Finks"),
            new SampleCard(2, "Liliana, the Last Hope"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(2, "Shapers' Sanctuary"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}