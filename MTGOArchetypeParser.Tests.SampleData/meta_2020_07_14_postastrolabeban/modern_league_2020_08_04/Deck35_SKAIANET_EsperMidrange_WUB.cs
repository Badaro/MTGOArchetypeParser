using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck35_SKAIANET_EsperMidrange_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(3, "Spell Queller"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(2, "Eliminate"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Castle Ardenvale"),
            new SampleCard(1, "Drowned Catacomb"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(3, "Island"),
            new SampleCard(2, "Plains"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Batterskull"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}