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
    public class EventTest_modern_challenge_2020_08_12 : EventTest
    {
        [Test]
        public void Deck01_Gerschi_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SultaiControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Yooisa_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck04_HouseOfManaMTG_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",3),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck05_dsissowin_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck06_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck07_sakuragi21722749_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",6),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_MrRaeb_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",7),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Predicted_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck10_gazmon48_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",9),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck11_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",10),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Maox_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck13_FabriceK_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",12),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck14_kefka27_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",13),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_albert62_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck16_MissTrigger_Burn_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",15),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck17_jvidarte_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck18_nahuel10_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck19_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_harukispecial_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",19),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck21_Falcon_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck22_Gabriele2020_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Ryan100495_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck24_kthanakit26_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",23),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck25_thekingofnone_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",24),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck26_belanna999_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",25),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck27_TheSouthDakota_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",26),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck28_HIziri88_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",27),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck29_mariogomes097_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck30_kaikalbuquerque_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",29),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck31_unicornparadise_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_RaptorNachos_Prowess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",31),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }


    }
}
