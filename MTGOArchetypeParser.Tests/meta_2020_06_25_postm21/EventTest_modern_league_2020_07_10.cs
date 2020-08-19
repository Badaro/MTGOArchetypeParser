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
    public class EventTest_modern_league_2020_07_10 : EventTest
    {
        [Test]
        public void Deck01_psych4tog_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",0),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck02_tcgshin_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",1),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck03_PanCementJP_Spirits_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",2),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck04_saccij92_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",3),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_yPrincipe_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-10",4),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_ArchaeusDota_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-10",5),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck07_BigAndEasy_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-10",6),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Rossello_Burn_IncineratorBurn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",7),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck09_meanfannypack_DeathsShadow_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-10",8),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(DeathsShadow),
                typeof(OrzhovShadow),
                null
            );
        }

        [Test]
        public void Deck10_DoniDominaria_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-10",9),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_AndersPovirk_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",10),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Polikasoll_Burn_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-07-10",11),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck13_Parrit_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-07-10",12),
                new PostM21(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck14_kogamo_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-10",13),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Phyziks42_Ponza_WRG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",14),
                new PostM21(),
                ArchetypeColor.WRG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_musasabi_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",15),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck17_Silence9428_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",16),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Do0mSwitch_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",17),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck19_mauricio998_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-10",18),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Shatun_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",19),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_PanicDaddy_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-10",20),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck22_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-10",21),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_Pendragon15038_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-07-10",22),
                new PostM21(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck24_babamm_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",23),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck25_HiroHsiang_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",24),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck26_Curveiganhei_RedDeckWins_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-10",25),
                new PostM21(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck27_KieranT_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",26),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck28_yPrincipe_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-10",27),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",28),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_wefald_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-10",29),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck31_scvslayer_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-10",30),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_MartinezDP_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-10",31),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck33_maear_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",32),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Loreington_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",33),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Evaros_DeathAndTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-10",34),
                new PostM21(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck36_yumad3988_HollowOne_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",35),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(HollowOne),
                null,
                null
            );
        }

        [Test]
        public void Deck37_gobboboy_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-10",36),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck38_osmanozguney_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-10",37),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(DimirControl),
                null,
                null
            );
        }

        [Test]
        public void Deck39_AnneLivleysD3ath_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",38),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck40_SiDa1991_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-10",39),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck41_DylanMTG_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",40),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck42_BossBr_DeathAndTaxes_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-10",41),
                new PostM21(),
                ArchetypeColor.WU,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }


    }
}
