using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Aardos: Ad Nauseam (WUB)
#02 Bullwinkkle6705: WURG Control (WURG)
#03 Destraschul: Ad Nauseam (WUB)
#04 quinniac: Burn (WR)
#05 RespectTheCat: Selesnya Taxes (WG, Yorion)
#06 ice_nine_: Land Destruction (WR)
#07 nsroller: Heliod Combo (WG)
#08 kefka27: Izzet Prowess (UR)
#09 indianpancake: Reclaimer Titan (WRG)
#10 EdB: Amulet Titan (G)
#11 Adincann: WURG Control (WURG)
#12 Lord_Beerus: Burn (WR)
#13 shadow_PT: Shadow Prowess (BR, Lurrus)
#14 CanadianNinja: Niv To Light (WUBRG, Yorion)
#15 exoticherman: Shadow Prowess (BRG, Lurrus)
#16 Moniz0801: Amulet Titan (UG)
#17 Brasatore: Hammer Time (W, Lurrus)
#18 Artem_Kuhtin: Spirits (WU)
#19 rereknit16: Mill (UB, Lurrus)
#20 silvanelf7: Burn (WR)
#21 ZYURYO: Belcher (URG)
#22 Phill_Hellmuth: Hammer Time (WG, Lurrus)
#23 WareHouseGames: Burn (WR)
#24 Oceansoul92: Heliod Combo (WG)
#25 PuntThenWhine: Amulet Titan (UG)
#26 _Tia93_: WURG Control (WURG)
#27 Phil_Ivey: Izzet Prowess (UR)
#28 Sodeq: Belcher (URG)
#29 naddyeffintabs: Hammer Time (WR, Lurrus)
#30 SvenSveeterSven: Izzet Control (UR)
#31 ChildOfAlara7: Reclamation (UBG)
#32 Jaberwocki: Jund Shadow (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2021_01_24 : EventTest
    {
        [Test]
        public void Deck01_Aardos_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",0),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Bullwinkkle6705_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Destraschul_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",2),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck04_quinniac_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",3),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck05_RespectTheCat_SelesnyaTaxes_WG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",4),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Taxes",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_icenine_LandDestruction_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",5),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "LandDestruction",
                null,
                null
            );
        }

        [Test]
        public void Deck07_nsroller_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",6),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck08_kefka27_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",7),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_indianpancake_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",8),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck10_EdB_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",9),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck11_Adincann_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",10),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",11),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck13_shadowPT_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",12),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_CanadianNinja_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",13),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_exoticherman_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",14),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Moniz0801_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",15),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck17_Brasatore_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",16),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_ArtemKuhtin_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",17),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck19_rereknit16_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",18),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_silvanelf7_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",19),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck21_ZYURYO_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",20),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck22_PhillHellmuth_HammerTime_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",21),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_WareHouseGames_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",22),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck24_Oceansoul92_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",23),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck25_PuntThenWhine_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",24),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck26_Tia93_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",25),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck27_PhilIvey_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",26),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck28_Sodeq_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",27),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck29_naddyeffintabs_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",28),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",29),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck31_ChildOfAlara7_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",30),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck32_Jaberwocki_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-24",31),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
