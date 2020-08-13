using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck07_SKAIANET_EsperControl_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(1, "Castle Ardenvale"),
            new SampleCard(1, "Creeping Tar Pit"),
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
            new SampleCard(4, "Aether Gust"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(3, "Rest in Peace") 
        };
    }
}