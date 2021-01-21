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
#01 oinkmage: Sultai Control (UBG)
#02 SickWorld: Obosh Aggro (R, Obosh)
#03 colomo1: Spirits (WU)
#04 ishul: Shadow Prowess (BR, Lurrus)
#05 TSPJendrek: Bant Control (WUG)
#06 ColdPier: Reclaimer Titan (WG)
#07 gazmon48: Izzet Prowess (UR)
#08 Ozymandias17: Rakdos Midrange (BR)
#09 Zar0s: Electro End (UR)
#10 smoran02: Mill (UBG)
#11 Sodeq: Belcher (URG)
#12 mtgpirate: Izzet Prowess (UR)
#13 SourceOdin: Grinding Breach (URG)
#14 nazart: Heliod Combo (WG)
#15 penips: Mono White Taxes (W)
#16 Binolino: Reclaimer Titan (WBRG)
#17 billsive: Reclamation (WUG)
#18 HamburgerJung: Green Tron (G, Jegantha)
#19 MarcoBelacca95: Sultai Control (UBG)
#20 ZYURYO: WURG Control (WURG)
#21 qbturtle15: Mono White Taxes (W)
#22 trader08111: Izzet Prowess (UR)
#23 La_Biscia: UBRG Control (UBRG)
#24 pokerswizard: Obosh Aggro (R, Obosh)
#25 naddyeffintabs: Grishoalbrand (BR)
#26 Ryan100495: Dredge (BRG)
#27 bgoose321: Shadow Prowess (BRG, Lurrus)
#28 MrSeri: Hardened Scales (G)
#29 kthanakit26: Izzet Prowess (UR)
#30 scalo94: Heliod Combo (WR)
#31 Thommimp: Hammer Time (W, Lurrus)
#32 SugarMountain: Burn (WBR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2021_01_03 : EventTest
    {
        [Test]
        public void Deck01_oinkmage_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",0),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_SickWorld_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",1),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck03_colomo1_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",2),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck04_ishul_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",3),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_TSPJendrek_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",4),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_ColdPier_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",5),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck07_gazmon48_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",6),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck08_Ozymandias17_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",7),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Zar0s_ElectroEnd_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",8),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroEnd",
                null
            );
        }

        [Test]
        public void Deck10_smoran02_Mill_UBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",9),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Sodeq_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",10),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck12_mtgpirate_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",11),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck13_SourceOdin_GrindingBreach_URG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",12),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck14_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",13),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck15_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",14),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Binolino_ReclaimerTitan_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",15),
                "PostZendikarRising",
                ArchetypeColor.WBRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck17_billsive_Reclamation_WUG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",16),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck18_HamburgerJung_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",17),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck19_MarcoBelacca95_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",18),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck20_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",19),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_qbturtle15_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",20),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck22_trader08111_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",21),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck23_LaBiscia_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",22),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck24_pokerswizard_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",23),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck25_naddyeffintabs_Grishoalbrand_BR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",24),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Grishoalbrand",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",25),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck27_bgoose321_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",26),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_MrSeri_HardenedScales_G()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",27),
                "PostZendikarRising",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck29_kthanakit26_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",28),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck30_scalo94_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",29),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Thommimp_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",30),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_SugarMountain_Burn_WBR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-03",31),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "RedAggro",
                "Burn",
                null
            );
        }


    }
}
