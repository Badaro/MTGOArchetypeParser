using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck37_MinT_AdNauseam_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Jace, Wielder of Mysteries"),
            new SampleCard(4, "Inverter of Truth"),
            new SampleCard(4, "Thassa's Oracle"),
            new SampleCard(3, "Serum Visions"),
            new SampleCard(4, "Angel's Grace"),
            new SampleCard(3, "Pact of Negation"),
            new SampleCard(4, "Spoils of the Vault"),
            new SampleCard(4, "Pentad Prism"),
            new SampleCard(3, "Talisman of Dominance"),
            new SampleCard(1, "Talisman of Progress"),
            new SampleCard(2, "Wishclaw Talisman"),
            new SampleCard(4, "Phyrexian Unlife"),
            new SampleCard(4, "City of Brass"),
            new SampleCard(1, "Darkslick Shores"),
            new SampleCard(4, "Gemstone Mine"),
            new SampleCard(2, "Seachrome Coast"),
            new SampleCard(4, "Shelldock Isle"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(1, "Temple of Deceit"),
            new SampleCard(1, "Temple of Enlightenment"),
            new SampleCard(1, "Urborg, Tomb of Yawgmoth") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Wishclaw Talisman"),
            new SampleCard(1, "Defense Grid"),
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Hurkyl's Recall"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Slaughter Pact"),
            new SampleCard(1, "Solemnity"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}