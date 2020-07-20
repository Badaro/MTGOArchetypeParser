using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20
{
    public class Deck11_MinCash_AdNauseam_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(4, "Thassa's Oracle"),
            new SampleCard(1, "Grim Tutor"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Ad Nauseam"),
            new SampleCard(4, "Angel's Grace"),
            new SampleCard(1, "Lightning Storm"),
            new SampleCard(2, "Pact of Negation"),
            new SampleCard(4, "Spoils of the Vault"),
            new SampleCard(4, "Lotus Bloom"),
            new SampleCard(4, "Pentad Prism"),
            new SampleCard(4, "Phyrexian Unlife"),
            new SampleCard(4, "City of Brass"),
            new SampleCard(3, "Darkslick Shores"),
            new SampleCard(4, "Gemstone Mine"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Seachrome Coast"),
            new SampleCard(3, "Temple of Deceit"),
            new SampleCard(2, "Temple of Enlightenment") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(2, "Chandra, Awakened Inferno"),
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(1, "Slaughter Pact"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}