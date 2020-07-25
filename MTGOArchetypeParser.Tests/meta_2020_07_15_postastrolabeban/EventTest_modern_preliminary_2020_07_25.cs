using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_15_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_25 : EventTest
    {
        [Test]
        public void Deck01_mac121711_JeskaiControl_JeskaiStoneblade_WUR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck01_mac121711_JeskaiControl_JeskaiStoneblade_WUR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.JeskaiControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.JeskaiStoneblade),
                null
            );
        }

        [Test]
        public void Deck02_AstralPlane_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck02_AstralPlane_Prowess_IzzetProwess_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck03_chengyiw_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck03_chengyiw_Dredge_WBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_JV7777_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck04_JV7777_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_SakeIzumo_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck05_SakeIzumo_Prowess_IzzetProwess_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck06_TheLousyZoot_Goblins_SnoopGoblins_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck06_TheLousyZoot_Goblins_SnoopGoblins_WBR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck07_tyaburi_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck07_tyaburi_Prowess_R(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Zonast_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck08_Zonast_AdNauseam_WUB(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck09_nekonekoneko_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck09_nekonekoneko_Dredge_WBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_updraftelemental_DeathsShadow_SuicideShadow_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck10_updraftelemental_DeathsShadow_SuicideShadow_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SuicideShadow),
                null
            );
        }

        [Test]
        public void Deck11_Toastxp_Prowess_GruulProwess_RG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck11_Toastxp_Prowess_GruulProwess_RG_Jegantha(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GruulProwess),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck12_Granham_AzoriusControl_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck12_Granham_AzoriusControl_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Lexmart_BantControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck13_Lexmart_BantControl_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_kanister_TemurControl_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck14_kanister_TemurControl_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.TemurControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Nickburch13_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck15_Nickburch13_Burn_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck16_INF_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck16_INF_GiftsStorm_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck17_hoveydw_DeathsShadow_SuicideShadow_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_25.Deck17_hoveydw_DeathsShadow_SuicideShadow_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SuicideShadow),
                null
            );
        }


    }
}
