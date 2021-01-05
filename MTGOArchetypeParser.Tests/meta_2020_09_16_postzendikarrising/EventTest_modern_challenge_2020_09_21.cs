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
#01 coert: Heliod Combo (WG)
#02 DaniMRebel: Spirits (WU)
#03 Giocatore_Medio_92: Humans (WUBRG)
#04 Xwhale: Humans (WUBRG)
#05 maximusdee: Shadow Prowess (BRG, Lurrus)
#06 McWinSauce: WURG Control (WURG)
#07 trader08111: Gruul Midrange (RG)
#08 benchsummer: Jund Shadow (BRG)
#09 Butakov: WURG Control (WURG)
#10 HouseOfManaMTG: Amulet Titan (G)
#11 bobthedog: Bant Blink (WUG)
#12 albert62: Jund Midrange (BRG)
#13 kthanakit26: Boros Prowess (WR, Lurrus)
#14 Delthar: Infect (UG)
#15 Fatcaster_Mage: Sultai Control (UBG)
#16 Artem_Kuhtin: White Devotion (W)
#17 NorrathDecay: Burn (WR)
#18 Mateusf34: E Tron (C)
#19 WeareVenom: WURG Control (WURG)
#20 WhiTe TsaR: Humans (WUBRG)
#21 RAINkratos: Humans (WUBRG)
#22 Nikachu: Merfolk (UG)
#23 Granham: KGC Tron (G)
#24 SebastianStueckl: Belcher (WRG)
#25 AstralPlane: Rakdos Prowess (BR, Lurrus)
#26 Selami: Ad Nauseam (WUB)
#27 Trid0n: Bogles (WG, Lurrus)
#28 katoriarch123: Bant Control (WUG)
#29 Kurusu: Kiki Chord (WRG, Yorion)
#30 Gerschi: Shadow Prowess (BR, Lurrus)
#31 2jjm: Burn (WR)
#32 Lukas261997: Grixis Shadow (UBR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_09_21 : EventTest
    {
        [Test]
        public void Deck01_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",0),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck02_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",1),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck03_GiocatoreMedio92_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",2),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Xwhale_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_maximusdee_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",4),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_trader08111_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",6),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_benchsummer_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",7),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Butakov_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",8),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_HouseOfManaMTG_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",9),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck11_bobthedog_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",10),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck12_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",11),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_kthanakit26_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",12),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Delthar_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",13),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck15_FatcasterMage_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",14),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_ArtemKuhtin_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",15),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(NykthosDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck17_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",16),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",17),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck19_WeareVenom_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",18),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_WhiTeTsaR_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",19),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck21_RAINkratos_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",20),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Nikachu_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",21),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Granham_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",22),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck24_SebastianStueckl_Belcher_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",23),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck25_AstralPlane_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",24),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_Selami_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",25),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Trid0n_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",26),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",27),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",28),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck30_Gerschi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",29),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_2jjm_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",30),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Lukas261997_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",31),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }


    }
}
