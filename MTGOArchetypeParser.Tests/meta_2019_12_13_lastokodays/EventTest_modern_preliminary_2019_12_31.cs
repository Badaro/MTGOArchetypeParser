using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 McWinSauce: Bant Control (WUG)
#02 iDaveW: Infect (UG)
#03 TrueHero: Affinity (R)
#04 yamakiller: Green Devotion (RG)
#05 Xwhale: Eldrazi Tron (G)
#06 KelMasterP: Thopter Urza (UBG)
#07 SoulStrong: Urza Oko (UBG)
#08 Iplantz: Devoted (WUG)
#09 shadow_PT: Burn (R)
#10 SourceOdin: Urza Oko (WUG)
#11 tangrams: Primeval Titan (UG)
#12 ERUERUFU: Burn (R)
#13 BernardoDG: Eldrazi Tron (C)
#14 Do0mSwitch: Bant Control (WUG)
#15 _Batutinha_: Primeval Titan (UG)
#16 sandydogmtg: Burn (R)
#17 HolyShamgar: Primeval Titan (UG)
#18 Bullz0Eye: Primeval Titan (UG)
#19 Mulldrifter: Eldrazi Tron (C)
#20 Zacherry124: Urza Oko (UG)
#21 willpulliam: Amulet Titan (UG)
#22 GGoggles: Eldrazi Tron (C)
#23 Icteridae: Urza Oko (URG)
#24 Nammersquats: Bant Midrange (WUG)
#25 Sodeq: Dredge (BRG)
#26 phyrexianphenom3: Infect (UG)
#27 Boland: Grixis Shadow (UBR)
#28 MentalMisstep: Thopter Urza (WUBG)
#29 MLupa: Gifts Storm (URG)
#30 Midocon: Mono Green Midrange (G)
#31 ZYURYO: UBRG Control (UBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_31 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",0),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_iDaveW_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",1),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck03_TrueHero_Affinity_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",2),
                "LastOkoDays",
                ArchetypeColor.R,
                "Affinity",
                null,
                null
            );
        }

        [Test]
        public void Deck04_yamakiller_GreenDevotion_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",3),
                "LastOkoDays",
                ArchetypeColor.RG,
                "GreenDevotion",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Xwhale_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",4),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_KelMasterP_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",5),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck07_SoulStrong_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",6),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Iplantz_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",7),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck09_shadowPT_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",8),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck10_SourceOdin_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",9),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck11_tangrams_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",10),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck12_ERUERUFU_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",11),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck13_BernardoDG_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",12),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck14_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",13),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Batutinha_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",14),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck16_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",15),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck17_HolyShamgar_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",16),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Bullz0Eye_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",17),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Mulldrifter_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",18),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck20_Zacherry124_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",19),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck21_willpulliam_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",20),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck22_GGoggles_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",21),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck23_Icteridae_UrzaOko_URG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",22),
                "LastOkoDays",
                ArchetypeColor.URG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck24_Nammersquats_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",23),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck25_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",24),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck26_phyrexianphenom3_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",25),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",26),
                "LastOkoDays",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck28_MentalMisstep_ThopterUrza_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",27),
                "LastOkoDays",
                ArchetypeColor.WUBG,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck29_MLupa_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",28),
                "LastOkoDays",
                ArchetypeColor.URG,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Midocon_MonoGreenMidrange_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",29),
                "LastOkoDays",
                ArchetypeColor.G,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck31_ZYURYO_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",30),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
