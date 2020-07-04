using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_league_2020_07_03 : EventTest
    {
        [Test]
        public void Deck01_Batutinha_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck01_Batutinha_SnowControl_SnowReclamation_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck02_mechint_DimirControl_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck02_mechint_DimirControl_UB(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DimirControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_NevarMore_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck03_NevarMore_Prowess_R(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Drakanar_Merfolk_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck04_Drakanar_Merfolk_UG(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck05_robedarcourt_DeathAndTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck05_robedarcourt_DeathAndTaxes_WB(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck06_marcofabrizi_SnowControl_WUBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck06_marcofabrizi_SnowControl_WUBG(),
                ArchetypeColor.WUBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_titoWii96_SnowControl_WURG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck07_titoWii96_SnowControl_WURG_Yorion(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_MrSheep_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck08_MrSheep_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Tarrasque1_Elementals_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck09_Tarrasque1_Elementals_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck10_didoguidotti1_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck10_didoguidotti1_SnowControl_SnowShift_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_daniventrue_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck11_daniventrue_DeathsShadow_GrixisShadow_UBR(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck12_MHayashi_Prowess_R_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck12_MHayashi_Prowess_R_Jegantha(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_kogamo_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck13_kogamo_Goblins_SnoopGoblins_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck14_ScreenwriterNY_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck14_ScreenwriterNY_PrimevalTitan_AmuletTitan_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck15_Maratiam_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck15_Maratiam_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_mrounds1216_Elves_GolgariElves_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck16_mrounds1216_Elves_GolgariElves_BG(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Elves),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GolgariElves),
                null
            );
        }

        [Test]
        public void Deck17_npercario_ElectroBalance_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck17_npercario_ElectroBalance_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ElectroBalance),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Weasley_SnowControl_SnowReclamation_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck18_Weasley_SnowControl_SnowReclamation_UBG_Yorion(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_CHILLEDADED_PrimevalTitan_TitanShift_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck19_CHILLEDADED_PrimevalTitan_TitanShift_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TitanShift),
                null
            );
        }

        [Test]
        public void Deck20_GRDONKIN_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck20_GRDONKIN_AdNauseam_WUB(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck21_sicsmoo_GTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck21_sicsmoo_GTron_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Nilsfit_Devoted_HeliodDevoted_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck22_Nilsfit_Devoted_HeliodDevoted_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                typeof(MTGOArchetypeParser.Archetypes.Modern.HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck23_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck23_hugofreitas1_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Wirmaleff_Mill_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck24_Wirmaleff_Mill_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck25_DoubleB33_HeliodSisters_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck25_DoubleB33_HeliodSisters_W(),
                ArchetypeColor.W,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HeliodSisters),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Blkspds_Neobrand_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck26_Blkspds_Neobrand_UG(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck27_L3D91_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck27_L3D91_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck28_saccij92_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck28_saccij92_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck29_HNSDMPF_HardenedScales_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck29_HNSDMPF_HardenedScales_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck30_thepensword_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck30_thepensword_IzzetControl_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_rojanosa_Tokens_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck31_rojanosa_Tokens_WB(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Jiggywiggy_KinnanUrza_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck32_Jiggywiggy_KinnanUrza_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck33_aspiringspike_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck33_aspiringspike_IzzetControl_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_penips_DeathAndTaxes_EldraziTaxes_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck34_penips_DeathAndTaxes_EldraziTaxes_W(),
                ArchetypeColor.W,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                typeof(MTGOArchetypeParser.Archetypes.Modern.EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck35_BrunoMineiro_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck35_BrunoMineiro_DeathsShadow_TraverseShadow_UBRG(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck36_122pablo_JeskaiAscendancy_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck36_122pablo_JeskaiAscendancy_WURG(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.JeskaiAscendancy),
                null,
                null
            );
        }

        [Test]
        public void Deck37_B4nn3D22_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck37_B4nn3D22_Goblins_SnoopGoblins_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck38_NagatoBoran_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck38_NagatoBoran_Rock_Jund_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck39_Cherryxman_Delver_GrixisDelver_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck39_Cherryxman_Delver_GrixisDelver_UBR(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Delver),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisDelver),
                null
            );
        }

        [Test]
        public void Deck40_Morrys_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck40_Morrys_Goblins_SnoopGoblins_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck41_Zxrogue_DeathAndTaxes_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck41_Zxrogue_DeathAndTaxes_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Draken44_Uroza_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck42_Draken44_Uroza_UBG_Yorion(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck43_Wuhsa_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck43_Wuhsa_BringToNiv_WUBRG_Yorion(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck44_RadioactiveTortoise_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck44_RadioactiveTortoise_Dredge_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck45_lopi_HeliodCombo_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck45_lopi_HeliodCombo_WG(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck46_TubbyBatman_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck46_TubbyBatman_Prowess_IzzetProwess_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck47_TrueHero_SnowControl_SnowTurns_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck47_TrueHero_SnowControl_SnowTurns_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTurns),
                null
            );
        }

        [Test]
        public void Deck48_MadMaxErnst_SnowControl_SultaiSnow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck48_MadMaxErnst_SnowControl_SultaiSnow_UBRG(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck49_Trellon_UTron_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck49_Trellon_UTron_U(),
                ArchetypeColor.U,
                typeof(MTGOArchetypeParser.Archetypes.Modern.UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Ryan39_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck50_Ryan39_Prowess_IzzetProwess_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck51_Kurusu_KikiChord_WBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck51_Kurusu_KikiChord_WBRG_Yorion(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck52_Rosie54_CatsAndTaxes_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03.Deck52_Rosie54_CatsAndTaxes_WG(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.CatsAndTaxes),
                null,
                null
            );
        }


    }
}
