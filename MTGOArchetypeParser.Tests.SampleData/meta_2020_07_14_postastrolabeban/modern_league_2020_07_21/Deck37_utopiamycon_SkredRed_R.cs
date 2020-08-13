using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck37_utopiamycon_SkredRed_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Awakened Inferno"),
            new SampleCard(3, "Karn, the Great Creator"),
            new SampleCard(3, "Koth of the Hammer"),
            new SampleCard(3, "Bonecrusher Giant"),
            new SampleCard(3, "Sweltering Suns"),
            new SampleCard(1, "Abrade"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Skred"),
            new SampleCard(2, "Batterskull"),
            new SampleCard(2, "Mazemind Tome"),
            new SampleCard(4, "Mind Stone"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(1, "Frostwalk Bastion"),
            new SampleCard(2, "Mouth of Ronom"),
            new SampleCard(2, "Scrying Sheets"),
            new SampleCard(17, "Snow-Covered Mountain") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Dragon's Claw"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Guttural Response"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(3, "Molten Rain"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Sands of Delirium"),
            new SampleCard(1, "Tormod's Crypt") 
        };
    }
}