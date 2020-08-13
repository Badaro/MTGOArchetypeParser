using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_23
{
    public class Deck31_GodsShadow_GrixisControl_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(2, "Jace, Vryn's Prodigy"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(2, "Tasigur, the Golden Fang"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(4, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Logic Knot"),
            new SampleCard(2, "Terminate"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(1, "Cascade Bluffs"),
            new SampleCard(2, "Creeping Tar Pit"),
            new SampleCard(3, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(2, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Countersquall"),
            new SampleCard(2, "Fulminator Mage"),
            new SampleCard(2, "Kalitas, Traitor of Ghet"),
            new SampleCard(1, "Massacre Wurm"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(2, "Thoughtseize") 
        };
    }
}