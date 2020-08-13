using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck21_Bishark_BlueDevotion_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Gadwick, the Wizened"),
            new SampleCard(4, "Harbinger of the Tides"),
            new SampleCard(3, "Master of Waves"),
            new SampleCard(1, "Thassa, Deep-Dwelling"),
            new SampleCard(3, "Thassa, God of the Sea"),
            new SampleCard(4, "Thassa's Oracle"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Mistvein Borderpost"),
            new SampleCard(4, "Witching Well"),
            new SampleCard(4, "Leyline of Anticipation"),
            new SampleCard(4, "Omen of the Sea"),
            new SampleCard(2, "Sea's Claim"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(14, "Island"),
            new SampleCard(1, "Minamo, School at Water's Edge"),
            new SampleCard(4, "Nykthos, Shrine to Nyx") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(3, "Tidebinder Mage"),
            new SampleCard(2, "Wrath of Marit Lage") 
        };
    }
}