using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck30_MartinezDP_SnowControl_SnowTitan_UG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(1, "Hydroid Krasis"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Primeval Titan"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Aether Gust"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(2, "Blast Zone"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(2, "Flooded Grove"),
            new SampleCard(1, "Forest"),
            new SampleCard(2, "Hinterland Harbor"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Elder Gargaroth"),
            new SampleCard(3, "Engineered Explosives"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}