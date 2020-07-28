using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck11_Yooisa_Infect_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Distortion Strike"),
            new SampleCard(4, "Scale Up"),
            new SampleCard(4, "Blossoming Defense"),
            new SampleCard(2, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(3, "Vines of Vastwood"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(3, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(4, "Waterlogged Grove"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(1, "Island"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Tormod's Crypt"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Wilt") 
        };
    }
}