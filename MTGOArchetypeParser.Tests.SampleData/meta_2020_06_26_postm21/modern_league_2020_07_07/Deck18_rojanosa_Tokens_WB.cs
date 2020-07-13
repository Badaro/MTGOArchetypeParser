using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07
{
    public class Deck18_rojanosa_Tokens_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "Liliana of the Veil"),
            new SampleCard(1, "Sorin, Solemn Visitor"),
            new SampleCard(4, "Dark Confidant"),
            new SampleCard(3, "Stoneforge Mystic"),
            new SampleCard(4, "Tidehollow Sculler"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Lingering Souls"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(3, "Bitterblossom"),
            new SampleCard(3, "Caves of Koilos"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(2, "Fetid Heath"),
            new SampleCard(2, "Godless Shrine"),
            new SampleCard(3, "Plains"),
            new SampleCard(4, "Shambling Vent"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(2, "Swamp"),
            new SampleCard(2, "Windbrisk Heights") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Duress"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Sundering Growth"),
            new SampleCard(1, "Wrath of God"),
            new SampleCard(2, "Zealous Persecution") 
        };
    }
}