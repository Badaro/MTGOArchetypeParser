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
    public class EventTest_modern_league_2020_07_17 : EventTest
    {
        [Test]
        public void Deck01_Wuhsa_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-17",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_CedricChatel_IzzetControl_IzzetBreach_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                typeof(IzzetBreach),
                null
            );
        }

        [Test]
        public void Deck03_Cherryxman_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck04_rodeo_Burn_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-07-17",3),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck05_PanCementJP_Spirits_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck06_cntrlfreak_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck07_Dwagz_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",6),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck08_saccij92_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Fabrioteo_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-17",8),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_maple049_HardenedScales_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-17",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_kogamo_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-17",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Silence9428_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck13_moutierdu42_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck14_Elibaechan_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",13),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck15_MinCash_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-17",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck16_bkorbsquare07_Prowess_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck17_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck18_CitrusD_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck19_argentopnz88_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck20_chengyiw_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",19),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck21_austinflakesss_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck22_SaltySteve_NinjaFaeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-17",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(NinjaFaeries),
                null,
                null
            );
        }

        [Test]
        public void Deck23_yuseimax_Soulflayer_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",22),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Soulflayer),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Shatun_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",23),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck25_OscarS66_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",24),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Zxrogue_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-17",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_Zebrah_DeathAndTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-17",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_nahuel10_SnowControl_SnowReclamation_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck29_NHA37_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck30_TubbyBatman_Delver_TemurDelver_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",29),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Delver),
                typeof(TemurDelver),
                null
            );
        }

        [Test]
        public void Deck31_jundecide_Rock_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Gleiciano_GTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-17",31),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Goteo_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",32),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck34_TheLousyZoot_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",33),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck35_aspiringspike_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",34),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck36_6argamel_DeathAndTaxes_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",35),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck37_GHash77_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck38_bubbsei_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-17",37),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck39_OliverHart_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-07-17",38),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck40_pbarrrgh_AzoriusControl_Miracles_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-17",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
                null
            );
        }

        [Test]
        public void Deck41_BrunoMineiro_DeathAndTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-17",40),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck42_jimdownside_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck43_teagantime_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",42),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck44_tanisong1221_DeathsShadow_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-17",43),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(DeathsShadow),
                typeof(OrzhovShadow),
                null
            );
        }

        [Test]
        public void Deck45_Pirika_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",44),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck46_llabmonkey_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",45),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck47_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",46),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck48_KYUNphago_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-17",47),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck49_BubbleDJ10_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-17",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck50_MHayashi_RedDeckWins_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-17",49),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck51_CNewman_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",50),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck52_Pendragon15038_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-07-17",51),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Pirika_IzzetFreeSpells_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",52),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetLivingEnd),
                null
            );
        }


    }
}
