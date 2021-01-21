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
#01 CrusherBotBG: Hammer Time (W, Lurrus)
#02 ichi-roku: Ad Nauseam (WUB)
#03 Gerardo94: WURG Control (WURG)
#04 McWinSauce: WURG Control (WURG)
#05 katoriarch123: WURG Control (WURG)
#06 mashmalovsky: Ad Nauseam (WUB)
#07 Traft: Rogues (UB, Lurrus)
#08 mikeleee: Shadow Prowess (BR, Lurrus)
#09 Chichichi: Izzet Prowess (UR)
#10 katuo079595: Rakdos Midrange (BR)
#11 darius89: Ad Nauseam (WUB)
#12 naddyeffintabs: Hammer Time (W, Lurrus)
#13 JaZzA97fc: Heliod Combo (WG)
#14 heyakita: Omnath Saheeli (WURG, Yorion)
#15 pedrogush: Hammer Time (WB, Lurrus)
#16 Mateusf34: Eldrazi Tron (C)
#17 Rinko: Enduring Ideal (WR)
#18 Lukas261997: Shadow Prowess (BR, Lurrus)
#19 N3to: Gifts Storm (UR)
#20 UmekawaneikU: Shadow Prowess (BR, Lurrus)
#21 Fastfake: Hammer Time (W, Lurrus)
#22 Magic_Dan: Shadow Prowess (WBR, Lurrus)
#23 joncos: Hammer Time (WB, Lurrus)
#24 MaxCapone: Oops All Spells (WUBG)
#25 nazart: Heliod Combo (WG)
#26 fabee1: Izzet Prowess (UR)
#27 SoulStrong: Reclamation (UBG)
#28 Pintogeddon2: Belcher (URG)
#29 patheus_84: Belcher (URG)
#30 MarioBBrega: Shadow Prowess (BRG, Lurrus)
#31 __BMJ__: Thopter Urza (WUB)
#32 FerMTG: Rakdos Midrange (BR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_12_28 : EventTest
    {
        [Test]
        public void Deck01_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",0),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_ichiroku_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",1),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",3),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_katoriarch123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",4),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",5),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Traft_Rogues_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",6),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Rogues",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_mikeleee_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",7),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Chichichi_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",8),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck10_katuo079595_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",9),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_darius89_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",10),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck12_naddyeffintabs_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",11),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_JaZzA97fc_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",12),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck14_heyakita_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",13),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_pedrogush_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",14),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",15),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck17_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",16),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "EnduringIdeal",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Lukas261997_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",17),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",18),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck20_UmekawaneikU_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",19),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Fastfake_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",20),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_MagicDan_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",21),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_joncos_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",22),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_MaxCapone_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",23),
                "PostZendikarRising",
                ArchetypeColor.WUBG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck25_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",24),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck26_fabee1_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",25),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck27_SoulStrong_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",26),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Pintogeddon2_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",27),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck29_patheus84_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",28),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck30_MarioBBrega_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",29),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_BMJ_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",30),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck32_FerMTG_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",31),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
