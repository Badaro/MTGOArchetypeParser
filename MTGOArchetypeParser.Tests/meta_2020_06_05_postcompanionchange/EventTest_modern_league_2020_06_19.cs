using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_05_postcompanionchange
{
    public class EventTest_modern_league_2020_06_19 : EventTest
    {
        [Test]
        public void Deck01_SparTaNxX_Neobrand_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck01_SparTaNxX_Neobrand_UG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck02_nielsen333_Burn_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck02_nielsen333_Burn_WR_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Cherryxman_Inverter_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck03_Cherryxman_Inverter_UB(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck04_meanfannypack_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck04_meanfannypack_Devoted_WG_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Magicofplayer1_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck05_Magicofplayer1_AdNauseam_WUB(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Ftzz_ReclamationTeachings_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck06_Ftzz_ReclamationTeachings_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ReclamationTeachings),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Zebrah_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck07_Zebrah_PrimevalTitan_AmuletTitan_WURG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_nolyfe_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck08_nolyfe_Prowess_R(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_xlsnapcaster_AzoriusControl_Miracles_WU_Kaheera()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck09_xlsnapcaster_AzoriusControl_Miracles_WU_Kaheera(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Miracles),
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck10_Nextep_Uroza_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck10_Nextep_Uroza_UBG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_alnash_SnowControl_SnowTitan_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck11_alnash_SnowControl_SnowTitan_UBG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_scvslayer_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck12_scvslayer_SnowControl_SnowShift_URG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_Tempano_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck13_Tempano_Humans_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Kurusu_KikiChord_WBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck14_Kurusu_KikiChord_WBRG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_IsKeiP529_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck15_IsKeiP529_GTron_KGCTron_G(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck16_ChaoticCamel_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck16_ChaoticCamel_Prowess_RakdosProwess_BR_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_hyriuu_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck17_hyriuu_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Heibing_PrimevalTitan_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck18_Heibing_PrimevalTitan_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck19_yutya_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck19_yutya_SnowControl_SnowTitan_WUG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_TheNobodys_ThopterUrza_WUBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck20_TheNobodys_ThopterUrza_WUBR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_FranPi_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck21_FranPi_GiftsStorm_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck22_BSKhercules_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck22_BSKhercules_SnowControl_SultaiSnow_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck23_Magric_Skelementals_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck23_Magric_Skelementals_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Skelementals),
                null,
                null
            );
        }

        [Test]
        public void Deck24_lovealienzzz_SnowControl_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck24_lovealienzzz_SnowControl_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Drakanar_Merfolk_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck25_Drakanar_Merfolk_U(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.U,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Walkers_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck26_Walkers_SnowControl_SnowReclamation_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck27_Darkiundsa_SnowControl_WURG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck27_Darkiundsa_SnowControl_WURG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_Jiggywiggy_KinnanUrza_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck28_Jiggywiggy_KinnanUrza_URG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_Netow_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck29_Netow_Dredge_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Zanman_GyrudaStompy_BRG_Gyruda()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck30_Zanman_GyrudaStompy_BRG_Gyruda(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GyrudaStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck31_Madwolf87_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck31_Madwolf87_DeathsShadow_TraverseShadow_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck32_Chad1987SR05_Rock_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck32_Chad1987SR05_Rock_BG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Wuhsa_BringToNiv_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck33_Wuhsa_BringToNiv_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck34_thelegitpony666_Goblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck34_thelegitpony666_Goblins_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck35_whitefangshinobi_Mill_UB_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck35_whitefangshinobi_Mill_UB_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck36_salvamala_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck36_salvamala_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck37_RodolfoSFD0_PrimevalTitan_TitanShift_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck37_RodolfoSFD0_PrimevalTitan_TitanShift_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TitanShift),
                null
            );
        }

        [Test]
        public void Deck38_Lcario_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck38_Lcario_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck39_AutumnLily_SnowControl_SnowReclamation_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck39_AutumnLily_SnowControl_SnowReclamation_UBG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck40_Jackson1031_Uroza_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19.Deck40_Jackson1031_Uroza_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                null
            );
        }


    }
}
