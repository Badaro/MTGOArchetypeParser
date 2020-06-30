using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_league_2020_06_05 : EventTest
    {
        [Test]
        public void Deck01_NeverDidntHaveIt_Prowess_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck01_NeverDidntHaveIt_Prowess_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Musagete_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck02_Musagete_Devoted_WG_Lurrus(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_carlosalmeida_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck03_carlosalmeida_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Lucabireskusku_Inverter_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck04_Lucabireskusku_Inverter_UB(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck05_K4rl1991_HardenedScales_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck05_K4rl1991_HardenedScales_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck06_asmitchler_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck06_asmitchler_DeathsShadow_TraverseShadow_UBRG(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck07_crazeyr15_BringToNiv_WUBRG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck07_crazeyr15_BringToNiv_WUBRG_Jegantha(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_hugofreitas1_GiftsStorm_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck08_hugofreitas1_GiftsStorm_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck09_retiredcapivara_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck09_retiredcapivara_Dredge_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Urzza100_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck10_Urzza100_SnowControl_SnowTitan_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_didoguidotti1_DeathsShadow_GrixisShadow_UBR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck11_didoguidotti1_DeathsShadow_GrixisShadow_UBR_Lurrus(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Papelucho10_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck12_Papelucho10_Infect_UG(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck13_SvenSvenSven_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck13_SvenSvenSven_IzzetControl_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_MaliciousMac_JeskaiControl_JeskaiStoneblade_WURG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck14_MaliciousMac_JeskaiControl_JeskaiStoneblade_WURG_Yorion(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.JeskaiControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.JeskaiStoneblade),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_Mussie99_AzoriusControl_Miracles_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck15_Mussie99_AzoriusControl_Miracles_WU(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Miracles),
                null
            );
        }

        [Test]
        public void Deck16_ilmatagatto_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck16_ilmatagatto_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Nightblue_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck17_Nightblue_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck18_lSoLlAKirA_Devoted_HeliodDevoted_WBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck18_lSoLlAKirA_Devoted_HeliodDevoted_WBG_Yorion(),
                ArchetypeColor.WBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                typeof(MTGOArchetypeParser.Archetypes.Modern.HeliodDevoted),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Lcario_DeathsShadow_MarduShadow_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck19_Lcario_DeathsShadow_MarduShadow_WBR(),
                ArchetypeColor.WBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.MarduShadow),
                null
            );
        }

        [Test]
        public void Deck20_wambocombo2020_JundSmallpox_BRG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck20_wambocombo2020_JundSmallpox_BRG_Lurrus(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.JundSmallpox),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Metcalf23_DeathAndTaxes_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck21_Metcalf23_DeathAndTaxes_WR_Lurrus(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_DreamsOfAshiok_Skelementals_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck22_DreamsOfAshiok_Skelementals_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Skelementals),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Celldweller_SnowControl_SnowReclamation_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck23_Celldweller_SnowControl_SnowReclamation_UBG_Yorion(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_llabmonkey_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck24_llabmonkey_SnowControl_SnowShift_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck25_mashmalovsky_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck25_mashmalovsky_DeathAndTaxes_EldraziTaxes_WB(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                typeof(MTGOArchetypeParser.Archetypes.Modern.EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck26_timewalkinonsunshine_SnowControl_SnowTurns_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck26_timewalkinonsunshine_SnowControl_SnowTurns_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTurns),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_RandomOctopus_Uroza_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck27_RandomOctopus_Uroza_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_iuriper_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck28_iuriper_SnowControl_SnowReclamation_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck29_Aristocrats_Aristocrats_WB_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck29_Aristocrats_Aristocrats_WB_Lurrus(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Aristocrats),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_pbarrrgh_SnowControl_SnowBlade_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck30_pbarrrgh_SnowControl_SnowBlade_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_DavidDPanda_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck31_DavidDPanda_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck32_HypnoticaL_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck32_HypnoticaL_Prowess_RakdosProwess_BR_Lurrus(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck33_liu123_Bogles_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck33_liu123_Bogles_WG_Lurrus(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck34_Boin_Rock_BG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck34_Boin_Rock_BG_Lurrus(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck35_qfortier_SnowControl_SnowTurns_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck35_qfortier_SnowControl_SnowTurns_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTurns),
                null
            );
        }

        [Test]
        public void Deck36_nahuel10_SnowControl_WUBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck36_nahuel10_SnowControl_WUBG_Yorion(),
                ArchetypeColor.WUBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_DeeBoFour20_GTron_G_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck37_DeeBoFour20_GTron_G_Jegantha(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck38_fpawlusz_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck38_fpawlusz_PrimevalTitan_KGCAmuletTitan_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck39_WeareVenom_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck39_WeareVenom_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck40_ary31415_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck40_ary31415_Rock_Jund_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck41_JouNick_DeathsShadow_SuicideShadow_BRG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck41_JouNick_DeathsShadow_SuicideShadow_BRG_Lurrus(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SuicideShadow),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck42_Flight24White_Neobrand_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck42_Flight24White_Neobrand_UG(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Wuhsa_BringToNiv_WUBRG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck43_Wuhsa_BringToNiv_WUBRG_Jegantha(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck44_stefanocanclini_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck44_stefanocanclini_AdNauseam_WUB(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }


    }
}
