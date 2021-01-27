using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 kogamo: WURG Control (WURG)
#02 thedoc96: Shadow Prowess (BR, Lurrus)
#03 jvidarte: Burn (WR, Lurrus)
#04 yuyan: WURG Control (WURG)
#05 taraaasyk: Izzet Prowess (UR)
#06 Laplasjan: Hammer Time (WB, Lurrus)
#07 _Batutinha_: WURG Control (WURG)
#08 rastaf: Izzet Prowess (UR)
#09 billsive: WURG Control (WURG)
#10 cntrlfreak: UBRG Shadow (UBRG)
#11 kthanakit26: Izzet Prowess (UR)
#12 joker10289: Reclamation (UBG)
#13 BoltTheBirds: Gifts Storm (UR)
#14 Hemsley: Mill (UB, Lurrus)
#15 GanYanCHN: Amulet Titan (G)
#16 hugofreitas1: Gifts Storm (UR)
#17 qbturtle15: Burn (WR)
#18 N3to: Gifts Storm (UR)
#19 Sonso JF: Shadow Prowess (BRG, Lurrus)
#20 CLYDE THE GLIDE DREXLER: Burn (WR)
#21 bolov0: Izzet Prowess (UR)
#22 Conor_man11: Hammer Time (WB, Lurrus)
#23 zachattack23: WURG Control (WURG)
#24 Gigy: Shadow Prowess (BR, Lurrus)
#25 FestiFan: Reclamation (WUBG)
#26 mrjkl: Izzet Prowess (UR)
#27 toyokwsk: Mill (UB, Lurrus)
#28 TscheggschDePoegg: Dredge (BRG)
#29 Ikashy: Belcher (URG)
#30 medvedev: Spirits (WU)
#31 eclipse4343: Miracles (WU)
#32 Binolino: Amulet Titan (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_super_qualifier_2021_01_24 : EventTest
    {
        [Test]
        public void Deck01_kogamo_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",0),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_thedoc96_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",1),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",2),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_yuyan_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",3),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_taraaasyk_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",4),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck06_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",5),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Batutinha_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",6),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_rastaf_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",7),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_billsive_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",8),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_cntrlfreak_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",9),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck11_kthanakit26_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",10),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck12_joker10289_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",11),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck13_BoltTheBirds_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",12),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Hemsley_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",13),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_GanYanCHN_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",14),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck16_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",15),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck17_qbturtle15_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",16),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck18_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",17),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck19_SonsoJF_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",18),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_CLYDETHEGLIDEDREXLER_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",19),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck21_bolov0_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",20),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck22_Conorman11_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",21),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_zachattack23_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",22),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck24_Gigy_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",23),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_FestiFan_Reclamation_WUBG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",24),
                "PostZendikarRising",
                ArchetypeColor.WUBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck26_mrjkl_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",25),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck27_toyokwsk_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",26),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_TscheggschDePoegg_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",27),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Ikashy_Belcher_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",28),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck30_medvedev_Spirits_WU()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",29),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck31_eclipse4343_Miracles_WU()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",30),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Miracles",
                null,
                null
            );
        }

        [Test]
        public void Deck32_Binolino_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-24",31),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }


    }
}
