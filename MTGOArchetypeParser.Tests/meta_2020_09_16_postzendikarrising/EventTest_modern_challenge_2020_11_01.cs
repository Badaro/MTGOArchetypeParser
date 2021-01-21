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
#01 6argamel: Mono White Taxes (W)
#02 pbarrrgh: Reclamation (UBG)
#03 bamzing: WURG Control (WURG)
#04 maxbv: Mono White Taxes (W)
#05 AlpInco: Oops All Spells (WUBRG)
#06 FedeG: Heliod Combo (WG)
#07 Vagabond87: Selective Oracle (WU)
#08 yamakiller: Gruul Midrange (RG)
#09 Bayesta_93: Shadow Prowess (BR, Lurrus)
#10 Ryan100495: Dredge (BRG)
#11 silvanelf7: Green Tron (G)
#12 tuckbear: Sultai Midrange (UBG)
#13 SebastianStueckl: Green Tron (G)
#14 futureshok: Abzan Midrange (WBG)
#15 Moniz0801: Amulet Titan (G)
#16 D00mwake: Reclaimer Titan (WRG)
#17 122pablo: Ascendancy Combo (WURG)
#18 Martin_Dominguez: Devoted (WG)
#19 cntrlfreak: Grixis Shadow (UBR)
#20 Wizard_2002: Green Tron (G)
#21 Biednarccio: Amulet Titan (UG)
#22 TSPJendrek: Jeskai Control (WUR)
#23 Tweedel: Humans (WUBRG)
#24 MastaHorus: Electro End (UR)
#25 mtbWolf: Jund Midrange (BRG)
#26 BiTXBoi: Selesnya Taxes (WG)
#27 wambocombo2020: Shadow Prowess (BR, Lurrus)
#28 Capiplaf95: Golgari Midrange (BG)
#29 gyyby297: Oops All Spells (WUBRG)
#30 GedionRavenor: WURG Control (WURG)
#31 Samcaster-Mage: Eldrazi Tron (C)
#32 Mazzu93: Jund Midrange (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_11_01 : EventTest
    {
        [Test]
        public void Deck01_6argamel_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",0),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck02_pbarrrgh_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",1),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck03_bamzing_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_maxbv_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",3),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck05_AlpInco_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",4),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck06_FedeG_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",5),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Vagabond87_SelectiveOracle_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",6),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "SelectiveOracle",
                null,
                null
            );
        }

        [Test]
        public void Deck08_yamakiller_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",7),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Bayesta93_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",8),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",9),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck11_silvanelf7_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",10),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck12_tuckbear_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",11),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_SebastianStueckl_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",12),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck14_futureshok_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",13),
                "PostZendikarRising",
                ArchetypeColor.WBG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Moniz0801_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",14),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck16_D00mwake_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",15),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck17_122pablo_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",16),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "AscendancyCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck18_MartinDominguez_Devoted_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",17),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck19_cntrlfreak_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",18),
                "PostZendikarRising",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Wizard2002_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",19),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck21_Biednarccio_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",20),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck22_TSPJendrek_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",21),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Tweedel_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",22),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck24_MastaHorus_ElectroEnd_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",23),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroEnd",
                null
            );
        }

        [Test]
        public void Deck25_mtbWolf_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",24),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck26_BiTXBoi_SelesnyaTaxes_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",25),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck27_wambocombo2020_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",26),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_Capiplaf95_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",27),
                "PostZendikarRising",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck29_gyyby297_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",28),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck30_GedionRavenor_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",29),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck31_SamcasterMage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",30),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck32_Mazzu93_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",31),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
