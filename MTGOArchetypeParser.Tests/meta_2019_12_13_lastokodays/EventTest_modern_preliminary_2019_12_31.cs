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
#01 McWinSauce: Bant Control (WUG)
#02 iDaveW: Infect (UG)
#03 TrueHero: Affinity (C)
#04 yamakiller: Green Devotion (G)
#05 Xwhale: Eldrazi Tron (C)
#06 KelMasterP: Thopter Urza (U)
#07 SoulStrong: Urza Oko (UG)
#08 Iplantz: Devoted (WUG)
#09 shadow_PT: Burn (R)
#10 SourceOdin: Urza Oko (UG)
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
#28 MentalMisstep: Thopter Urza (UBG)
#29 MLupa: Gifts Storm (UR)
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
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_iDaveW_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",1),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck03_TrueHero_Affinity_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",2),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Affinity),
                null,
                null
            );
        }

        [Test]
        public void Deck04_yamakiller_GreenDevotion_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",3),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(GreenDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Xwhale_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",4),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck06_KelMasterP_ThopterUrza_U()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",5),
                new LastOkoDays(),
                ArchetypeColor.U,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck07_SoulStrong_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",6),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Iplantz_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",7),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck09_shadowPT_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",8),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck10_SourceOdin_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",9),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck11_tangrams_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",10),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ERUERUFU_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",11),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck13_BernardoDG_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",12),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",13),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Batutinha_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",14),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck16_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",15),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck17_HolyShamgar_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",16),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Bullz0Eye_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",17),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Mulldrifter_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",18),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck20_Zacherry124_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",19),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck21_willpulliam_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",20),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_GGoggles_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",21),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck23_Icteridae_UrzaOko_URG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",22),
                new LastOkoDays(),
                ArchetypeColor.URG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Nammersquats_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",23),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",24),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck26_phyrexianphenom3_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",25),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",26),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck28_MentalMisstep_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",27),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck29_MLupa_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",28),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Midocon_MonoGreenMidrange_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",29),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_ZYURYO_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-31",30),
                new LastOkoDays(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
