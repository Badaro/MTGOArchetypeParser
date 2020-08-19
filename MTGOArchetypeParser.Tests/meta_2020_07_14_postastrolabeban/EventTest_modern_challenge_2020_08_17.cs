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
    public class EventTest_modern_challenge_2020_08_17 : EventTest
    {
        [Test]
        public void Deck01_kbzx_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",0),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck02_PhillHellmuth_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck03_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SultaiControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_TwistedWombat_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",3),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck05_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Snusnumrick_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",5),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",6),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_CHILLEDADED_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Predicted_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TennTyou_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Cy4nhur_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck12_buddha715_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_staffmat1992_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",12),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Costola91_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck15_nahuel10_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",14),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_friedliverattack_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",16),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Gigy_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",17),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck19_musasabi_PrimevalTitan_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck20_Logic_JeskaiAscendancy_JeskaiBreach_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                null
            );
        }

        [Test]
        public void Deck21_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck22_PhantasmalBear_AzoriusTempo_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusTempo),
                null,
                null
            );
        }

        [Test]
        public void Deck23_drVendigo_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",22),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck24_junghans_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck25_kaikalbuquerque_Bogles_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Bullz0Eye_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",25),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck27_calheiros_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Xemnon1_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",27),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Filyoni_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_asnook_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",29),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck31_bigjc00_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",30),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck32_MCScards_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",31),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
