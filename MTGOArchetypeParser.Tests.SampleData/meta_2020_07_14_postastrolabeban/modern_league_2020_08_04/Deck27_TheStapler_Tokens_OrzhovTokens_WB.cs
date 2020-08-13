using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck27_TheStapler_Tokens_OrzhovTokens_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "Liliana of the Veil"),
            new SampleCard(3, "Sorin, Solemn Visitor"),
            new SampleCard(2, "Auriok Champion"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Lingering Souls"),
            new SampleCard(4, "Spectral Procession"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Kaya's Guile"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Bitterblossom"),
            new SampleCard(4, "Intangible Virtue"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(4, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Mutavault"),
            new SampleCard(5, "Plains"),
            new SampleCard(2, "Shambling Vent"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(2, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(1, "Kaya's Guile"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Day of Judgment"),
            new SampleCard(2, "Disenchant"),
            new SampleCard(1, "Hallowed Moonlight"),
            new SampleCard(1, "Kambal, Consul of Allocation"),
            new SampleCard(1, "Necromentia"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(1, "Timely Reinforcements") 
        };
    }
}