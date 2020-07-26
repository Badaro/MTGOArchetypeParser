using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_15_postastrolabeban
{
    public class EventTest_modern_challenge_2020_07_19 : EventTest
    {
        [Test]
        public void Deck01_Toastxp_DeathsShadow_SuicideShadow_BRG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck01_Toastxp_DeathsShadow_SuicideShadow_BRG_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SuicideShadow),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_cws_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck02_cws_GiftsStorm_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck03_goblinlackey_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck03_goblinlackey_GTron_KGCTron_G(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck04_Edel_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck04_Edel_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck05_Traft_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck05_Traft_AdNauseam_WUB(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Danker_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck06_Danker_AzoriusControl_AzoriusStoneblade_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck07_nahuel10_SnowControl_SnowReclamation_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck07_nahuel10_SnowControl_SnowReclamation_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck08_pokerswizard_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck08_pokerswizard_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck09_kanister_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck09_kanister_WildernessReclamation_TemurReclamation_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.WildernessReclamation),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck10_skuttlespike_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck10_skuttlespike_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck11_nolyfe_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck11_nolyfe_Prowess_R(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Shorak123_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck12_Shorak123_SnowControl_SnowReclamation_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck13_Chefen_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck13_Chefen_Goblins_SnoopGoblins_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck14_echecetmat35_PrimevalTitan_TitanShift_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck14_echecetmat35_PrimevalTitan_TitanShift_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TitanShift),
                null
            );
        }

        [Test]
        public void Deck15_bntrusty14_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck15_bntrusty14_Devoted_WG_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Gigy_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck16_Gigy_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Redgy819_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck17_Redgy819_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Misplacedginger_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck18_Misplacedginger_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck19_Skrown_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck19_Skrown_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Jokersrwild_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck20_Jokersrwild_Goblins_SnoopGoblins_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck21_soultaker06_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck21_soultaker06_Goblins_SnoopGoblins_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck22_MZBlazer_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck22_MZBlazer_Prowess_IzzetProwess_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck23_MrRaeb_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck23_MrRaeb_SnowControl_SultaiSnow_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck24_kthanakit26_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck24_kthanakit26_Burn_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck25_crazybaloth_DeathAndTaxes_EldraziTaxes_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck25_crazybaloth_DeathAndTaxes_EldraziTaxes_W(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                typeof(MTGOArchetypeParser.Archetypes.Modern.EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck26_MasterA_Goblins_SnoopGoblins_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck26_MasterA_Goblins_SnoopGoblins_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck27_Vonducky_Prowess_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck27_Vonducky_Prowess_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck28_azatoyellow_RedDeckWins_R_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck28_azatoyellow_RedDeckWins_R_Jegantha(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck29_bobjackson_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck29_bobjackson_GTron_KGCTron_G(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck30_EricSlashGreg_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck30_EricSlashGreg_AdNauseam_WUB(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Mikebrav_Humans_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck31_Mikebrav_Humans_WUBRG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_Zar0s_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19.Deck32_Zar0s_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }


    }
}
