using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck21_CodeProvider_Grishoalbrand_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Borborygmos Enraged"),
            new SampleCard(4, "Griselbrand"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(4, "Worldspine Wurm"),
            new SampleCard(4, "Cathartic Reunion"),
            new SampleCard(4, "Night's Whisper"),
            new SampleCard(2, "Desperate Ritual"),
            new SampleCard(4, "Goryo's Vengeance"),
            new SampleCard(1, "Lightning Axe"),
            new SampleCard(4, "Nourishing Shoal"),
            new SampleCard(4, "Thrill of Possibility"),
            new SampleCard(4, "Through the Breach"),
            new SampleCard(2, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Gemstone Caverns"),
            new SampleCard(3, "Mountain"),
            new SampleCard(5, "Swamp"),
            new SampleCard(3, "Temple of Malice") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrade"),
            new SampleCard(4, "Blood Moon"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(1, "Emrakul, the Aeons Torn"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(2, "Pact of Negation"),
            new SampleCard(1, "Pyroclasm"),
            new SampleCard(1, "Shattering Spree") 
        };
    }
}