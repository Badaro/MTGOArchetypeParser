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
#01 eclipse4343: Azorius Control (WU)
#02 fling5133: Jund Midrange (BRG)
#03 eggybenny: Neobrand (UG)
#04 RNGspecialist: Scapeshift (URG)
#05 gazmon48: Eldrazi Tron (C)
#06 alemilan19: Scapeshift (URG)
#07 sandydogmtg: Izzet Prowess (UR)
#08 Ouranos139: Amulet Titan (UG)
#09 yashimoro: Esper Shadow (WUB)
#10 DreamsOfAshiok: Eldrazi Tron (C)
#11 Icteridae: Eldrazi Tron (C)
#12 _INF_: Gifts Storm (UR)
#13 Nammersquats: Infect (UG)
#14 StormQrow: Jund Midrange (BRG)
#15 RogerSteady: Grixis Control (UBR)
#16 Xwhale: Eldrazi Tron (C)
#17 Toastxp: Mardu Prowess (WBR, Lurrus)
#18 juzam_gin: Dredge (BRG)
#19 grahams: Crabvine (UBRG)
#20 Lexmart: Bant Control (WUG)
#21 Graciasportanto: Green Tron (G)
#22 StoreShop275: Eldrazi Tron (C)
#23 MZBlazer: Azorius Control (WU)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_23 : EventTest
    {
        [Test]
        public void Deck01_eclipse4343_AzoriusControl_WU()
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
        public void Deck02_fling5133_JundMidrange_BRG()
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
        public void Deck05_gazmon48_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",4),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
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
        public void Deck07_sandydogmtg_IzzetProwess_UR()
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
        public void Deck08_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_yashimoro_EsperShadow_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck10_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",9),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck11_Icteridae_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",10),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
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
        public void Deck14_StormQrow_JundMidrange_BRG()
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
        public void Deck15_RogerSteady_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",14),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Xwhale_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",15),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck17_Toastxp_MarduProwess_WBR_Lurrus()
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
        public void Deck18_juzamgin_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
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
        public void Deck21_Graciasportanto_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",20),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck22_StoreShop275_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",21),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck23_MZBlazer_AzoriusControl_WU()
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
