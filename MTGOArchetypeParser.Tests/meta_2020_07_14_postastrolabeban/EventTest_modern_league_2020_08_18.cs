using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_08_18 : EventTest
    {
        [Test]
        public void Deck01_llabmonkey_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck02_aspiringspike_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-18",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_Albyz_MarduPyromancer_WBR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(MarduPyromancer),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Nallemon_EightRack_B()
        {
            Test(
                GetDeck("modern-league-2020-08-18",3),
                new PostAstrolabeBan(),
                ArchetypeColor.B,
                typeof(EightRack),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Proliferate_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Parrit_DeathAndTaxes_EldraziTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck07_Jiggywiggy_KinnanMentor_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(KinnanMentor),
                null,
                null
            );
        }

        [Test]
        public void Deck08_TuggaNaxos_Infect_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",7),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kensportsfan_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-08-18",8),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_sakuragi21722749_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_shoiwao_Devoted_HeliodDevoted_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck12_Azerate218_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck13_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Albyz_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Carton_DeathsShadow_EsperShadow_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-18",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(DeathsShadow),
                typeof(EsperShadow),
                null
            );
        }

        [Test]
        public void Deck16_Bobthebuilder24_SoulSisters_HeliodSisters_W()
        {
            Test(
                GetDeck("modern-league-2020-08-18",15),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(SoulSisters),
                typeof(HeliodSisters),
                null
            );
        }

        [Test]
        public void Deck17_waffl3haos_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-18",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck18_harukispecial_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck19_RyanWu_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-18",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(OrzhovMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ben1234_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",19),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck21_CodeProvider_Grishoalbrand_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",20),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Grishoalbrand),
                null,
                null
            );
        }

        [Test]
        public void Deck22_sfitz_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Wuhsa_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-18",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_Ghost_Burn_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Tedpanic_AzoriusControl_Miracles_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-18",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
                null
            );
        }

        [Test]
        public void Deck26_Irra0770_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",25),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck27_Mulldrifter_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Copilot11_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",27),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_hanrahandh_Elves_DevotedElves_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Elves),
                typeof(DevotedElves),
                null
            );
        }

        [Test]
        public void Deck30_SickWorld_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Bryzem1_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",30),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck32_Metcalf23_DeathAndTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-18",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck33_hizakura_Polymorph_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",32),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck34_DarkKeeper_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_rodebo_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-08-18",34),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck36_kogamo_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",35),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck37_Cheerios_WildernessReclamation_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",36),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck38_paynechips_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-08-18",37),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck39_kogamo_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-18",38),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck40_brainstorm39_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-18",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck41_Otmos_Prowess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-18",40),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck42_Storytime_Devoted_KinnanDevoted_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(KinnanDevoted),
                null
            );
        }

        [Test]
        public void Deck43_122pablo_JeskaiAscendancy_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-08-18",42),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck44_JimmySetzer_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",43),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck45_fsst_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",44),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Tarmofir3_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",45),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck47_Polikasoll_Burn_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-08-18",46),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck48_TheGingerBrute_Faeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-08-18",47),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Faeries),
                null,
                null
            );
        }

        [Test]
        public void Deck49_dabigatran_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-18",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Xenowan_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-08-18",49),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck51_TheCodyHope_Elementals_WUBRG_Kaheera()
        {
            Test(
                GetDeck("modern-league-2020-08-18",50),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck52_Menoti_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-08-18",51),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck53_SpikeYou_IzzetFreeSpells_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",52),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck54_kado222_GoryoReanimator_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",53),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GoryoReanimator),
                null,
                null
            );
        }

        [Test]
        public void Deck55_CaptainFarbosa_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",54),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck56_cccaspar_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-league-2020-08-18",55),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck57_kogamo_PrimevalTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",56),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck58_Taragon_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-18",57),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck59_marcosrocha_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",58),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck60_tuhoajatane_TitanVial_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",59),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(TitanVial),
                null,
                null
            );
        }

        [Test]
        public void Deck61_Alzik_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-18",60),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck62_MartinezDP_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-18",61),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck63_scipios_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",62),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck64_SunnyOsRego_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",63),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck65_musasabi_PrimevalTitan_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",64),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck66_Widok_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-18",65),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck67_MHayashi_RedDeckWins_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-08-18",66),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck68_PurpleRain_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",67),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck69_Jidden_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-18",68),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck70_tcgshin_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",69),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck71_DcNo_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",70),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck72_FriskiFraska_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",71),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck73_Thrall90_Rock_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",72),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }


    }
}
