using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck43_Curryvore_AzoriousBlink_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(3, "Kitchen Finks"),
            new SampleCard(3, "Restoration Angel"),
            new SampleCard(2, "Vendilion Clique"),
            new SampleCard(3, "Venser, Shaper Savant"),
            new SampleCard(4, "Wall of Omens"),
            new SampleCard(2, "Yorion, Sky Nomad"),
            new SampleCard(1, "Serum Visions"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Detention Sphere"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(4, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Glacial Fortress"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(3, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(1, "Lyra Dawnbringer"),
            new SampleCard(4, "Rest in Peace"),
            new SampleCard(2, "Wing Shards") 
        };
    }
}