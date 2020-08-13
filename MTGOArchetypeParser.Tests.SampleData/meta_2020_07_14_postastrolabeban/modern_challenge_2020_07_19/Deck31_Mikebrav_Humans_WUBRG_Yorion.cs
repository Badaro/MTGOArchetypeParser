using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_07_19
{
    public class Deck31_Mikebrav_Humans_WUBRG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Avacyn's Pilgrim"),
            new SampleCard(4, "Champion of the Parish"),
            new SampleCard(2, "Charming Prince"),
            new SampleCard(3, "General Kudro of Drannith"),
            new SampleCard(4, "Kessig Malcontents"),
            new SampleCard(4, "Kitesail Freebooter"),
            new SampleCard(4, "Mantis Rider"),
            new SampleCard(4, "Meddling Mage"),
            new SampleCard(2, "Militia Bugler"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Phantasmal Image"),
            new SampleCard(4, "Reflector Mage"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thalia's Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Ancient Ziggurat"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(1, "Mana Confluence"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(1, "Silent Clearing"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Sunbaked Canyon"),
            new SampleCard(4, "Unclaimed Territory"),
            new SampleCard(2, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Auriok Champion"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Dire Fleet Daredevil"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(1, "Lavabrink Venturer"),
            new SampleCard(1, "Sin Collector"),
            new SampleCard(2, "Unsettled Mariner"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}