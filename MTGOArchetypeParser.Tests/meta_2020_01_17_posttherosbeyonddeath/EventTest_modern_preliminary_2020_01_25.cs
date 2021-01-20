using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 leclairandy: Mono Red Prowess (R)
#02 egadd2894: Amulet Titan (UG)
#03 rohuty: Infect (UG)
#04 Lord_Beerus: Azorius Control (WU)
#05 Sonic_Smasher: Uroza (UBG)
#06 Tutuzinho: WURG Control (WURG)
#07 tangrams: Primeval Titan (UG)
#08 Bugsy69: Dredge (UBRG)
#09 brunocaffaro: Eldrazi Tron (C)
#10 Blitzlion27: Primeval Titan (UG)
#11 Tyerube1618: Dice Factory Tron (G)
#12 ImAFireHydrant: Dice Factory Tron (G)
#13 maybenextime: WURG Control (WURG)
#14 swff: Bant Control (WUG)
#15 brettploussard: Mono Red Prowess (R)
#16 quinniac: Mono Red Prowess (R)
#17 achillies27: Gifts Storm (URG)
#18 LalauWBA: Gruul Prowess (RG)
#19 Jadacant: Primeval Titan (UG)
#20 _Bolawarrior_: Azorius Control (WU)
#21 Oderus Urungus: Green Tron (G)
#22 Xwhale: Dice Factory Tron (C)
#23 SourceOdin: Primeval Titan (UG)
#24 fistfullofmetal: Green Tron (G)
#25 Jakethejakel: Gifts Storm (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_01_25 : EventTest
    {
        [Test]
        public void Deck01_leclairandy_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck02_egadd2894_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck03_rohuty_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck04_LordBeerus_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_SonicSmasher_Uroza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Tutuzinho_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_tangrams_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Bugsy69_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_brunocaffaro_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_Blitzlion27_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Tyerube1618_DiceFactoryTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(DiceFactoryTron),
                null
            );
        }

        [Test]
        public void Deck12_ImAFireHydrant_DiceFactoryTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(DiceFactoryTron),
                null
            );
        }

        [Test]
        public void Deck13_maybenextime_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_swff_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_brettploussard_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck16_quinniac_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck17_achillies27_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck18_LalauWBA_GruulProwess_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck19_Jadacant_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Bolawarrior_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_OderusUrungus_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck22_Xwhale_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(DiceFactoryTron),
                null
            );
        }

        [Test]
        public void Deck23_SourceOdin_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck24_fistfullofmetal_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",23),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck25_Jakethejakel_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",24),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(GiftsStorm),
                null,
                null
            );
        }


    }
}
