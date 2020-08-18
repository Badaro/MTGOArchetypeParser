using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck03_Albyz_MarduPyromancer_WBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Chandra, Torch of Defiance"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(3, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Young Pyromancer"),
            new SampleCard(2, "Dreadbore"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(2, "Unearth"),
            new SampleCard(3, "Cling to Dust"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Village Rites"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(3, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "Dragonskull Summit"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(3, "Marsh Flats"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(3, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Hazoret the Fervent"),
            new SampleCard(2, "Kambal, Consul of Allocation"),
            new SampleCard(1, "Kaya's Guile"),
            new SampleCard(2, "Lightning Skelemental"),
            new SampleCard(1, "Liliana of the Veil"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(2, "Shatter Assumptions"),
            new SampleCard(2, "Smiting Helix") 
        };
    }
}