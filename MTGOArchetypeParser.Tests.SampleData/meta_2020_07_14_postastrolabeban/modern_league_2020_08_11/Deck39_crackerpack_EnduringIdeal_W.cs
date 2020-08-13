using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck39_crackerpack_EnduringIdeal_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Enduring Ideal"),
            new SampleCard(4, "Lotus Bloom"),
            new SampleCard(1, "Dovescape"),
            new SampleCard(2, "Form of the Dragon"),
            new SampleCard(2, "Greater Auramancy"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(4, "Nine Lives"),
            new SampleCard(1, "Oblivion Ring"),
            new SampleCard(4, "On Thin Ice"),
            new SampleCard(4, "Phyrexian Unlife"),
            new SampleCard(3, "Runed Halo"),
            new SampleCard(4, "Solemnity"),
            new SampleCard(2, "Suppression Field"),
            new SampleCard(3, "Castle Ardenvale"),
            new SampleCard(1, "Hall of Heliod's Generosity"),
            new SampleCard(4, "Nykthos, Shrine to Nyx"),
            new SampleCard(14, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Oblivion Ring"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Ghost Quarter"),
            new SampleCard(3, "Pithing Needle"),
            new SampleCard(4, "Rest in Peace"),
            new SampleCard(2, "Worship") 
        };
    }
}