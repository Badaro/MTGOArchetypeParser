using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck50_qbturtle15_BorosSunforger_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Fervent Champion"),
            new SampleCard(1, "Figure of Destiny"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(1, "Grim Lavamancer"),
            new SampleCard(3, "Ranger of Eos"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Chance for Glory"),
            new SampleCard(1, "Lapse of Certainty"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Lightning Helix"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Warleader's Helix"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(2, "Sunforger"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(2, "Marsh Flats"),
            new SampleCard(3, "Mountain"),
            new SampleCard(3, "Plains"),
            new SampleCard(4, "Sacred Foundry"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(1, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Path to Exile"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(2, "Boil"),
            new SampleCard(1, "Boros Charm"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(1, "Mana Tithe"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Wear // Tear") 
        };
    }
}