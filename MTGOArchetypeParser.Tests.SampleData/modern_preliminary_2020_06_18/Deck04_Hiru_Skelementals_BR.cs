using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_18
{
    public class Deck04_Hiru_Skelementals_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Liliana of the Veil"),(4, "Dark Confidant"),(3, "Dreadhorde Arcanist"),(3, "Kroxa, Titan of Death's Hunger"),(4, "Lightning Skelemental"),(4, "Vexing Devil"),(3, "Inquisition of Kozilek"),(3, "Thoughtseize"),(4, "Unearth"),(1, "Cling to Dust"),(3, "Fatal Push"),(1, "Kolaghan's Command"),(4, "Lightning Bolt"),(1, "Blackcleave Cliffs"),(3, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Graven Cairns"),(3, "Polluted Delta"),(3, "Scalding Tarn"),(2, "Snow-Covered Mountain"),(2, "Snow-Covered Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Cling to Dust"),(2, "Kolaghan's Command"),(2, "Collective Brutality"),(3, "Fulminator Mage"),(1, "Liliana, the Last Hope"),(2, "Magus of the Moon"),(2, "Plague Engineer"),(2, "Surgical Extraction") }; } }
    }
}