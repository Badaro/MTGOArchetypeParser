using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_23
{
    public class Deck15_RogerSteady_GrixisEnforcer_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(1, "Dire Fleet Daredevil"),
            new SampleCard(2, "Jace's Phantasm"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Thieves' Guild Enforcer"),
            new SampleCard(4, "Vantress Gargoyle"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Unearth"),
            new SampleCard(4, "Drown in the Loch"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(1, "Bitterblossom"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(1, "Bloodstained Mire"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(1, "Swamp"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bitterblossom"),
            new SampleCard(2, "Alpine Moon"),
            new SampleCard(4, "Ceremonious Rejection"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(3, "Plague Engineer") 
        };
    }
}