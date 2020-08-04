using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck16_crackerpack_SolemnityCombo_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Anafenza, Kin-Tree Spirit"),
            new SampleCard(3, "Carrion Feeder"),
            new SampleCard(4, "Kitchen Finks"),
            new SampleCard(2, "Putrid Goblin"),
            new SampleCard(4, "Safehold Elite"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Altar of Dementia"),
            new SampleCard(2, "Blasting Station"),
            new SampleCard(4, "Phyrexian Unlife"),
            new SampleCard(4, "Solemnity"),
            new SampleCard(3, "Concealed Courtyard"),
            new SampleCard(3, "Godless Shrine"),
            new SampleCard(2, "Marsh Flats"),
            new SampleCard(3, "Plains"),
            new SampleCard(4, "Silent Clearing"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(4, "Disenchant"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Greater Auramancy"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(2, "Silence") 
        };
    }
}