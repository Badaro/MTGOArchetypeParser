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
#01 Sodeq: Oops All Spells (WUBG)
#02 Mcleskey: Izzet Prowess (UR)
#03 PieGonti: Heliod Combo (WG)
#04 pokerswizard: Shadow Prowess (WBR, Lurrus)
#05 Ozymandias17: WURG Control (WURG)
#06 Martin_Dominguez: Heliod Combo (WG)
#07 Brunister: Azorius Taxes (WU, Yorion)
#08 Zar0s: WURG Control (WURG)
#09 Kaies: Shadow Prowess (BRG, Lurrus)
#10 Rulleboren: Belcher (WRG)
#11 Antoine57437: Abzan Company (WBG)
#12 yamakiller: Obosh Aggro (R, Obosh)
#13 BradPitKeeper: WURG Control (WURG)
#14 im2g00t4ubarn: WURG Control (WURG)
#15 Lordzedane: Shadow Prowess (WBR, Lurrus)
#16 McWinSauce: WURG Control (WURG)
#17 didoguidotti1: WURG Control (WURG)
#18 bamzing: WURG Control (WURG)
#19 AlpInco: Oops All Spells (WUBG)
#20 SpiderSpace: Izzet Restore Balance (UR)
#21 cntrlfreak: Sultai Shadow (UBG)
#22 apriolo1: Amulet Titan (WRG)
#23 trader08111: Gruul Midrange (RG)
#24 hugofreitas1: Gifts Storm (UR)
#25 Antraxonn: Scapeshift (UBRG, Lurrus)
#26 Naisirc: Gruul Midrange (RG)
#27 aspiringspike: Jeskai Control (WUR)
#28 AFX: Reclaimer Titan (WRG)
#29 WingedHussar: Mill (UB, Lurrus)
#30 FreedMania: Amulet Titan (RG)
#31 JUJUBEAN__2004: UBRG Control (UBRG)
#32 ColdPier: Mono White Taxes (W)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_showcase_challenge_2020_11_08 : EventTest
    {
        [Test]
        public void Deck01_Sodeq_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",0),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Mcleskey_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",1),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_PieGonti_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",2),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck04_pokerswizard_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",3),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Ozymandias17_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",4),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_MartinDominguez_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",5),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Brunister_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",6),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_Zar0s_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Kaies_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",8),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Rulleboren_Belcher_WRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",9),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Antoine57437_AbzanCompany_WBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",10),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck12_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",11),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck13_BradPitKeeper_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",12),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_im2g00t4ubarn_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",13),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Lordzedane_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",14),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",15),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_didoguidotti1_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",16),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_bamzing_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",17),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_AlpInco_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",18),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck20_SpiderSpace_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",19),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck21_cntrlfreak_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",20),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck22_apriolo1_AmuletTitan_WRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",21),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck23_trader08111_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",22),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",23),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Antraxonn_Scapeshift_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",24),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_Naisirc_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",25),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_aspiringspike_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",26),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_AFX_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",27),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck29_WingedHussar_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",28),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_FreedMania_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",29),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck31_JUJUBEAN2004_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",30),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_ColdPier_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-11-08",31),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }


    }
}
