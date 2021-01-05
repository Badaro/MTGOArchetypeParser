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
#01 Tiemuuu: Izzet Control (UR)
#02 xakx47x: Devoted (WG, Lurrus)
#03 1yo2yo: Thopter Urza (UBR)
#04 tuhoajatane: Amulet Titan (UG)
#05 Jiggywiggy: Kinnan Legends (URG, Yorion)
#06 PaChA94s: Ad Nauseam (WUB)
#07 Misplacedginger: Bant Control (WUG)
#08 SvenSveeterSven: Izzet Control (UR)
#09 kbr3: Hardened Scales (G)
#10 MikeEgan: Niv To Light (WUBRG)
#11 Yooisa: Infect (WUG)
#12 bntrusty14: Humans (WUBRG)
#13 kanister: Humans (WUBRG)
#14 GoblinK1ng: Goblins (BRG)
#15 haruhilmi24: Eldrazi Tron (C)
#16 Archgaze: Winota (WRG)
#17 FranPi: Gifts Storm (UR)
#18 MrRaeb: Uroza (UBG, Yorion)
#19 Erik157751: Eldrazi Tron (C)
#20 bladede: Eldrazi Tron (C)
#21 Zeekery: Thing Ascension (WUR, Lurrus)
#22 antonio13901390: Eldrazi Tron (C)
#23 katoriarch123: Bant Control (WUG)
#24 Anicet0: Eldrazi Tron (C)
#25 MadMaxErnst: Uroza (UG)
#26 Jenara19: Sultai Control (UBG)
#27 Larry11: Gruul Midrange (RG)
#28 ubercrisis: Sultai Control (UBG)
#29 remf: Spirits (WUG)
#30 kalibak: Burn (WR)
#31 NewHJ: Burn (WR)
#32 Manacymbal: Kinnan Legends (URG, Yorion)
*/

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
                typeof(GenericControl),
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
        public void Deck04_tuhoajatane_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",3),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck05_Jiggywiggy_KinnanLegends_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",4),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(KinnanLegends),
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
        public void Deck07_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",6),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
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
                typeof(GenericControl),
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
        public void Deck10_MikeEgan_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",9),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
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
        public void Deck14_GoblinK1ng_Goblins_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",13),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck15_haruhilmi24_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",14),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
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
        public void Deck19_Erik157751_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",18),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck20_bladede_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",19),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
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
        public void Deck22_antonio13901390_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",21),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck23_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",22),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Anicet0_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",23),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck25_MadMaxErnst_Uroza_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",24),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Jenara19_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",25),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Larry11_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",26),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_ubercrisis_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",27),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_remf_Spirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",28),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
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
        public void Deck31_NewHJ_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",30),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Manacymbal_KinnanLegends_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-21",31),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(KinnanLegends),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
