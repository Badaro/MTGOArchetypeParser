using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_24
{
    public class Deck50_Mussie99_AzoriusControl_AzoriusStoneblade_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Vendilion Clique"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Logic Knot"),
            new SampleCard(1, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Remand"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Glacial Fortress"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(1, "Containment Priest"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(1, "Timely Reinforcements") 
        };
    }
}