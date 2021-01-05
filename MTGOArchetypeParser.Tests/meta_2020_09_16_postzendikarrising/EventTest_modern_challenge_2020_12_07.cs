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
#01 Sodeq: Dredge (BRG)
#02 AnneLivleysD3ath: Amulet Titan (G)
#03 katoriarch123: WURG Control (WURG)
#04 hugeomanyte: Shadow Prowess (BR, Lurrus)
#05 FerMTG: Rakdos Midrange (BR)
#06 Mateusf34: E Tron (C)
#07 EmErgy: Mill (UB, Lurrus)
#08 Blitzlion27: Mill (UB, Lurrus)
#09 ho-oh: Oops All Spells (WUBG)
#10 CrusherBotBG: Hammer Time (W, Lurrus)
#11 Naisirc: Obosh Aggro (R, Obosh)
#12 g3r2: Gifts Storm (UR)
#13 Do0mSwitch: WURG Control (WURG)
#14 nsroller: Heliod Combo (WG)
#15 TSPJendrek: Sultai Control (UBG)
#16 yumad3988: Primeval Titan (UG)
#17 SvenSveeterSven: Mardu Midrange (WBR)
#18 ACG88: Gifts Storm (UR)
#19 toondoslav: Obosh Aggro (R, Obosh)
#20 __BMJ__: WURG Control (WURG)
#21 Ryan100495: Dredge (BRG)
#22 _Caverna_: Snoop Goblins (BR)
#23 DEADPOOLx97: Shadow Prowess (BR, Lurrus)
#24 naddyeffintabs: Shadow Prowess (BR, Lurrus)
#25 Radziolot: Mono White Taxes (W)
#26 _Falcon_: Snoop Goblins (BR)
#27 RelativeWind: Ad Nauseam (WUB)
#28 ZYURYO: UBRG Control (UBRG)
#29 Nikachu: Merfolk (UG)
#30 MastaHorus: Izzet Living End (UR)
#31 Ryan_39: Sultai Control (UBG)
#32 Gigy: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_12_07 : EventTest
    {
        [Test]
        public void Deck01_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",0),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck02_AnneLivleysD3ath_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",1),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck03_katoriarch123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_hugeomanyte_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",3),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_FerMTG_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",5),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_EmErgy_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",6),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Blitzlion27_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",7),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_hooh_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",8),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck10_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",9),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Naisirc_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",10),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck12_g3r2_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",11),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",12),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_nsroller_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",13),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck15_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",14),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_yumad3988_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",15),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck17_SvenSveeterSven_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",16),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_ACG88_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",17),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck19_toondoslav_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",18),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck20_BMJ_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",19),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",20),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Caverna_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",21),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck23_DEADPOOLx97_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",22),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_naddyeffintabs_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",23),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Radziolot_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",24),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Falcon_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",25),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck27_RelativeWind_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",26),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck28_ZYURYO_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",27),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Nikachu_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",28),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck30_MastaHorus_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",29),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck31_Ryan39_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",30),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",31),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
