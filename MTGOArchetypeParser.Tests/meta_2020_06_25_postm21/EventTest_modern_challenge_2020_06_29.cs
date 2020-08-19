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
    public class EventTest_modern_challenge_2020_06_29 : EventTest
    {
        [Test]
        public void Deck01_katoriarch123_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",0),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_bobthedog_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",1),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck03_gazmon48_Prowess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",2),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_kbr3_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",3),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Lavaridge_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",4),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck06_OYU_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",5),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck07_RogerSteady_Delver_GrixisDelver_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",6),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(Delver),
                typeof(GrixisDelver),
                null
            );
        }

        [Test]
        public void Deck08_EGirlUWU_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",7),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_v3sptv_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",8),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck10_distanthamster_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",9),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck11_mariogomes097_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",10),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck12_MrSheep_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",11),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck13_WuYuHsien_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",12),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Voltzwagon_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",13),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck15_McWinSauce_SnowControl_SnowBlade_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",14),
                new PostM21(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck16_Janh_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",15),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck17_stainerson_Elves_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",16),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck18_ncowden_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",17),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck19_2radMTG_SnowControl_SnowReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",18),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck20_indianpancake_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",19),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_TwistedWombat_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",20),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_Blitzlion27_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",21),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck23_roterErzengel_Infect_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",22),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck24_FranPi_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",23),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck25_D00mwake_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",24),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck26_unicornparadise_Infect_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",25),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck27_bladede_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",26),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck28_medvedev_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",27),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck29_Shatun_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",28),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck30_sora1248_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",29),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck31_ArchaeusDota_GTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",30),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck32_SkiLwrAp_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",31),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }


    }
}
