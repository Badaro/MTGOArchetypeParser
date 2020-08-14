using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_14
{
    public class Deck07_ht991122_WildernessReclamation_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(3, "Fact or Fiction"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Wilderness Reclamation"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Castle Vantress"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(1, "Forest"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Ashiok, Nightmare Muse"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(1, "Cry of the Carnarium"),
            new SampleCard(1, "Disfigure"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}