using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 eclipse4343: Miracles (WU)
#02 fling5133: Jund Midrange (BRG)
#03 eggybenny: Neobrand (UBG)
#04 RNGspecialist: Scapeshift (URG)
#05 gazmon48: Eldrazi Tron (C)
#06 alemilan19: Scapeshift (URG)
#07 sandydogmtg: Izzet Prowess (UR)
#08 Ouranos139: Amulet Titan (UG)
#09 yashimoro: WUBR Shadow (WUBR)
#10 DreamsOfAshiok: Eldrazi Tron (C)
#11 Icteridae: Eldrazi Tron (C)
#12 _INF_: Gifts Storm (UR)
#13 Nammersquats: Infect (UG)
#14 StormQrow: Jund Midrange (BRG)
#15 RogerSteady: Grixis Control (UBR)
#16 Xwhale: Eldrazi Tron (C)
#17 Toastxp: Mardu Prowess (WBR, Lurrus)
#18 juzam_gin: Dredge (WBRG)
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
        public void Deck01_eclipse4343_Miracles_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",0),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "Miracles",
                null,
                null
            );
        }

        [Test]
        public void Deck02_fling5133_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",1),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_eggybenny_Neobrand_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",2),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck04_RNGspecialist_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",3),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck05_gazmon48_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",4),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_alemilan19_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",5),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck07_sandydogmtg_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",6),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck08_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",7),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck09_yashimoro_WUBRShadow_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",8),
                "PostAstrolabeBan",
                ArchetypeColor.WUBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck10_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",9),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck11_Icteridae_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",10),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck12_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",11),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",12),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck14_StormQrow_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",13),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_RogerSteady_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",14),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Xwhale_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",15),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck17_Toastxp_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",16),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_juzamgin_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",17),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck19_grahams_Crabvine_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",18),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Lexmart_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",19),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Graciasportanto_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",20),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck22_StoreShop275_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",21),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck23_MZBlazer_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-23",22),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }


    }
}
