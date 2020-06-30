using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck23_Magric_Skelementals_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(3, "Dark Confidant"),
            new SampleCard(1, "Dreadhorde Arcanist"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(1, "Dreadbore"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Unearth"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(3, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Blackcleave Cliffs"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Castle Embereth"),
            new SampleCard(1, "Castle Locthwain"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(3, "Snow-Covered Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Blood Moon"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Fulminator Mage"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(2, "Pillage"),
            new SampleCard(2, "Plague Engineer") 
        };
    }
}