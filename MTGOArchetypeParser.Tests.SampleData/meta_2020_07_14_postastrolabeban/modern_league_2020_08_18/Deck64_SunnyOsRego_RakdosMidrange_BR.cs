using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck64_SunnyOsRego_RakdosMidrange_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Liliana of the Veil"),
            new SampleCard(3, "Dark Confidant"),
            new SampleCard(3, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(3, "Ransack the Lab"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Unearth"),
            new SampleCard(3, "Cling to Dust"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Blackcleave Cliffs"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Castle Locthwain"),
            new SampleCard(1, "Graven Cairns"),
            new SampleCard(3, "Marsh Flats"),
            new SampleCard(3, "Mountain"),
            new SampleCard(4, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Dreadbore"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Plague Engineer") 
        };
    }
}