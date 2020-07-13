using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_06_26
{
    public class Deck35_PieGonti_KinnanUrza_URG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(1, "Narset, Parter of Veils"),
            new SampleCard(4, "Wrenn and Six"),
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(4, "Gilded Goose"),
            new SampleCard(4, "Kinnan, Bonder Prodigy"),
            new SampleCard(3, "Trinket Mage"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Aether Spellbomb"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(4, "Mox Amber"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Soul-Guide Lantern"),
            new SampleCard(4, "Springleaf Drum"),
            new SampleCard(2, "Song of Creation"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Minamo, School at Water's Edge"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Chandra, Awakened Inferno"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(3, "Galvanic Blast"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Skysovereign, Consul Flagship"),
            new SampleCard(1, "Time Sieve"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}