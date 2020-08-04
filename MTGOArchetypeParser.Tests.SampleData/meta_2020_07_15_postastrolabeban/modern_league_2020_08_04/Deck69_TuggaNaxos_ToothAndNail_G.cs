using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck69_TuggaNaxos_ToothAndNail_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Garruk Wildspeaker"),
            new SampleCard(4, "Nissa, Who Shakes the World"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(1, "Emrakul, the Aeons Torn"),
            new SampleCard(3, "Eternal Witness"),
            new SampleCard(4, "Wall of Roots"),
            new SampleCard(1, "Xenagos, God of Revels"),
            new SampleCard(4, "Mwonvuli Acid-Moss"),
            new SampleCard(2, "Plow Under"),
            new SampleCard(4, "Primal Command"),
            new SampleCard(3, "Tooth and Nail"),
            new SampleCard(2, "Trinisphere"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(2, "Wolfwillow Haven"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(17, "Forest"),
            new SampleCard(2, "Nykthos, Shrine to Nyx") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Choke"),
            new SampleCard(3, "Dismember"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(3, "Thragtusk"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(3, "Weather the Storm") 
        };
    }
}