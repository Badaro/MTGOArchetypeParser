using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck54_kado222_GoryoReanimator_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emrakul, the Aeons Torn"),
            new SampleCard(4, "Griselbrand"),
            new SampleCard(3, "Merchant of the Vale"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(4, "Collective Brutality"),
            new SampleCard(3, "Night's Whisper"),
            new SampleCard(4, "Goryo's Vengeance"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(4, "Thrill of Possibility"),
            new SampleCard(4, "Through the Breach"),
            new SampleCard(4, "Pentad Prism"),
            new SampleCard(2, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(3, "Swamp"),
            new SampleCard(1, "Urborg, Tomb of Yawgmoth"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Chandra, Awakened Inferno"),
            new SampleCard(2, "Duress"),
            new SampleCard(2, "Pack Rat"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}