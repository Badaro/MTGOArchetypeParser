using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck45_TarHeels82_Burn_IncineratorBurn_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Chandra's Incinerator"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Rift Bolt"),
            new SampleCard(4, "Skewer the Critics"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Searing Blaze"),
            new SampleCard(3, "Shard Volley"),
            new SampleCard(2, "Skullcrack"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(15, "Mountain"),
            new SampleCard(3, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Skullcrack"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(3, "Eidolon of the Great Revel"),
            new SampleCard(4, "Smash to Smithereens"),
            new SampleCard(2, "Tormod's Crypt") 
        };
    }
}