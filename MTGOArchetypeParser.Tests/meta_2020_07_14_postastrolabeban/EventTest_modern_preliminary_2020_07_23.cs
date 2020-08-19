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
    public class EventTest_modern_preliminary_2020_07_23 : EventTest
    {
        [Test]
        public void Deck01_eclipse4343_AzoriusControl_Miracles_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
                null
            );
        }

        [Test]
        public void Deck02_fling5133_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",1),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck03_eggybenny_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck04_RNGspecialist_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",3),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck05_gazmon48_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",4),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_alemilan19_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",5),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck07_sandydogmtg_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",6),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck08_Ouranos139_PrimevalTitan_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_yashimoro_DeathsShadow_EsperShadow_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBR,
                typeof(DeathsShadow),
                typeof(EsperShadow),
                null
            );
        }

        [Test]
        public void Deck10_DreamsOfAshiok_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",9),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Icteridae_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",10),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck14_StormQrow_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",13),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck15_RogerSteady_GrixisEnforcer_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",14),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GrixisEnforcer),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Xwhale_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",15),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Toastxp_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_juzamgin_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_grahams_Crabvine_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Lexmart_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Graciasportanto_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",20),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck22_StoreShop275_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",21),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck23_MZBlazer_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }


    }
}
