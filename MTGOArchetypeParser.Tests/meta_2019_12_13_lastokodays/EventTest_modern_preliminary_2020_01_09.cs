using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Coly2: Mono Red Prowess (R)
#02 zman2340: Thopter Urza (UBG)
#03 FunkiMunki: Urza Oko (URG)
#04 JustBurn420: Slivers (WUBRG)
#05 Oderus Urungus: Mono Red Prowess (R)
#06 xfile: Eldrazi Tron (G)
#07 McWinSauce: Bant Control (WUG)
#08 pepeisra: Urza Oko (URG)
#09 Butakov: Eldrazi Tron (C)
#10 Giaws: Grixis Shadow (UBR)
#11 _Shatun_: Bogles (WG)
#12 limp22: Bant Midrange (WUG)
#13 CADYstrophic: Cheeri 0s (WUBRG)
#14 Folero: Infect (UG)
#15 ACG88: Titan Shift (RG)
#16 aaronsolon: Gifts Storm (UR)
#17 SourceOdin: Urza Oko (WUG)
#18 Morenothings: Urza Oko (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_09 : EventTest
    {
        [Test]
        public void Deck01_Coly2_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",0),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck02_zman2340_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",1),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck03_FunkiMunki_UrzaOko_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",2),
                "LastOkoDays",
                ArchetypeColor.URG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck04_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",3),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck05_OderusUrungus_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",4),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck06_xfile_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",5),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",6),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_pepeisra_UrzaOko_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",7),
                "LastOkoDays",
                ArchetypeColor.URG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Butakov_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",8),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck10_Giaws_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",9),
                "LastOkoDays",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Shatun_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",10),
                "LastOkoDays",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck12_limp22_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",11),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_CADYstrophic_Cheeri0s_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",12),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Cheeri0s",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Folero_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",13),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck15_ACG88_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",14),
                "LastOkoDays",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck16_aaronsolon_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",15),
                "LastOkoDays",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck17_SourceOdin_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",16),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Morenothings_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-09",17),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "UrzaOko",
                null,
                null
            );
        }


    }
}
