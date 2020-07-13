using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16
{
    public class Deck11_sneakyrobot_Infect_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Ichorclaw Myr"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Scale Up"),
            new SampleCard(4, "Blossoming Defense"),
            new SampleCard(3, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(3, "Mutagenic Growth"),
            new SampleCard(4, "Vines of Vastwood"),
            new SampleCard(2, "Rancor"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(3, "Temple Garden"),
            new SampleCard(1, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(1, "Choke"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Kor Firewalker"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(4, "Silhana Ledgewalker"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(1, "Veil of Summer"),
            new SampleCard(1, "Wild Defiance") 
        };
    }
}