using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_league_2020_06_09 : EventTest
    {
        [Test]
        public void Deck01_Tarrasque1_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",0),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-06-09",1),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Wuhsa_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",2),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck04_HeyPharaoh_AzoriusControl_Miracles_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-09",3),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
                null
            );
        }

        [Test]
        public void Deck05_Teston_GiftsStorm_UR_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-09",4),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck06_cftsoc3_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",5),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_Jakesbaked_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",6),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck08_PaChA94s_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-06-09",7),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck09_SonsoJF_Devoted_HeliodDevoted_WBG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",8),
                new PostCompanionChange(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck10_cfilly4460_GTron_GolosTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-09",9),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(GolosTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck11_matyo804_Winota_WRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",10),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck12_kaikalbuquerque_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",11),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Matts_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",12),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck14_WotCAndrewB_DeathAndTaxes_ThaliaStoneblade_W()
        {
            Test(
                GetDeck("modern-league-2020-06-09",13),
                new PostCompanionChange(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                typeof(ThaliaStoneblade),
                null
            );
        }

        [Test]
        public void Deck15_Madwolf87_DeathsShadow_SuicideShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",14),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(SuicideShadow),
                null
            );
        }

        [Test]
        public void Deck16_fupalorda_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",15),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck17_litianshuo670_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-09",16),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck18_thepensword_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",17),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_ScreenwriterNY_SnowControl_SultaiSnow_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",18),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_Urzza100_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",19),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck21_Oldbagobones_Smallpox_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-09",20),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Kotva_NinjaFaeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-06-09",21),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(NinjaFaeries),
                null,
                null
            );
        }

        [Test]
        public void Deck23_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",22),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Blindside09_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-09",23),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_ilmatagatto_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",24),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck26_DarkKeeper_SnowControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",25),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_FuryGarruk_EmeriaTitan_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-09",26),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(EmeriaTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck28_MarmotaStore_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-09",27),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Blademaster777_HammerTime_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",28),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck30_NagatoBoran_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",29),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck31_XOPYC_DeathAndTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",30),
                new PostCompanionChange(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_Traft_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",31),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck33_MHayashi_RedDeckWins_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-09",32),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck34_hoveydw_Delver_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",33),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(Delver),
                null,
                null
            );
        }

        [Test]
        public void Deck35_MasterA_Goblins_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",34),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck36_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",35),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_C4N7O_SnowControl_SnowBlade_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",36),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck38_NeverDidntHaveIt_Prowess_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",37),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Justodeangelo_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",38),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck40_CordoTwin_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",39),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck41_vixyp_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",40),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck42_wambocombo2020_JeskaiAscendancy_JeskaiBreach_WURG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",41),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                null
            );
        }

        [Test]
        public void Deck43_Diem4x_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",42),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Dfeanor_PrimevalTitan_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",43),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Lucabireskusku_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-06-09",44),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck46_mrjgiles_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-06-09",45),
                new PostCompanionChange(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck47_sandoiche_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",46),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck48_kyon1024_Polymorph_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",47),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Polymorph),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck49_Girolamo1996_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",48),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Rvng_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-06-09",49),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck51_zectrooperdelta_IzzetControl_IzzetBreach_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",50),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                typeof(IzzetBreach),
                null
            );
        }

        [Test]
        public void Deck52_TscheggschDePoegg_Rock_Sultai_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",51),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Rock),
                typeof(Sultai),
                null
            );
        }

        [Test]
        public void Deck53_PuNk_TakingTurns_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",52),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck54_DoomedNecromancer_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",53),
                new PostCompanionChange(),
                ArchetypeColor.WBG,
                typeof(AbzanMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck55_willtheelf1_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",54),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Somefellow_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",55),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck57_illwill552_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",56),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck58_MartinezDP_Devoted_HeliodDevoted_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",57),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck59_Kurusu_KikiChord_WBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",58),
                new PostCompanionChange(),
                ArchetypeColor.WBRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck60_603Leb_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",59),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck61_mashmalovsky_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",60),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck62_Termahgerf_Uroza_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",61),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck63_marcofabrizi_SnowControl_SnowTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",62),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowTurns),
                null
            );
        }

        [Test]
        public void Deck64_yriel_Rock_Jund_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-09",63),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
