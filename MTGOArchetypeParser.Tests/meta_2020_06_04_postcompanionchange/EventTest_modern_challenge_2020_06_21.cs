using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_challenge_2020_06_21 : EventTest
    {
        [Test]
        public void Deck01_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",0),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_xakx47x_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",1),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_1yo2yo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",2),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_tuhoajatane_PrimevalTitan_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",3),
                new PostCompanionChange(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck05_Jiggywiggy_KinnanUrza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",4),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_PaChA94s_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",5),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Misplacedginger_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",6),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",7),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kbr3_HardenedScales_G()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",8),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck10_MikeEgan_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",9),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Yooisa_Infect_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",10),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck12_bntrusty14_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",11),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_kanister_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",12),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck14_GoblinK1ng_Goblins_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",13),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck15_haruhilmi24_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",14),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Archgaze_Winota_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",15),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck17_FranPi_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",16),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck18_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",17),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Erik157751_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",18),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck20_bladede_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",19),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Zeekery_ThingAscension_WUR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",20),
                new PostCompanionChange(),
                ArchetypeColor.WUR,
                typeof(ThingAscension),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_antonio13901390_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",21),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck23_katoriarch123_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",22),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Anicet0_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",23),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck25_MadMaxErnst_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",24),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Jenara19_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",25),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck27_Larry11_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",26),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck28_ubercrisis_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",27),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck29_remf_Spirits_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",28),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck30_kalibak_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",29),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck31_NewHJ_Burn_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",30),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Manacymbal_KinnanUrza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",31),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
