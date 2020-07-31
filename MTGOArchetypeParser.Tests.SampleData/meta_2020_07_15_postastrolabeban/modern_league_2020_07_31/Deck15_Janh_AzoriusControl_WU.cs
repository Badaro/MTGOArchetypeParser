using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_31
{
    public class Deck15_Janh_AzoriusControl_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(3, "Restoration Angel"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(3, "Spell Queller"),
            new SampleCard(1, "Vendilion Clique"),
            new SampleCard(3, "Wall of Omens"),
            new SampleCard(1, "Oust"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Fact or Fiction"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(1, "Mana Leak"),
            new SampleCard(3, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Remand"),
            new SampleCard(2, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Glacial Fortress"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(1, "Mystic Gate"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(1, "Cataclysmic Gearhulk"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Condemn"),
            new SampleCard(1, "Generous Gift"),
            new SampleCard(2, "Lyra Dawnbringer"),
            new SampleCard(1, "Winds of Abandon") 
        };
    }
}