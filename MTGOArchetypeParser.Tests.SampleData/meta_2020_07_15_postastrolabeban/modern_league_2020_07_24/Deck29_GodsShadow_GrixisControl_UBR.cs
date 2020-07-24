using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24
{
    public class Deck29_GodsShadow_GrixisControl_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bonecrusher Giant"),
            new SampleCard(2, "Jace, Vryn's Prodigy"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(2, "Tasigur, the Golden Fang"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(4, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Logic Knot"),
            new SampleCard(2, "Terminate"),
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
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(2, "Fulminator Mage"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(1, "Grim Lavamancer"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(1, "Surgical Extraction") 
        };
    }
}