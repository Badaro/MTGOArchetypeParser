using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck19_RyanWu_OrzhovMidrange_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "Liliana of the Veil"),
            new SampleCard(3, "Dark Confidant"),
            new SampleCard(2, "Monastery Mentor"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(3, "Tidehollow Sculler"),
            new SampleCard(2, "Wasteland Strangler"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Unearth"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Kaya's Guile"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Castle Locthwain"),
            new SampleCard(2, "Concealed Courtyard"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(2, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(2, "Plains"),
            new SampleCard(2, "Shambling Vent"),
            new SampleCard(3, "Silent Clearing"),
            new SampleCard(3, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Kaya's Guile"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Disenchant"),
            new SampleCard(1, "Kor Firewalker"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(1, "Rest in Peace"),
            new SampleCard(1, "Stony Silence"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(1, "Wrath of God") 
        };
    }
}