using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck02_Manacymbal_KinnanUrza_URG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Jace, the Mind Sculptor"),(4, "Karn, the Great Creator"),(1, "Tamiyo, Collector of Tales"),(1, "The Royal Scions"),(4, "Wrenn and Six"),(4, "Emry, Lurker of the Loch"),(4, "Gilded Goose"),(4, "Kinnan, Bonder Prodigy"),(1, "Oviya Pashiri, Sage Lifecrafter"),(3, "Trinket Mage"),(4, "Uro, Titan of Nature's Wrath"),(4, "Urza, Lord High Artificer"),(1, "Walking Ballista"),(4, "Arcum's Astrolabe"),(2, "Engineered Explosives"),(4, "Mishra's Bauble"),(4, "Mox Amber"),(1, "Pithing Needle"),(1, "Shadowspear"),(1, "Soul-Guide Lantern"),(4, "Springleaf Drum"),(1, "Breeding Pool"),(4, "Misty Rainforest"),(4, "Prismatic Vista"),(4, "Scalding Tarn"),(2, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(1, "Steam Vents"),(1, "Stomping Ground"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Walking Ballista"),(4, "Damping Sphere"),(1, "Ensnaring Bridge"),(4, "Galvanic Blast"),(1, "Liquimetal Coating"),(1, "Salvage Titan"),(1, "Skysovereign, Consul Flagship"),(1, "Sorcerous Spyglass"),(1, "Yorion, Sky Nomad") }; } }
    }
}