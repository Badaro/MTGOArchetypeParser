using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_18
{
    public class Deck04_Hiru_Skelementals_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(4, "Dark Confidant"),
            new SampleCard(3, "Dreadhorde Arcanist"),
            new SampleCard(3, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(4, "Vexing Devil"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(4, "Unearth"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Blackcleave Cliffs"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Graven Cairns"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(2, "Snow-Covered Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}