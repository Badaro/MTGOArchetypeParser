using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_06
{
    public class Deck10_12Days_Ponza_BRG_Obosh : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Lukka, Coppercoat Outcast"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(3, "Bonecrusher Giant"),
            new SampleCard(1, "Emrakul, the Aeons Torn"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(3, "Planebound Accomplice"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(3, "Unearth"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(6, "Forest"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(3, "Verdant Catacombs"),
            new SampleCard(3, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Natural State"),
            new SampleCard(1, "Obosh, the Preypiercer"),
            new SampleCard(2, "Pillage"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}