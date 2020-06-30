using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck07_rojanosa_Tokens_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "Sorin, Solemn Visitor"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Tidehollow Sculler"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Lingering Souls"),
            new SampleCard(4, "Spectral Procession"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Bitterblossom"),
            new SampleCard(3, "Caves of Koilos"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(2, "Godless Shrine"),
            new SampleCard(2, "Plains"),
            new SampleCard(4, "Shambling Vent"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Vault of the Archangel"),
            new SampleCard(4, "Windbrisk Heights") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Duress"),
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(1, "Orzhov Pontiff"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Stony Silence"),
            new SampleCard(2, "Sundering Growth"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(2, "Wrath of God") 
        };
    }
}