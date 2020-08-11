using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck69_aspiringspike_DeathsShadow_EsperShadow_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(1, "Hex Parasite"),
            new SampleCard(3, "Ranger-Captain of Eos"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(1, "Tasigur, the Golden Fang"),
            new SampleCard(2, "Tidehollow Sculler"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Unearth"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(2, "Godless Shrine"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Island"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Plains"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(1, "Silent Clearing"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Teferi, Time Raveler") 
        };
    }
}