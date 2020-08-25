using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 eclipse4343: Miracles (WU)
#02 fling5133: Jund (BRG)
#03 eggybenny: Neobrand (UG)
#04 RNGspecialist: Scapeshift (URG)
#05 gazmon48: ETron (C)
#06 alemilan19: Scapeshift (URG)
#07 sandydogmtg: IzzetProwess (UR)
#08 Ouranos139: KGCAmuletTitan (UBRG)
#09 yashimoro: EsperShadow (WUBR)
#10 DreamsOfAshiok: ETron (C)
#11 Icteridae: ETron (C)
#12 _INF_: GiftsStorm (UR)
#13 Nammersquats: Infect (UG)
#14 StormQrow: Jund (BRG)
#15 RogerSteady: GrixisEnforcer (UBR)
#16 Xwhale: ETron (C)
#17 Toastxp: RakdosProwess (WBR, Lurrus)
#18 juzam_gin: Dredge (WBRG)
#19 grahams: Crabvine (UBRG)
#20 Lexmart: BantControl (WUG)
#21 Graciasportanto: KGCTron (G)
#22 StoreShop275: ETron (C)
#23 MZBlazer: AzoriusStoneblade (WU)
*/

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
                typeof(GenericControl),
                null,
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
                typeof(GenericMidrange),
                null,
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
                typeof(GenericProwess),
                null,
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
                typeof(GenericShadow),
                null,
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
                typeof(GenericMidrange),
                null,
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
                typeof(GenericProwess),
                null,
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
                typeof(GenericControl),
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
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
