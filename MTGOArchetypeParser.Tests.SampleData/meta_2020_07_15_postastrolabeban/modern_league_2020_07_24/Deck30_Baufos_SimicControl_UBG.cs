using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24
{
    public class Deck30_Baufos_SimicControl_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Snapcaster Mage"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Hour of Promise"),
            new SampleCard(1, "Aether Gust"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Fact or Fiction"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(3, "Remand"),
            new SampleCard(2, "Repeal"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(1, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Field of the Dead"),
            new SampleCard(1, "Flooded Grove"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Hinterland Harbor"),
            new SampleCard(1, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Temple of Mystery"),
            new SampleCard(1, "Waterlogged Grove"),
            new SampleCard(1, "Yavimaya Coast"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Shark Typhoon"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}