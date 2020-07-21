using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_15_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_17 : EventTest
    {
        [Test]
        public void Deck01_wambocombo2020_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck01_wambocombo2020_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck02_karatedom_Prowess_RakdosProwess_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck02_karatedom_Prowess_RakdosProwess_WBR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.RakdosProwess),
                null
            );
        }

        [Test]
        public void Deck03_goblinlackey_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck03_goblinlackey_GTron_KGCTron_G(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck04_staples87_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck04_staples87_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Batutinha_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck05_Batutinha_Prowess_IzzetProwess_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck06_billsive_AzoriusControl_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck06_billsive_AzoriusControl_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_SwordHunter_FourColorSaheeli_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck07_SwordHunter_FourColorSaheeli_WURG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowSaheeli),
                null
            );
        }

        [Test]
        public void Deck08_l337erhosen_Elementals_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck08_l337erhosen_Elementals_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck09_mac121711_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck09_mac121711_Goblins_SnoopGoblins_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck10_Gerschi_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck10_Gerschi_DeathsShadow_GrixisShadow_UBR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck11_unicornparadise_AzoriusControl_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck11_unicornparadise_AzoriusControl_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_EskimoJoe_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck12_EskimoJoe_GTron_KGCTron_G(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck13_BnR_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck13_BnR_DeathsShadow_GrixisShadow_UBR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck14_mariogomes097_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck14_mariogomes097_DeathsShadow_GrixisShadow_UBR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck15_MZBlazer_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck15_MZBlazer_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck16_PhillHellmuth_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck16_PhillHellmuth_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck17_cariollins_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck17_cariollins_Prowess_IzzetProwess_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck18_Daking3603_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck18_Daking3603_Goblins_SnoopGoblins_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck19_PeanutBrittle_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck19_PeanutBrittle_Prowess_IzzetProwess_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck20_Edel_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck20_Edel_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck21_sandydogmtg_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck21_sandydogmtg_Goblins_SnoopGoblins_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck22_Ennuixd_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck22_Ennuixd_GiftsStorm_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Nammersquats_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck23_Nammersquats_Infect_UG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck24_SebastianStueckl_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck24_SebastianStueckl_SnowControl_SultaiSnow_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck25_Searzist_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck25_Searzist_Prowess_R(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_qbturtle15_AzoriusControl_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck26_qbturtle15_AzoriusControl_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_GombleWhop_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck27_GombleWhop_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck28_LSN_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck28_LSN_Burn_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck29_MrRaeb_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_17.Deck29_MrRaeb_SnowControl_SultaiSnow_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }


    }
}
