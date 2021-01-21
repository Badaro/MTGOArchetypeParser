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
#08 benchsummer: UBRG Shadow (UBRG)
#09 Butakov: WURG Control (WURG)
#10 HouseOfManaMTG: Amulet Titan (G)
#11 bobthedog: Bant Blink (WUG)
#12 albert62: Jund Midrange (BRG)
#13 kthanakit26: Boros Prowess (WR, Lurrus)
#14 Delthar: Infect (UG)
#15 Fatcaster_Mage: Sultai Control (UBG)
#16 Artem_Kuhtin: White Devotion (W)
#17 NorrathDecay: Burn (WR)
#18 Mateusf34: Eldrazi Tron (C)
#19 WeareVenom: WURG Control (WURG)
#20 WhiTe TsaR: Humans (WUBRG)
#21 RAINkratos: Humans (WUBRG)
#22 Nikachu: Merfolk (UG)
#23 Granham: Green Tron (G)
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
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck02_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",1),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck03_GiocatoreMedio92_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",2),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Xwhale_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",3),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck05_maximusdee_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",4),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",5),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_trader08111_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",6),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",7),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Butakov_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",8),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_HouseOfManaMTG_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",9),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck11_bobthedog_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",10),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck12_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",11),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_kthanakit26_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",12),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Delthar_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",13),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck15_FatcasterMage_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",14),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_ArtemKuhtin_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",15),
                "PostZendikarRising",
                ArchetypeColor.W,
                "WhiteDevotion",
                null,
                null
            );
        }

        [Test]
        public void Deck17_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",16),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck18_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",17),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck19_WeareVenom_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",18),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck20_WhiTeTsaR_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",19),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck21_RAINkratos_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",20),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Nikachu_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",21),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Granham_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",22),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck24_SebastianStueckl_Belcher_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",23),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck25_AstralPlane_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",24),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_Selami_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",25),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Trid0n_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",26),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",27),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",28),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "KikiChord",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck30_Gerschi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",29),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_2jjm_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",30),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck32_Lukas261997_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-21",31),
                "PostZendikarRising",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }


    }
}
