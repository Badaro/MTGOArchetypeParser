using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_05_postcompanionchange
{
    public class EventTest_modern_league_2020_06_05 : EventTest
    {
        [Test]
        public void Deck01_NeverDidntHaveIt_Prowess_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck01_NeverDidntHaveIt_Prowess_WR(),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Musagete_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck02_Musagete_Devoted_WG_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_carlosalmeida_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck03_carlosalmeida_Ponza_RG(),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Lucabireskusku_Inverter_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck04_Lucabireskusku_Inverter_UB(),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck05_K4rl1991_HardenedScales_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck05_K4rl1991_HardenedScales_G(),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck06_asmitchler_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck06_asmitchler_DeathsShadow_TraverseShadow_UBRG(),
                new PostCompanionChange(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck07_crazeyr15_BringToNiv_WUBRG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck07_crazeyr15_BringToNiv_WUBRG_Jegantha(),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_hugofreitas1_GiftsStorm_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck08_hugofreitas1_GiftsStorm_URG(),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck09_retiredcapivara_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck09_retiredcapivara_Dredge_BRG(),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Urzza100_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck10_Urzza100_SnowControl_SnowTitan_WUG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_didoguidotti1_DeathsShadow_GrixisShadow_UBR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck11_didoguidotti1_DeathsShadow_GrixisShadow_UBR_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Papelucho10_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck12_Papelucho10_Infect_UG(),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck13_SvenSvenSven_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck13_SvenSvenSven_IzzetControl_UR(),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_MaliciousMac_SnowControl_SnowBlade_WURG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck14_MaliciousMac_SnowControl_SnowBlade_WURG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(SnowControl),
                typeof(SnowBlade),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_Mussie99_AzoriusControl_Miracles_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck15_Mussie99_AzoriusControl_Miracles_WU(),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
                null
            );
        }

        [Test]
        public void Deck16_ilmatagatto_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck16_ilmatagatto_Humans_WUBRG(),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Nightblue_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck17_Nightblue_Burn_WR(),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck18_lSoLlAKirA_Devoted_HeliodDevoted_WBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck18_lSoLlAKirA_Devoted_HeliodDevoted_WBG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Lcario_DeathsShadow_MarduShadow_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck19_Lcario_DeathsShadow_MarduShadow_WBR(),
                new PostCompanionChange(),
                ArchetypeColor.WBR,
                typeof(DeathsShadow),
                typeof(MarduShadow),
                null
            );
        }

        [Test]
        public void Deck20_wambocombo2020_JundSmallpox_BRG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck20_wambocombo2020_JundSmallpox_BRG_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(JundSmallpox),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Metcalf23_DeathAndTaxes_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck21_Metcalf23_DeathAndTaxes_WR_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_DreamsOfAshiok_RakdosMidrange_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck22_DreamsOfAshiok_RakdosMidrange_BR(),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Celldweller_SnowControl_SnowReclamation_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck23_Celldweller_SnowControl_SnowReclamation_UBG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_llabmonkey_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck24_llabmonkey_SnowControl_SnowShift_URG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck25_mashmalovsky_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck25_mashmalovsky_DeathAndTaxes_EldraziTaxes_WB(),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck26_timewalkinonsunshine_SnowControl_SnowTurns_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck26_timewalkinonsunshine_SnowControl_SnowTurns_URG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowTurns),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_RandomOctopus_Uroza_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck27_RandomOctopus_Uroza_WUG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_iuriper_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck28_iuriper_SnowControl_SnowReclamation_UBG(),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck29_Aristocrats_Aristocrats_WB_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck29_Aristocrats_Aristocrats_WB_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(Aristocrats),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_pbarrrgh_SnowControl_SnowBlade_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck30_pbarrrgh_SnowControl_SnowBlade_WUG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_DavidDPanda_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck31_DavidDPanda_ETron_C(),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck32_HypnoticaL_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck32_HypnoticaL_Prowess_RakdosProwess_BR_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck33_liu123_Bogles_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck33_liu123_Bogles_WG_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck34_Boin_Rock_BG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck34_Boin_Rock_BG_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck35_qfortier_SnowControl_SnowTurns_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck35_qfortier_SnowControl_SnowTurns_URG(),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowTurns),
                null
            );
        }

        [Test]
        public void Deck36_nahuel10_SnowControl_WUBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck36_nahuel10_SnowControl_WUBG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_DeeBoFour20_GTron_G_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck37_DeeBoFour20_GTron_G_Jegantha(),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck38_fpawlusz_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck38_fpawlusz_PrimevalTitan_KGCAmuletTitan_WUBRG(),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck39_WeareVenom_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck39_WeareVenom_SnowControl_WUG(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck40_ary31415_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck40_ary31415_Rock_Jund_BRG(),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck41_JouNick_DeathsShadow_SuicideShadow_BRG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck41_JouNick_DeathsShadow_SuicideShadow_BRG_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(SuicideShadow),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck42_Flight24White_Neobrand_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck42_Flight24White_Neobrand_UG(),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Wuhsa_BringToNiv_WUBRG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck43_Wuhsa_BringToNiv_WUBRG_Jegantha(),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck44_stefanocanclini_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05.Deck44_stefanocanclini_AdNauseam_WUB(),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }


    }
}
