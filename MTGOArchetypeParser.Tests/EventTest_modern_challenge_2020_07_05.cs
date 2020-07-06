using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_challenge_2020_07_05 : EventTest
    {
        [Test]
        public void Deck01_ZYURYO_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck01_ZYURYO_Rock_Jund_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck02_Darkiundsa_SnowControl_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck02_Darkiundsa_SnowControl_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_TSPJendrek_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck03_TSPJendrek_SnowControl_SultaiSnow_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck04_LORiWWA_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck04_LORiWWA_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_A22en_AzoriusControl_Miracles_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck05_A22en_AzoriusControl_Miracles_WU(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Miracles),
                null
            );
        }

        [Test]
        public void Deck06_Busterbrown52_Elementals_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck06_Busterbrown52_Elementals_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Shorak123_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck07_Shorak123_SnowControl_SnowReclamation_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck08_1yo2yo_ThopterUrza_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck08_1yo2yo_ThopterUrza_UBR(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_TheTunnelingCat_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck09_TheTunnelingCat_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Zxrogue_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck10_Zxrogue_DeathsShadow_TraverseShadow_UBRG(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck11_bobthedog_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck11_bobthedog_SnowControl_SultaiSnow_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck12_PvtEnormous_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck12_PvtEnormous_SnowControl_SultaiSnow_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck13_TerminalJustice_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck13_TerminalJustice_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck14_katoriarch123_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck14_katoriarch123_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_hdyer_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck15_hdyer_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_yamakiller_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck16_yamakiller_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_renatoaraujo_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck17_renatoaraujo_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck18_HouseOfManaMTG_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck18_HouseOfManaMTG_PrimevalTitan_AmuletTitan_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck19_indianpancake_Devoted_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck19_indianpancake_Devoted_WG(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Sodeq_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck20_Sodeq_AdNauseam_WUB(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck21_ManuelJacob_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck21_ManuelJacob_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_pbarrrgh_SnowControl_TemurSnow_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck22_pbarrrgh_SnowControl_TemurSnow_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TemurSnow),
                null
            );
        }

        [Test]
        public void Deck23_MasterA_Goblins_SnoopGoblins_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck23_MasterA_Goblins_SnoopGoblins_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck24_Graciasportanto_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck24_Graciasportanto_Dredge_WBRG(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck25_LordBeerus_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck25_LordBeerus_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Mzfroste_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck26_Mzfroste_Goblins_SnoopGoblins_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck27_Kuhb_GrindingBreach_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck27_Kuhb_GrindingBreach_WURG(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck28_D00mwake_Prowess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck28_D00mwake_Prowess_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck29_tuhoajatane_SnowControl_TemurSnow_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck29_tuhoajatane_SnowControl_TemurSnow_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TemurSnow),
                null
            );
        }

        [Test]
        public void Deck30_MadMaxErnst_SnowControl_SultaiSnow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck30_MadMaxErnst_SnowControl_SultaiSnow_UBRG(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck31_SungilWang_Devoted_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck31_SungilWang_Devoted_WG(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck32_CapitanoCL_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05.Deck32_CapitanoCL_Dredge_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }


    }
}
