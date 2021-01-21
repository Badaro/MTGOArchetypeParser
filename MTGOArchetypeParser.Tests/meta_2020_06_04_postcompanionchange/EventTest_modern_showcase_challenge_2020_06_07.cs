using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Do0mSwitch: Bant Control (WUG)
#02 hugofreitas1: Gifts Storm (UR)
#03 nathansteuer: Uroza (URG)
#04 McWinSauce: Bant Control (WUG)
#05 Finalnub: Neobrand (WUG)
#06 SebastianStueckl: Gruul Midrange (RG)
#07 MatheusPonciano: Dredge (UBRG)
#08 cftsoc3: Bant Blink (WUG, Yorion)
#09 PietroSas: Devoted (WG, Lurrus)
#10 TheTunnelingCat: Eldrazi Tron (C)
#11 Sonso JF: Devoted (WBG)
#12 Moniz0801: Amulet Titan (UG)
#13 SpiderSpace: Hardened Scales (G)
#14 patrick50: Devoted (WG, Lurrus)
#15 rn17: Thopter Urza (UBR)
#16 Trellon: Blue Tron (U)
#17 _Batutinha_: Bant Control (WUG)
#18 TSPJendrek: WUBG Control (WUBG)
#19 solace: Gruul Midrange (RG)
#20 Zebrah: Amulet Titan (UG)
#21 DavidDPanda: Eldrazi Tron (C)
#22 FreedMania: Amulet Titan (UG)
#23 BaronOfBacon: Humans (WUBRG)
#24 GiovaniMF: Burn (WR)
#25 Icteridae: Devoted (WUG)
#26 bobjackson: Green Tron (G, Jegantha)
#27 Ennuixd: Amulet Titan (WUG)
#28 pbarrrgh: Reclamation (UBG)
#29 Shorak123: Reclamation (UBG)
#30 JMoney8771: Infect (UG)
#31 stainerson: Bant Control (WUG)
#32 sora1248: Winota (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_showcase_challenge_2020_06_07 : EventTest
    {
        [Test]
        public void Deck01_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",0),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",1),
                "PostCompanionChange",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck03_nathansteuer_Uroza_URG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",2),
                "PostCompanionChange",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck04_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",3),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Finalnub_Neobrand_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",4),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck06_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",5),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_MatheusPonciano_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",6),
                "PostCompanionChange",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck08_cftsoc3_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",7),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_PietroSas_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",8),
                "PostCompanionChange",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",9),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck11_SonsoJF_Devoted_WBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",10),
                "PostCompanionChange",
                ArchetypeColor.WBG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Moniz0801_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",11),
                "PostCompanionChange",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck13_SpiderSpace_HardenedScales_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",12),
                "PostCompanionChange",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck14_patrick50_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",13),
                "PostCompanionChange",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_rn17_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",14),
                "PostCompanionChange",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck16_Trellon_BlueTron_U()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",15),
                "PostCompanionChange",
                ArchetypeColor.U,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck17_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",16),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_TSPJendrek_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",17),
                "PostCompanionChange",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck19_solace_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",18),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Zebrah_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",19),
                "PostCompanionChange",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck21_DavidDPanda_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",20),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck22_FreedMania_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",21),
                "PostCompanionChange",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck23_BaronOfBacon_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",22),
                "PostCompanionChange",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck24_GiovaniMF_Burn_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",23),
                "PostCompanionChange",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck25_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",24),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck26_bobjackson_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",25),
                "PostCompanionChange",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck27_Ennuixd_AmuletTitan_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",26),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck28_pbarrrgh_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",27),
                "PostCompanionChange",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Shorak123_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",28),
                "PostCompanionChange",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck30_JMoney8771_Infect_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",29),
                "PostCompanionChange",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck31_stainerson_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",30),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_sora1248_Winota_WRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",31),
                "PostCompanionChange",
                ArchetypeColor.WRG,
                "Winota",
                null,
                null
            );
        }


    }
}
