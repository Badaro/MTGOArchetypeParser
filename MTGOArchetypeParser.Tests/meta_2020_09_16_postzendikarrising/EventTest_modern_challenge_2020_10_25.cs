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
#01 coliobeware: Jund Midrange (BRG, Lurrus)
#02 Erik157751: Crabvine (UBG)
#03 Ma7x: Niv To Light (WUBRG, Jegantha)
#04 MiguelCaster: Orzhov Taxes (WB)
#05 guiyote: Izzet Prowess (UR)
#06 Exoline: WURG Control (WURG)
#07 fingers1991: WURG Control (WURG)
#08 Rav104: Oops All Spells (WUBRG)
#09 GombleWhop: Humans (WUBRG)
#10 DarkestMage: Jund Midrange (BRG)
#11 An_Actual_Potato: Humans (WUBRG)
#12 tuckbear: Sultai Midrange (UBG)
#13 fabee1: Saheeli Combo (WUR)
#14 DrDree: Humans (WUBRG)
#15 albert62: WURG Control (WURG)
#16 xstaytrue1102: Jund Midrange (BRG)
#17 Irra0770: Green Tron (G)
#18 TheKG: Omnath Saheeli (WURG, Jegantha)
#19 oracle888: Shadow Prowess (BR, Lurrus)
#20 PietroSas: Devoted (WG, Lurrus)
#21 Larry11: Izzet Prowess (UR)
#22 SpiderSpace: Inverter Combo (UB)
#23 mario7389: Burn (WRG)
#24 SweetIto: Heliod Combo (WG)
#25 MastaHorus: Electro End (UR)
#26 slow_brz: Infect (BG)
#27 Gobern: Reclamation (UBG)
#28 rofelos: WURG Control (WURG)
#29 AstralPlane: Omnath Saheeli (WURG, Jegantha)
#30 QuaCk QuaCk: Humans (WUBRG)
#31 Soondubu: Heliod Combo (WG)
#32 stayrospet: Oops All Spells (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_10_25 : EventTest
    {
        [Test]
        public void Deck01_coliobeware_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",0),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Erik157751_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",1),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Ma7x_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",2),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_MiguelCaster_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",3),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck05_guiyote_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",4),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck06_Exoline_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",5),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_fingers1991_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",6),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Rav104_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",7),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck09_GombleWhop_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",8),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck10_DarkestMage_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",9),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_AnActualPotato_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",10),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck12_tuckbear_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",11),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_fabee1_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",12),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "SaheeliCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck14_DrDree_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",13),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck15_albert62_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",14),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_xstaytrue1102_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",15),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Irra0770_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",16),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck18_TheKG_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",17),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck19_oracle888_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",18),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_PietroSas_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",19),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Larry11_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",20),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck22_SpiderSpace_InverterCombo_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",21),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "InverterCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck23_mario7389_Burn_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",22),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck24_SweetIto_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",23),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck25_MastaHorus_ElectroEnd_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",24),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroEnd",
                null
            );
        }

        [Test]
        public void Deck26_slowbrz_Infect_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",25),
                "PostZendikarRising",
                ArchetypeColor.BG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Gobern_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",26),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck28_rofelos_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",27),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck29_AstralPlane_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",28),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck30_QuaCkQuaCk_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",29),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Soondubu_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",30),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck32_stayrospet_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-25",31),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }


    }
}
