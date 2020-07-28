using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck61_ColeUv_RakdosMidrange_BR_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Dreadhorde Arcanist"),
            new SampleCard(3, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Burning Inquiry"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(1, "Raven's Crime"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Necrogen Spellbomb"),
            new SampleCard(4, "Waste Not"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Castle Locthwain"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Alpine Moon"),
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Dreadbore"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Pharika's Libation"),
            new SampleCard(3, "Pillage"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}