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
#18 LalauWBA: Burn (RG)
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
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck02_egadd2894_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck03_rohuty_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck04_LordBeerus_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_SonicSmasher_Uroza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Tutuzinho_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_tangrams_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Bugsy69_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck09_brunocaffaro_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck10_Blitzlion27_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Tyerube1618_DiceFactoryTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "DiceFactoryTron",
                null
            );
        }

        [Test]
        public void Deck12_ImAFireHydrant_DiceFactoryTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "DiceFactoryTron",
                null
            );
        }

        [Test]
        public void Deck13_maybenextime_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_swff_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_brettploussard_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck16_quinniac_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck17_achillies27_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.URG,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck18_LalauWBA_Burn_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck19_Jadacant_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Bolawarrior_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_OderusUrungus_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck22_Xwhale_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "DiceFactoryTron",
                null
            );
        }

        [Test]
        public void Deck23_SourceOdin_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck24_fistfullofmetal_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck25_Jakethejakel_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-25",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.URG,
                "GiftsStorm",
                null,
                null
            );
        }


    }
}
