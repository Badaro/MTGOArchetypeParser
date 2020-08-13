using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07
{
    public class Deck15_equites_Burn_IncineratorBurn_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Chandra's Incinerator"),
            new SampleCard(3, "Eidolon of the Great Revel"),
            new SampleCard(2, "Grim Lavamancer"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Vexing Devil"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Rift Bolt"),
            new SampleCard(4, "Skewer the Critics"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Shard Volley"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(20, "Mountain") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Dragon's Claw"),
            new SampleCard(3, "Searing Blood"),
            new SampleCard(2, "Shrine of Burning Rage"),
            new SampleCard(2, "Skullcrack"),
            new SampleCard(4, "Smash to Smithereens"),
            new SampleCard(3, "Soul-Guide Lantern") 
        };
    }
}