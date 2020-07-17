using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_17
{
    public class Deck17_ContraEgo_ThopterUrza_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Goblin Engineer"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(3, "Galvanic Blast"),
            new SampleCard(3, "Metallic Rebuke"),
            new SampleCard(3, "Whir of Invention"),
            new SampleCard(1, "Aether Spellbomb"),
            new SampleCard(2, "Chromatic Star"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(1, "Pentad Prism"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Spine of Ish Sah"),
            new SampleCard(2, "Sword of the Meek"),
            new SampleCard(1, "Talisman of Creativity"),
            new SampleCard(2, "Talisman of Dominance"),
            new SampleCard(4, "Thopter Foundry"),
            new SampleCard(4, "Witching Well"),
            new SampleCard(2, "Darkslick Shores"),
            new SampleCard(1, "Glimmervoid"),
            new SampleCard(1, "Inventors' Fair"),
            new SampleCard(4, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(2, "Spire of Industry"),
            new SampleCard(2, "Spirebluff Canal"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Ashiok, Nightmare Muse"),
            new SampleCard(1, "Battle at the Bridge"),
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Dragon's Claw"),
            new SampleCard(1, "Dreadbore"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(1, "Ghirapur Aether Grid"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Herald of Anguish"),
            new SampleCard(1, "Negate"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(1, "Torpor Orb") 
        };
    }
}