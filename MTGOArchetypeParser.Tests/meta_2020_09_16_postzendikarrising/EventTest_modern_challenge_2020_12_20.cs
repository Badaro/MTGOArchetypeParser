using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 dough_shack: Scapeshift (URG)
#02 MaxCapone: Oops All Spells (WUBG)
#03 IzzetSignetIsTheBest: Reclaimer Titan (WG)
#04 Laplasjan: Hammer Time (WB, Lurrus)
#05 bolov0: Rakdos Midrange (BR)
#06 MastaHorus: Electro End (UR)
#07 Samcaster-Mage: Eldrazi Tron (C)
#08 The_nayr: Obosh Aggro (R, Obosh)
#09 ShowTime_: Burn (WR)
#10 Xwhale: Reclaimer Titan (WG)
#11 TSPJendrek: Sultai Control (UBG)
#12 Ozymandias17: Rakdos Midrange (BR)
#13 patheus_84: Belcher (URG)
#14 joetru: Jund Midrange (BRG)
#15 aManatease: Izzet Prowess (UR)
#16 MrSeri: Hardened Scales (G)
#17 bladede: Jund Midrange (BRG)
#18 nazart: Heliod Combo (WRG)
#19 thekingofnone: Green Tron (G, Jegantha)
#20 elquinielas: Burn (WBRG)
#21 mark_68: Reclamation (UBG, Yorion)
#22 fabee1: Boros Taxes (WR)
#23 Kuhb: Hammer Time (WB, Lurrus)
#24 FerMTG: Heliod Combo (WG)
#25 _IlNano_: Shadow Prowess (BR, Lurrus)
#26 eggybenny: Heliod Combo (WG)
#27 mlex: Dredge (BRG)
#28 KO_Mak: Oops All Spells (UBG)
#29 ice_nine_: Land Destruction (WR)
#30 daibloXSC: Erayo Prison (WUB)
#31 aspiringspike: Jeskai Control (WUR)
#32 pokerswizard: Shadow Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_12_20 : EventTest
    {
        [Test]
        public void Deck01_doughshack_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",0),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck02_MaxCapone_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",1),
                "PostZendikarRising",
                ArchetypeColor.WUBG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck03_IzzetSignetIsTheBest_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",2),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck04_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",3),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_bolov0_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",4),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_MastaHorus_ElectroEnd_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",5),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroEnd",
                null
            );
        }

        [Test]
        public void Deck07_SamcasterMage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",6),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_Thenayr_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",7),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck09_ShowTime_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",8),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck10_Xwhale_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",9),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck11_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",10),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Ozymandias17_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",11),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_patheus84_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",12),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck14_joetru_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",13),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_aManatease_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",14),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck16_MrSeri_HardenedScales_G()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",15),
                "PostZendikarRising",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck17_bladede_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",16),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck18_nazart_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",17),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck19_thekingofnone_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",18),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck20_elquinielas_Burn_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",19),
                "PostZendikarRising",
                ArchetypeColor.WBRG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck21_mark68_Reclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",20),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck22_fabee1_BorosTaxes_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",21),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Kuhb_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",22),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_FerMTG_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",23),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck25_IlNano_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",24),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_eggybenny_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",25),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck27_mlex_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",26),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck28_KOMak_OopsAllSpells_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",27),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck29_icenine_LandDestruction_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",28),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "LandDestruction",
                null,
                null
            );
        }

        [Test]
        public void Deck30_daibloXSC_ErayoPrison_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",29),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "ErayoPrison",
                null,
                null
            );
        }

        [Test]
        public void Deck31_aspiringspike_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",30),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_pokerswizard_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",31),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
