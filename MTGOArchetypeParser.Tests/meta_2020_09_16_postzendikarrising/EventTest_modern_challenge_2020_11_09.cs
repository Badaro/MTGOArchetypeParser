using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Samcaster-Mage: Eldrazi Tron (C)
#02 Tiemuuu: Izzet Control (UR)
#03 CordoTwin: Shadow Prowess (BR, Lurrus)
#04 Jenara19: Amulet Titan (RG)
#05 Mordeka1ser: Niv To Light (WUBRG, Yorion)
#06 paucr5: Devoted (WG, Lurrus)
#07 Moniz0801: Amulet Titan (G)
#08 Kurusu: Kiki Chord (WRG, Yorion)
#09 Laplasjan: Devoted (WG, Lurrus)
#10 Mateusf34: Eldrazi Tron (C)
#11 DenebLyrae: Heliod Combo (WG)
#12 Sodeq: Oops All Spells (WUBRG)
#13 Nytrox: Heliod Combo (WG)
#14 Mlgb92: Izzet Prowess (UR)
#15 _Batutinha_: Reclaimer Titan (WRG)
#16 mmapson125: Heliod Combo (WG)
#17 oosunq: Omnath Saheeli (WURG, Jegantha)
#18 GodOfSlaughter: WURG Control (WURG)
#19 Better_than_Average: Oops All Spells (WUBRG)
#20 Mogged: Mono Red Prowess (R)
#21 tibalt_of_red_sub: Mill (UB, Lurrus)
#22 PRGJJAR: Dredge (BRG)
#23 Easyldur1: Dredge (BRG)
#24 toondoslav: Infect (UG)
#25 Benkill: Spirits (WU)
#26 BSK_hercules: Sultai Control (UBG)
#27 sleightofhand94: Mono White Taxes (W)
#28 Gigy: Gruul Midrange (RG)
#29 DaniMRebel: Mono White Taxes (W)
#30 random_deck: Selesnya Midrange (WG)
#31 sokos13: Infect (UG)
#32 ZYURYO: WURG Control (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_11_09 : EventTest
    {
        [Test]
        public void Deck01_SamcasterMage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",0),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck02_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",1),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_CordoTwin_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",2),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Jenara19_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",3),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck05_Mordeka1ser_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",4),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_paucr5_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",5),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Moniz0801_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",6),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",7),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "KikiChord",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",8),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",9),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck11_DenebLyrae_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",10),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Sodeq_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",11),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Nytrox_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",12),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Mlgb92_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",13),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck15_Batutinha_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",14),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck16_mmapson125_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",15),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck17_oosunq_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",16),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck18_GodOfSlaughter_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",17),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck19_BetterthanAverage_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",18),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Mogged_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",19),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck21_tibaltofredsub_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",20),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",21),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Easyldur1_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",22),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck24_toondoslav_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",23),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck25_Benkill_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",24),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck26_BSKhercules_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",25),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck27_sleightofhand94_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",26),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",27),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck29_DaniMRebel_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",28),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck30_randomdeck_SelesnyaMidrange_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",29),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck31_sokos13_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",30),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck32_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-09",31),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
