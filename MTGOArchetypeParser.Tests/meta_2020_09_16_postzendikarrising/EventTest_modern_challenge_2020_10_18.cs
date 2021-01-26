using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 NHA37: Heliod Combo (W)
#02 FreakNightmare: Oops All Spells (WUBRG)
#03 The_nayr: Mono Red Prowess (R, Jegantha)
#04 TwistedWombat: Omnath Saheeli (WURG, Jegantha)
#05 Sodeq: Dredge (BRG)
#06 MoxSquirrel: Mill (UB, Lurrus)
#07 cicciogire: WURG Control (WURG)
#08 exoticherman: Jund Shadow (BRG)
#09 stayrospet: Shadow Prowess (BR, Lurrus)
#10 seasonofmists: Abzan Blink (WBG)
#11 HouseOfManaMTG: Amulet Titan (RG)
#12 DarkestMage: Mono White Taxes (W)
#13 last7stand: Green Tron (G)
#14 PTarts2win: WURG Control (WURG)
#15 Gobern: Omnath Saheeli (WURG, Jegantha)
#16 AstralPlane: Omnath Saheeli (WURG, Jegantha)
#17 DaniMRebel: Spirits (WU)
#18 Xwhale: Reclaimer Titan (WRG)
#19 MIkepick7: Eldrazi Tron (C)
#20 Humpaa: Heliod Combo (WG)
#21 POOBMASTER: Shadow Prowess (BR, Lurrus)
#22 daibloXSC: Jeskai Control (WUR)
#23 NuBlkAu: Rakdos Shadow (BR)
#24 pbarrrgh: Reclamation (UBG)
#25 eclipse4343: Azorius Control (WU)
#26 Moniz0801: Amulet Titan (RG)
#27 yamakiller: Obosh Aggro (R, Obosh)
#28 Metcalf23: Mono White Taxes (W)
#29 staffmat1992: Dredge (BRG)
#30 Oderus Urungus: Humans (WUBRG)
#31 fabee1: Mono White Taxes (W)
#32 quinniac: Obosh Aggro (R, Obosh)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_10_18 : EventTest
    {
        [Test]
        public void Deck01_NHA37_HeliodCombo_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",0),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck02_FreakNightmare_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",1),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Thenayr_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",2),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_TwistedWombat_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",3),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",4),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck06_MoxSquirrel_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",5),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_cicciogire_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",6),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_exoticherman_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",7),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck09_stayrospet_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",8),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_seasonofmists_AbzanBlink_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",9),
                "PostZendikarRising",
                ArchetypeColor.WBG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck11_HouseOfManaMTG_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",10),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck12_DarkestMage_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",11),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck13_last7stand_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",12),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck14_PTarts2win_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",13),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Gobern_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",14),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck16_AstralPlane_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",15),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck17_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",16),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",17),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck19_MIkepick7_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",18),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck20_Humpaa_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",19),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck21_POOBMASTER_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",20),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_daibloXSC_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",21),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_NuBlkAu_RakdosShadow_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",22),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck24_pbarrrgh_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",23),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck25_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",24),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Moniz0801_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",25),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck27_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",26),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck28_Metcalf23_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",27),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck29_staffmat1992_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",28),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck30_OderusUrungus_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",29),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck31_fabee1_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",30),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck32_quinniac_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",31),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }


    }
}
