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
#02 pbarrrgh: Sultai Control (UBG)
#03 bamzing: WURG Control (WURG)
#04 maxbv: Mono White Taxes (W)
#05 AlpInco: Oops All Spells (WUBG)
#06 FedeG: Heliod Combo (WG)
#07 Vagabond87: Selective Oracle (WU)
#08 yamakiller: Gruul Midrange (RG)
#09 Bayesta_93: Shadow Prowess (BR, Lurrus)
#10 Ryan100495: Dredge (BRG)
#11 silvanelf7: KGC Tron (G)
#12 tuckbear: Sultai Midrange (UBG)
#13 SebastianStueckl: KGC Tron (G)
#14 futureshok: Abzan Midrange (WBG)
#15 Moniz0801: Amulet Titan (G)
#16 D00mwake: Reclaimer Titan (WRG)
#17 122pablo: Jeskai Ascendancy (WURG)
#18 Martin_Dominguez: Heliod Devoted (WG)
#19 cntrlfreak: Grixis Shadow (UBR)
#20 Wizard_2002: KGC Tron (G)
#21 Biednarccio: Amulet Titan (UG)
#22 TSPJendrek: Izzet Control (UR)
#23 Tweedel: Humans (WUBRG)
#24 MastaHorus: Izzet Living End (UR)
#25 mtbWolf: Jund Midrange (BRG)
#26 BiTXBoi: Selenya Taxes (WG)
#27 wambocombo2020: Shadow Prowess (BR, Lurrus)
#28 Capiplaf95: Golgari Midrange (BG)
#29 gyyby297: Oops All Spells (WUBRG)
#30 GedionRavenor: WURG Control (WURG)
#31 Samcaster-Mage: E Tron (C)
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
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck02_pbarrrgh_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",1),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_bamzing_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_maxbv_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",3),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck05_AlpInco_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",4),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck06_FedeG_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",5),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Vagabond87_SelectiveOracle_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",6),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(SelectiveOracle),
                null,
                null
            );
        }

        [Test]
        public void Deck08_yamakiller_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",7),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Bayesta93_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",8),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",9),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck11_silvanelf7_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",10),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck12_tuckbear_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",11),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_SebastianStueckl_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",12),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck14_futureshok_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",13),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Moniz0801_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",14),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck16_D00mwake_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",15),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck17_122pablo_JeskaiAscendancy_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",16),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck18_MartinDominguez_HeliodDevoted_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",17),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck19_cntrlfreak_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",18),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Wizard2002_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",19),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck21_Biednarccio_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",20),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_TSPJendrek_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",21),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Tweedel_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",22),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck24_MastaHorus_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",23),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck25_mtbWolf_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",24),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_BiTXBoi_SelenyaTaxes_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",25),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck27_wambocombo2020_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",26),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_Capiplaf95_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",27),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_gyyby297_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",28),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck30_GedionRavenor_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",29),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_SamcasterMage_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",30),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck32_Mazzu93_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-01",31),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
