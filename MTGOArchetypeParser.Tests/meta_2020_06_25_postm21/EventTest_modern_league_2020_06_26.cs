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
    public class EventTest_modern_league_2020_06_26 : EventTest
    {
        [Test]
        public void Deck01_nahuel10_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-26",0),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Ennuixd_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-06-26",1),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Lucabireskusku_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-06-26",2),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Audemin_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-26",3),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_koji1130_RedDeckWins_WR_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-26",4),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck06_StreexIT_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-26",5),
                new PostM21(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck07_rojanosa_Tokens_OrzhovTokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-26",6),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(Tokens),
                typeof(OrzhovTokens),
                null
            );
        }

        [Test]
        public void Deck08_haubidtran_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-26",7),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_esatheking_Prowess_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-26",8),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_yPrincipe_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-06-26",9),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_magicjpg_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-26",10),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_Psychophobic_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-26",11),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Borjillamtg10_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-06-26",12),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck14_603Leb_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-26",13),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck15_MadRamon_SnowControl_SnowReclamation_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-26",14),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_Mordeka1ser_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-26",15),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck17_Zebrah_PrimevalTitan_AmuletTitan_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-26",16),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Shorak123_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-26",17),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck19_Beicodegeia_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-26",18),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck20_FantasticMrFox_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-26",19),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_RockStar_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-26",20),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_Bunnykept_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-26",21),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck23_Lcario_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-26",22),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck24_Gaffiere1903_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-26",23),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Nogamblenofutur_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-26",24),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Justodeangelo_SnowControl_SnowReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-26",25),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck27_SightWinner_HollowOne_BR()
        {
            Test(
                GetDeck("modern-league-2020-06-26",26),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(HollowOne),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Pirika_MarduPyromancer_WBR()
        {
            Test(
                GetDeck("modern-league-2020-06-26",27),
                new PostM21(),
                ArchetypeColor.WBR,
                typeof(MarduPyromancer),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Xorn9_Goblins_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-26",28),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck30_vengevine29_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-26",29),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_SebastianStueckl_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-06-26",30),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck32_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-06-26",31),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Netow_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-26",32),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Sonkerz_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-26",33),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_PieGonti_KinnanUrza_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-26",34),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck36_Piccio36_Winota_WRG()
        {
            Test(
                GetDeck("modern-league-2020-06-26",35),
                new PostM21(),
                ArchetypeColor.WRG,
                typeof(Winota),
                null,
                null
            );
        }


    }
}
