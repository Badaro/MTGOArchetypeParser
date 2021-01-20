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
#27 SoulStrong: Sultai Control (UBG)
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
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_ichiroku_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",1),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_katoriarch123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",4),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",5),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Traft_Rogues_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",6),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Rogues),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_mikeleee_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",7),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Chichichi_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",8),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck10_katuo079595_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",9),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_darius89_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",10),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck12_naddyeffintabs_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",11),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_JaZzA97fc_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",12),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck14_heyakita_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",13),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_pedrogush_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",14),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",15),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck17_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",16),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Lukas261997_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",17),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",18),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck20_UmekawaneikU_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",19),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Fastfake_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",20),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_MagicDan_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",21),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_joncos_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",22),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_MaxCapone_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",23),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck25_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",24),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck26_fabee1_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",25),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck27_SoulStrong_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",26),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Pintogeddon2_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",27),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck29_patheus84_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",28),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck30_MarioBBrega_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",29),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_BMJ_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",30),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck32_FerMTG_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-28",31),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
