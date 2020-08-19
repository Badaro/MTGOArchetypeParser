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
    public class EventTest_modern_challenge_2020_08_16 : EventTest
    {
        [Test]
        public void Deck01_gazmon48_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",0),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck02_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_aplapp_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",2),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Pennywisse_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck05_exoticherman_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",4),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_flatnose_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Rav104_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_edward40hands_Rock_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",7),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck09_sinforlife54_DeathAndTaxes_EldraziTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",8),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck10_otakkun_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",9),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck11_uaedoliB_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck12_nick4567_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",11),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck13_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck15_asnook_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck16_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",15),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck17_kanister_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Delthar_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Toastxp_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Gigy_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",19),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Luzur_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck22_spellvine_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck23_HouseOfManaMTG_TitanVial_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(TitanVial),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Yanti_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",23),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck25_Storytime_Devoted_KinnanDevoted_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(KinnanDevoted),
                null
            );
        }

        [Test]
        public void Deck26_Xuxa_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",25),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck27_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck28_ConnorM426_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",27),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck29_musasabi_PrimevalTitan_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck30_NHA37_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",29),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck31_BSKhercules_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",30),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck32_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }


    }
}
