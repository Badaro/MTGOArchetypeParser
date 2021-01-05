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
#01 Bayesta_93: Shadow Prowess (BR, Lurrus)
#02 Do0mSwitch: WURG Control (WURG)
#03 Mordeka1ser: Niv To Light (WUBRG, Yorion)
#04 Tiemuuu: Izzet Control (UR)
#05 kanister: Dimir Control (UB)
#06 AstralPlane: Izzet Prowess (UR)
#07 fradev1988: Izzet Restore Balance (UR)
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
#20 TBxGreenguy: Bant Spirits (WUG)
#21 SebastianStueckl: Gruul Midrange (RG)
#22 Jenara19: WURG Control (WURG)
#23 Pomeelo98: E Tron (C)
#24 Delthar: Mill (UB)
#25 maicmaic: Shadow Prowess (BR, Lurrus)
#26 Better_than_Average: Obosh Aggro (R, Obosh)
#27 Nytrox: Heliod Combo (WG)
#28 sleightofhand94: Mono White Taxes (W)
#29 ht991122: WURG Control (WURG)
#30 Kiwairay: Oops All Spells (WUBG)
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
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Mordeka1ser_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",2),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",3),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_kanister_DimirControl_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",4),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_AstralPlane_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",5),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck07_fradev1988_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",6),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck08_SoulStrong_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",7),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck09_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",8),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_UmekawaneikU_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",9),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Naisirc_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",10),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_JustBurn420_Burn_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",11),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Daniele123_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",12),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",13),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_musasabi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",14),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_KaizerKahn_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",15),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Falcon_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",16),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",17),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Antus94_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",18),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_TBxGreenguy_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",19),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck21_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",20),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Jenara19_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",21),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Pomeelo98_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",22),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Delthar_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",23),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck25_maicmaic_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",24),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_BetterthanAverage_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",25),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck27_Nytrox_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",26),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck28_sleightofhand94_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",27),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck29_ht991122_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",28),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Kiwairay_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",29),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck31_IPsychonaut_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",30),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_Tweedel_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-16",31),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
