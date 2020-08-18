using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck07_Jiggywiggy_KinnanMentor_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(4, "Kinnan, Bonder Prodigy"),
            new SampleCard(4, "Monastery Mentor"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Aether Spellbomb"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(4, "Engineered Explosives"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(4, "Mox Amber"),
            new SampleCard(4, "Springleaf Drum"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(2, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Minamo, School at Water's Edge"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Seachrome Coast"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Windswept Heath"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}