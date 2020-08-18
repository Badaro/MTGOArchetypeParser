using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck60_tuhoajatane_TitanVial_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Courser of Kruphix"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(1, "Elder Gargaroth"),
            new SampleCard(4, "Elvish Reclaimer"),
            new SampleCard(1, "Eternal Witness"),
            new SampleCard(1, "Giver of Runes"),
            new SampleCard(2, "Golos, Tireless Pilgrim"),
            new SampleCard(1, "Nissa, Vastwood Seer"),
            new SampleCard(2, "Primeval Titan"),
            new SampleCard(1, "Ramunap Excavator"),
            new SampleCard(2, "Sakura-Tribe Elder"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(2, "Tireless Tracker"),
            new SampleCard(2, "Eladamri's Call"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(1, "Castle Ardenvale"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(4, "Flagstones of Trokair"),
            new SampleCard(3, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(1, "Selesnya Sanctuary"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(2, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Vesuva"),
            new SampleCard(3, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Arasta of the Endless Web"),
            new SampleCard(2, "Aven Mindcensor"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(3, "Path to Exile") 
        };
    }
}