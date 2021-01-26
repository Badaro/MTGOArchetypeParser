using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Usama96: WURG Control (WURG)
#02 patheus_84: Ad Nauseam (WUB)
#03 O_danielakos: Izzet Prowess (UR)
#04 pedrogush: Hammer Time (WB, Lurrus)
#05 NorrathDecay: Burn (WR)
#06 ACG88: Humans (WUBRG)
#07 UmekawaneikU: Izzet Prowess (UR)
#08 SwordHunter: WURG Control (WURG)
#09 FerMTG: Azorius Control (WU)
#10 MarySue: Shadow Prowess (BR, Lurrus)
#11 nazart: Heliod Combo (WG)
#12 BigB3N: Temur Control (URG)
#13 maxbv: Mono White Taxes (W)
#14 wild88plk: Hammer Time (WG, Lurrus)
#15 DejoyOfGaming: WURG Control (WURG)
#16 SoulStrong: Shadow Prowess (BR, Lurrus)
#17 kanister: Dimir Control (UB)
#18 Wuhsa: Niv To Light (WUBRG, Yorion)
#19 B1gDan: Shadow Prowess (BRG, Lurrus)
#20 DreamsOfAshiok: Eldrazi Tron (R)
#21 Karnesis93: Shadow Prowess (BR, Lurrus)
#22 DenebLyrae: Heliod Combo (WRG)
#23 ArchaeusDota: Thopter Urza (UB)
#24 Lord_of_Puntlantis: Mill (UB, Lurrus)
#25 Nastier: Rakdos Midrange (BR)
#26 Blitzlion27: Mill (UB, Lurrus)
#27 sokos13: Infect (UG)
#28 Mazzu93: Izzet Prowess (UR)
#29 Harry13: Reclamation (UBG)
#30 Gigy: Shadow Prowess (BR, Lurrus)
#31 PieGonti: Hammer Time (WB, Lurrus)
#32 Magic_Dan: Shadow Prowess (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2021_01_25 : EventTest
    {
        [Test]
        public void Deck01_Usama96_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",0),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",1),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Odanielakos_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",2),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck04_pedrogush_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",3),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",4),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck06_ACG88_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",5),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck07_UmekawaneikU_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",6),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck08_SwordHunter_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_FerMTG_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",8),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_MarySue_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",9),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",10),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck12_BigB3N_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",11),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_maxbv_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",12),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck14_wild88plk_HammerTime_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",13),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_DejoyOfGaming_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",14),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_SoulStrong_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",15),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_kanister_DimirControl_UB()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",16),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Wuhsa_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",17),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_B1gDan_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",18),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_DreamsOfAshiok_EldraziTron_R()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",19),
                "PostZendikarRising",
                ArchetypeColor.R,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck21_Karnesis93_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",20),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_DenebLyrae_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",21),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck23_ArchaeusDota_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",22),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck24_LordofPuntlantis_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",23),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Nastier_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",24),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Blitzlion27_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",25),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_sokos13_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",26),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Mazzu93_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",27),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck29_Harry13_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",28),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Gigy_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",29),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_PieGonti_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",30),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_MagicDan_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-25",31),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
