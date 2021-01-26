using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Bayesta_93: Shadow Prowess (BR, Lurrus)
#02 Do0mSwitch: WURG Control (WURG)
#03 Mordeka1ser: Niv To Light (WUBRG, Yorion)
#04 Tiemuuu: Izzet Control (UR)
#05 kanister: Dimir Control (UB)
#06 AstralPlane: Izzet Prowess (UR)
#07 fradev1988: Electro Balance (URG)
#08 SoulStrong: Reclaimer Titan (WRG)
#09 nahuel10: Izzet Prowess (UR)
#10 UmekawaneikU: Shadow Prowess (BRG, Lurrus)
#11 Naisirc: Gruul Midrange (RG)
#12 JustBurn420: Burn (RG)
#13 Daniele123: Jeskai Control (WUR)
#14 jvidarte: Burn (WR, Lurrus)
#15 musasabi: Shadow Prowess (BR, Lurrus)
#16 Kaizer_Kahn: Mono Red Prowess (R)
#17 _Falcon_: Shadow Prowess (BR, Lurrus)
#18 patheus_84: Ad Nauseam (WUB)
#19 Antus94: Shadow Prowess (BRG, Lurrus)
#20 TBxGreenguy: Spirits (WUG)
#21 SebastianStueckl: Gruul Midrange (RG)
#22 Jenara19: WURG Control (WURG)
#23 Pomeelo98: Eldrazi Tron (C)
#24 Delthar: Mill (UB)
#25 maicmaic: Shadow Prowess (BR, Lurrus)
#26 Better_than_Average: Obosh Aggro (R, Obosh)
#27 Nytrox: Heliod Combo (WRG)
#28 sleightofhand94: Mono White Taxes (W)
#29 ht991122: WURG Control (WURG)
#30 Kiwairay: Oops All Spells (WUBRG)
#31 IPsychonaut: Jund Shadow (BRG, Lurrus)
#32 Tweedel: Izzet Control (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_11_16 : EventTest
    {
        [Test]
        public void Deck01_Bayesta93_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",0),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Mordeka1ser_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",2),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",3),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_kanister_DimirControl_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",4),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_AstralPlane_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",5),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck07_fradev1988_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",6),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck08_SoulStrong_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",7),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck09_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",8),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck10_UmekawaneikU_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",9),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Naisirc_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",10),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck12_JustBurn420_Burn_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",11),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck13_Daniele123_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",12),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",13),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_musasabi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",14),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_KaizerKahn_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",15),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck17_Falcon_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",16),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",17),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Antus94_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",18),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_TBxGreenguy_Spirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",19),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck21_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",20),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Jenara19_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",21),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Pomeelo98_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",22),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck24_Delthar_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",23),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck25_maicmaic_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",24),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_BetterthanAverage_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",25),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck27_Nytrox_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",26),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck28_sleightofhand94_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",27),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck29_ht991122_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",28),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Kiwairay_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",29),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck31_IPsychonaut_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",30),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_Tweedel_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",31),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }


    }
}
