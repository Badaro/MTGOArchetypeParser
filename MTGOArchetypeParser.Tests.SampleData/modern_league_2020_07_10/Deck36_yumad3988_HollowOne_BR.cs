using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10
{
    public class Deck36_yumad3988_HollowOne_BR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bloodghast"),
            new SampleCard(4, "Flameblade Adept"),
            new SampleCard(4, "Flamewake Phoenix"),
            new SampleCard(4, "Hollow One"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(3, "Ox of Agonas"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Burning Inquiry"),
            new SampleCard(4, "Goblin Lore"),
            new SampleCard(2, "Unearth"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Arid Mesa"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(3, "Mountain"),
            new SampleCard(2, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Alpine Moon"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Grim Lavamancer"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Shenanigans"),
            new SampleCard(2, "Witch's Vengeance") 
        };
    }
}