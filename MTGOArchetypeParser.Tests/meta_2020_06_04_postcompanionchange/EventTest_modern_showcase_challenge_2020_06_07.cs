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
#01 Do0mSwitch: BantControl (WUG)
#02 hugofreitas1: GiftsStorm (UR)
#03 nathansteuer: Uroza (URG)
#04 McWinSauce: BantControl (WUG)
#05 Finalnub: Neobrand (UG)
#06 SebastianStueckl: GruulMidrange (RG)
#07 MatheusPonciano: Dredge (UBRG)
#08 cftsoc3: BantBlink (WUG, Yorion)
#09 PietroSas: Devoted (WG, Lurrus)
#10 TheTunnelingCat: ETron (C)
#11 Sonso JF: HeliodDevoted (WBG)
#12 Moniz0801: KGCAmuletTitan (WUBRG)
#13 SpiderSpace: HardenedScales (G)
#14 patrick50: Devoted (WG, Lurrus)
#15 rn17: ThopterUrza (UBR)
#16 Trellon: UTron (U)
#17 _Batutinha_: BantControl (WUG)
#18 TSPJendrek: WUBGControl (WUBG)
#19 solace: GruulMidrange (RG)
#20 Zebrah: AmuletTitan (WUBRG)
#21 DavidDPanda: ETron (C)
#22 FreedMania: AmuletTitan (WUBRG)
#23 BaronOfBacon: Humans (WUBRG)
#24 GiovaniMF: Burn (WR)
#25 Icteridae: HeliodDevoted (WUG)
#26 bobjackson: KGCTron (G, Jegantha)
#27 Ennuixd: AmuletTitan (WURG)
#28 pbarrrgh: SultaiReclamation (UBG)
#29 Shorak123: SultaiReclamation (UBG)
#30 JMoney8771: Infect (UG)
#31 stainerson: BantControl (WUG)
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
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",1),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck03_nathansteuer_Uroza_URG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",2),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",3),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Finalnub_Neobrand_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",4),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",5),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_MatheusPonciano_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",6),
                new PostCompanionChange(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_cftsoc3_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",7),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_PietroSas_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",8),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_TheTunnelingCat_ETron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",9),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_SonsoJF_HeliodDevoted_WBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",10),
                new PostCompanionChange(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck12_Moniz0801_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",11),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_SpiderSpace_HardenedScales_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",12),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck14_patrick50_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",13),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_rn17_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",14),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",15),
                new PostCompanionChange(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",16),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_TSPJendrek_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",17),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_solace_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",18),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Zebrah_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",19),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck21_DavidDPanda_ETron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",20),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck22_FreedMania_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",21),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck23_BaronOfBacon_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",22),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck24_GiovaniMF_Burn_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",23),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Icteridae_HeliodDevoted_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",24),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck26_bobjackson_KGCTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",25),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck27_Ennuixd_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",26),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck28_pbarrrgh_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",27),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Shorak123_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",28),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck30_JMoney8771_Infect_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",29),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck31_stainerson_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",30),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_sora1248_Winota_WRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-06-07",31),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(Winota),
                null,
                null
            );
        }


    }
}
