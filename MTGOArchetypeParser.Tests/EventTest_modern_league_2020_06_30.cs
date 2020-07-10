using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_league_2020_06_30 : EventTest
    {
        [Test]
        public void Deck01_603Leb_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck01_603Leb_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck02_SpiderSpace_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck02_SpiderSpace_Prowess_IzzetProwess_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck03_derramedefogo_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck03_derramedefogo_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck04_sublimeloudog_HardenedScales_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck04_sublimeloudog_HardenedScales_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck05_JMoney8771_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck05_JMoney8771_Infect_UG(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_TennTyou_BringToNiv_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck06_TennTyou_BringToNiv_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck07_affenburn23_SnowControl_SnowBreach_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck07_affenburn23_SnowControl_SnowBreach_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBreach),
                null
            );
        }

        [Test]
        public void Deck08_MHayashi_Prowess_R_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck08_MHayashi_Prowess_R_Jegantha(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_TheAznYoshi_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck09_TheAznYoshi_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck10_GHash77_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck10_GHash77_SnowControl_SultaiSnow_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck11_yutya_SnowControl_SnowTurns_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck11_yutya_SnowControl_SnowTurns_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTurns),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_Metcalf23_DeathAndTaxes_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck12_Metcalf23_DeathAndTaxes_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Busterbrown52_Elementals_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck13_Busterbrown52_Elementals_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck14_PlanetBlade_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck14_PlanetBlade_DeathsShadow_TraverseShadow_UBRG(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck15_TheRealBlueMTG_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck15_TheRealBlueMTG_Prowess_R(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck16_WeareVenom_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck16_WeareVenom_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Volollo_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck17_Volollo_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Heiring_Tokens_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck18_Heiring_Tokens_WB(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Asoen_Skelementals_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck19_Asoen_Skelementals_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Skelementals),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck20_ContraEgo_ThopterUrza_UBR(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_DemianDesposito10_Prowess_WR_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck21_DemianDesposito10_Prowess_WR_Jegantha(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_buralee_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck22_buralee_SnowControl_SnowBlade_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                null
            );
        }

        [Test]
        public void Deck23_cnofafva_PrimevalTitan_AmuletTitan_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck23_cnofafva_PrimevalTitan_AmuletTitan_UBRG(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_kanister_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck24_kanister_Goblins_SnoopGoblins_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck25_thepensword_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck25_thepensword_IzzetControl_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_paucr5_Devoted_HeliodDevoted_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck26_paucr5_Devoted_HeliodDevoted_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                typeof(MTGOArchetypeParser.Archetypes.Modern.HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck27_TheMadDollMaker_DeathAndTaxes_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck27_TheMadDollMaker_DeathAndTaxes_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck28_haubidtran_Uroza_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck28_haubidtran_Uroza_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_Cherryxman_Burn_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck29_Cherryxman_Burn_R(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck30_in5ano_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck30_in5ano_SnowControl_SnowShift_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_FabriceK_SnowControl_SnowReclamation_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck31_FabriceK_SnowControl_SnowReclamation_UBG_Yorion(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_Jidden_ThopterUrza_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck32_Jidden_ThopterUrza_WU(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck33_PizzaTurtle_Bogles_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck33_PizzaTurtle_Bogles_WG(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Curtisaxel_Spirits_BantSpirits_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck34_Curtisaxel_Spirits_BantSpirits_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Spirits),
                typeof(MTGOArchetypeParser.Archetypes.Modern.BantSpirits),
                null
            );
        }

        [Test]
        public void Deck35_Mordeka1ser_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck35_Mordeka1ser_BringToNiv_WUBRG_Yorion(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck36_sicsmoo_GTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck36_sicsmoo_GTron_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck37_ACG88_Crabvine_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck37_ACG88_Crabvine_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck38_NightOwl61_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck38_NightOwl61_Rock_Jund_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck39_mariogomes097_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck39_mariogomes097_DeathsShadow_GrixisShadow_UBR(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck40_RodolfoSFD0_PrimevalTitan_TitanShift_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck40_RodolfoSFD0_PrimevalTitan_TitanShift_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TitanShift),
                null
            );
        }

        [Test]
        public void Deck41_marcofabrizi_SnowControl_SultaiSnow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck41_marcofabrizi_SnowControl_SultaiSnow_UBRG(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck42_mstanzione_ElectroBalance_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck42_mstanzione_ElectroBalance_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ElectroBalance),
                null,
                null
            );
        }

        [Test]
        public void Deck43_nielsen333_PrimevalTitan_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck43_nielsen333_PrimevalTitan_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck44_number1pwnr_UTron_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck44_number1pwnr_UTron_U(),
                ArchetypeColor.U,
                typeof(MTGOArchetypeParser.Archetypes.Modern.UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck45_meanfannypack_Devoted_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck45_meanfannypack_Devoted_WG(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Deulotar_Rock_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck46_Deulotar_Rock_BG(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck47_MagicRainbows_Burn_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck47_MagicRainbows_Burn_R(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Easyldur1_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck48_Easyldur1_Dredge_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Lcario_Prowess_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck49_Lcario_Prowess_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck50_TubbyBatman_Delver_TemurDelver_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck50_TubbyBatman_Delver_TemurDelver_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Delver),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TemurDelver),
                null
            );
        }

        [Test]
        public void Deck51_FranMtg_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck51_FranMtg_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Amatox_BantBlink_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30.Deck52_Amatox_BantBlink_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BantBlink),
                null,
                null
            );
        }


    }
}
