using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_league_2020_07_07 : EventTest
    {
        [Test]
        public void Deck01_FreshKale_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",0),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck02_Jedermann_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",1),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck03_busso9494_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",2),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck04_Tarmofir3_Rock_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",3),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck05_JMoney8771_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",4),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_WhiteFish_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",5),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck07_AZN7_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",6),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_twilightSSparkle_Neobrand_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",7),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Parrit_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-07",8),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Termahgerf_Uroza_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",9),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_Ennuixd_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",10),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck12_Ayzkub_SnowControl_SultaiSnow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",11),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck13_ArchaeusDota_GTron_GreenEldraziTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-07",12),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(GreenEldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_MrJayngles_RedPrison_R()
        {
            Test(
                GetDeck("modern-league-2020-07-07",13),
                new PostM21(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck15_equites_Burn_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-07-07",14),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck16_UrbanPope_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-07",15),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_number1pwnr_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-07",16),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck18_rojanosa_Tokens_OrzhovTokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-07",17),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(Tokens),
                typeof(OrzhovTokens),
                null
            );
        }

        [Test]
        public void Deck19_mikeyg43_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",18),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck20_Kotva_NinjaFaeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-07",19),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(NinjaFaeries),
                null,
                null
            );
        }

        [Test]
        public void Deck21_gazmon48_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",20),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck22_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",21),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck23_TheDogFish_Merfolk_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",22),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Metcalf23_DeathAndTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-07",23),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Asoen_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",24),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_maear_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",25),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_JFKDefiedBolas_MartyrProc_W()
        {
            Test(
                GetDeck("modern-league-2020-07-07",26),
                new PostM21(),
                ArchetypeColor.W,
                typeof(MartyrProc),
                null,
                null
            );
        }

        [Test]
        public void Deck28_B4nn3D22_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",27),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck29_umeboshijiisan_Goblins_SnoopGoblins_WBR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",28),
                new PostM21(),
                ArchetypeColor.WBR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck30_RENDGT_SnowControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",29),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_MegaMollt_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",30),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck32_TheWonderLord_Rock_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",31),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Boin_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",32),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck34_ArchaeusDota_ETron_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",33),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck35_ToniCalzoni_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-07",34),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck36_andresambiaze_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",35),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Janh_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",36),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck38_freneticefreet_Ponza_LiquimetalPonza_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",37),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                typeof(LiquimetalPonza),
                null
            );
        }

        [Test]
        public void Deck39_CloakedAlvis_GTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-07",38),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Musagete_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-07",39),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck41_mac121711_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",40),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck42_DFrank_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-07",41),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck43_DoniDominaria_Burn_IncineratorBurn_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",42),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck44_Jiggywiggy_KinnanUrza_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",43),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck45_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-07",44),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck46_kensportsfan_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-07",45),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Taracogenius_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",46),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck48_TscheggschDePoegg_SnowControl_TemurSnow_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",47),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(TemurSnow),
                null
            );
        }

        [Test]
        public void Deck49_Ivan1227_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-07",48),
                new PostM21(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck50_musasabi_JundSmallpox_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",49),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(JundSmallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Brunister_Dredge_WBR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",50),
                new PostM21(),
                ArchetypeColor.WBR,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck52_MadRamon_SnowControl_SnowReclamation_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",51),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck53_osk4_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",52),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck54_BanjoCaveman_Polymorph_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",53),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck55_kumuhl00_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",54),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck56_TBagTom_SnowControl_SultaiSnow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",55),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck57_RealJoy_DeathsShadow_SuicideShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",56),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(SuicideShadow),
                null
            );
        }

        [Test]
        public void Deck58_albert62_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",57),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck59_JoaoAndrade_RedDeckWins_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-07",58),
                new PostM21(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck60_SeventhProphet_Uroza_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",59),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck61_TuggaNaxos_SnowControl_SnowTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",60),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowTurns),
                null
            );
        }

        [Test]
        public void Deck62_victgobra10_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",61),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck63_yutya_SnowControl_SnowTurns_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",62),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowTurns),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck64_Simpleliquid_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",63),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck65_sten626_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-07",64),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck66_Traft_SnowControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",65),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck67_gogogadgetblunt_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",66),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }


    }
}
