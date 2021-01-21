using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Sodeq: Dredge (BRG)
#02 AnneLivleysD3ath: Amulet Titan (UG)
#03 katoriarch123: WURG Control (WURG)
#04 hugeomanyte: Shadow Prowess (BR, Lurrus)
#05 FerMTG: Rakdos Midrange (BR)
#06 Mateusf34: Eldrazi Tron (C)
#07 EmErgy: Mill (UB, Lurrus)
#08 Blitzlion27: Mill (UB, Lurrus)
#09 ho-oh: Oops All Spells (WUBRG)
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
#22 _Caverna_: Goblins (BR)
#23 DEADPOOLx97: Shadow Prowess (BR, Lurrus)
#24 naddyeffintabs: Shadow Prowess (BR, Lurrus)
#25 Radziolot: Mono White Taxes (W)
#26 _Falcon_: Goblins (BR)
#27 RelativeWind: Ad Nauseam (WUB)
#28 ZYURYO: UBRG Control (UBRG)
#29 Nikachu: Merfolk (UG)
#30 MastaHorus: Electro End (UR)
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
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck02_AnneLivleysD3ath_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",1),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck03_katoriarch123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_hugeomanyte_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",3),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_FerMTG_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",4),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",5),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_EmErgy_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",6),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Blitzlion27_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",7),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_hooh_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",8),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck10_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",9),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Naisirc_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",10),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck12_g3r2_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",11),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",12),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_nsroller_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",13),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck15_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",14),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_yumad3988_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",15),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck17_SvenSveeterSven_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",16),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck18_ACG88_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",17),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck19_toondoslav_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",18),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck20_BMJ_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",19),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",20),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Caverna_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",21),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck23_DEADPOOLx97_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",22),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_naddyeffintabs_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",23),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Radziolot_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",24),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Falcon_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",25),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck27_RelativeWind_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",26),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck28_ZYURYO_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",27),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Nikachu_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",28),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck30_MastaHorus_ElectroEnd_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",29),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroEnd",
                null
            );
        }

        [Test]
        public void Deck31_Ryan39_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",30),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-07",31),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
