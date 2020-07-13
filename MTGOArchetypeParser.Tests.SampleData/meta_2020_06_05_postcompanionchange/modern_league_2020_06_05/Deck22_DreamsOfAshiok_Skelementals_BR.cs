using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05
{
    public class Deck22_DreamsOfAshiok_Skelementals_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Liliana of the Veil"),
            new SampleCard(3, "Dark Confidant"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(1, "Dreadbore"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Ransack the Lab"),
            new SampleCard(2, "Thoughtseize"),
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
            new SampleCard(3, "Marsh Flats"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Prismatic Vista"),
            new SampleCard(2, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Blood Moon"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Extinction Event"),
            new SampleCard(2, "Fulminator Mage"),
            new SampleCard(1, "Kalitas, Traitor of Ghet"),
            new SampleCard(2, "Legion's End"),
            new SampleCard(2, "Nihil Spellbomb") 
        };
    }
}