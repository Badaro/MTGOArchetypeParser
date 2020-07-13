using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16
{
    public class Deck13_Simarisu_DeathsShadow_MarduShadow_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(1, "Giver of Runes"),
            new SampleCard(1, "Gurmag Angler"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(3, "Stoneforge Mystic"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tidehollow Sculler"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(1, "Unearth"),
            new SampleCard(1, "Anguished Unmaking"),
            new SampleCard(1, "Dismember"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(3, "Arid Mesa"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(4, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Silent Clearing"),
            new SampleCard(2, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(3, "Rest in Peace") 
        };
    }
}