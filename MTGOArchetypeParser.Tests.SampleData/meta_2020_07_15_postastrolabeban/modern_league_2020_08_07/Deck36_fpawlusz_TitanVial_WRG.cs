using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck36_fpawlusz_TitanVial_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Courser of Kruphix"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Elvish Reclaimer"),
            new SampleCard(1, "Eternal Witness"),
            new SampleCard(1, "Fierce Empath"),
            new SampleCard(2, "Golos, Tireless Pilgrim"),
            new SampleCard(2, "Primeval Titan"),
            new SampleCard(1, "Ramunap Excavator"),
            new SampleCard(2, "Sakura-Tribe Elder"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(3, "Tireless Tracker"),
            new SampleCard(1, "Woodland Bellower"),
            new SampleCard(2, "Eladamri's Call"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(2, "Castle Garenbrig"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(3, "Flagstones of Trokair"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(1, "Selesnya Sanctuary"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(3, "Temple Garden"),
            new SampleCard(2, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Vesuva"),
            new SampleCard(2, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aven Mindcensor"),
            new SampleCard(3, "Celestial Purge"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(1, "Force of Vigor"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Thragtusk") 
        };
    }
}