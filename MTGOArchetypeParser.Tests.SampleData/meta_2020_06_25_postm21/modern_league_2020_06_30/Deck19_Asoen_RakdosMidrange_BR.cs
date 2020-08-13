using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_06_30
{
    public class Deck19_Asoen_RakdosMidrange_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(3, "Dark Confidant"),
            new SampleCard(3, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(3, "Lightning Skelemental"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Ransack the Lab"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(3, "Unearth"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Castle Embereth"),
            new SampleCard(1, "Castle Locthwain"),
            new SampleCard(1, "Lavaclaw Reaches"),
            new SampleCard(2, "Marsh Flats"),
            new SampleCard(2, "Mountain"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(3, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Fulminator Mage"),
            new SampleCard(1, "Kalitas, Traitor of Ghet"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Plague Engineer") 
        };
    }
}