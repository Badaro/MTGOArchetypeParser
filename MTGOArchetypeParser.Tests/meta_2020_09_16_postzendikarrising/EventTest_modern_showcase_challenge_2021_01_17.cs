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
#01 Ryan100495: Dredge (BRG)
#02 DoctorQueller: Spirits (WU)
#03 Pmizz: Hammer Time (W, Lurrus)
#04 SknerusMcKwacz: Oops All Spells (WUBRG)
#05 GR_DONKIN: Ad Nauseam (WUB)
#06 SanPop: Mill (UB, Lurrus)
#07 fpawlusz: Amulet Titan (G)
#08 ColdPier: Jund Midrange (BRG)
#09 VTCLA: WURG Control (WURG)
#10 _Shatun_: Obosh Aggro (R, Obosh)
#11 JV_7777: Hammer Time (WB, Lurrus)
#12 nazart: Heliod Combo (WG)
#13 nsroller: Shadow Prowess (BR, Lurrus)
#14 Violent_Outburst: Scapeshift (WURG)
#15 PietroSas: Hammer Time (WB, Lurrus)
#16 Skrown: Shadow Prowess (BR, Lurrus)
#17 indianpancake: Sultai Control (UBG)
#18 UrbanPope: Burn (WR)
#19 Smdster: Heliod Combo (WR)
#20 kthanakit26: Izzet Prowess (UR)
#21 Nerdkneereape: Infect (UG)
#22 Gleiciano: Green Tron (G, Jegantha)
#23 PeanutBrittle: WURG Control (WURG)
#24 marolanzi: Burn (WR)
#25 Alan07: Oops All Spells (WUBG)
#26 hodortimebaby: WURG Control (WURG)
#27 HummingBard: Izzet Control (UR)
#28 1yo2yo: Reclamation (UBG)
#29 BaronOfBacon: Shadow Prowess (BR, Lurrus)
#30 SuperCow12653: Heliod Combo (WG)
#31 Xwhale: Reclaimer Titan (WRG)
#32 Mazzu93: Shadow Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_showcase_challenge_2021_01_17 : EventTest
    {
        [Test]
        public void Deck01_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",0),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck02_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",1),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Pmizz_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",2),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_SknerusMcKwacz_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",3),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck05_GRDONKIN_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",4),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck06_SanPop_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",5),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_fpawlusz_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",6),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_ColdPier_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",7),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_VTCLA_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",8),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Shatun_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",9),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_JV7777_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",10),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",11),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck13_nsroller_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",12),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_ViolentOutburst_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",13),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck15_PietroSas_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",14),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Skrown_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",15),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_indianpancake_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",16),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_UrbanPope_Burn_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",17),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck19_Smdster_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",18),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck20_kthanakit26_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",19),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck21_Nerdkneereape_Infect_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",20),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Gleiciano_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",21),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck23_PeanutBrittle_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",22),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck24_marolanzi_Burn_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",23),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck25_Alan07_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",24),
                "PostZendikarRising",
                ArchetypeColor.WUBG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck26_hodortimebaby_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",25),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck27_HummingBard_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",26),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck28_1yo2yo_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",27),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck29_BaronOfBacon_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",28),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_SuperCow12653_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",29),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",30),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck32_Mazzu93_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2021-01-17",31),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
