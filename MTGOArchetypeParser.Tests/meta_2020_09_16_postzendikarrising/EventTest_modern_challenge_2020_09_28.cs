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
#01 TuggaNaxos: Shadow Prowess (BR, Lurrus)
#02 alexmw14: Jund Shadow (BRG)
#03 DaniMRebel: Spirits (WU)
#04 HouseOfManaMTG: Amulet Titan (UG)
#05 coert: Heliod Combo (WG)
#06 HamburgerJung: Green Tron (G, Jegantha)
#07 Chefen: Belcher (RG)
#08 ilsecco14: Neobrand (UG)
#09 N3to: Gifts Storm (UR)
#10 Gigy: Naya Midrange (WRG)
#11 gazmon48: Orzhov Midrange (WB)
#12 ZYURYO: WURG Control (WURG)
#13 Manuel_Danninger: Mardu Midrange (WBR)
#14 audio336: Shadow Prowess (BRG, Lurrus)
#15 Mateusf34: Eldrazi Tron (C)
#16 Jenara19: UBRG Control (UBRG)
#17 Lord_of_Puntlantis: Electro Balance (URG)
#18 Jositoshekel: Burn (WR, Lurrus)
#19 Polikasoll: Izzet Prowess (UR)
#20 GideonRavensword: Dredge (BRG)
#21 Beltan3: Ad Nauseam (WUB)
#22 Rinko: Enduring Ideal (WR)
#23 joetru: Niv To Light (WUBRG)
#24 futureshok: Jund Midrange (BRG)
#25 Erik157751: Shadow Prowess (BR, Lurrus)
#26 PhantasmalBear: Scapeshift (URG)
#27 MissTrigger: Bogles (WG)
#28 HotBread: Shadow Prowess (BR, Lurrus)
#29 ziofrancone: Elementals (WUBRG)
#30 Oscar_Franco: Grixis Shadow (UBR)
#31 _Batutinha_: WURG Control (WURG)
#32 Bayesta_93: Shadow Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_09_28 : EventTest
    {
        [Test]
        public void Deck01_TuggaNaxos_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",0),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_alexmw14_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",1),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck03_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",2),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck04_HouseOfManaMTG_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",3),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck05_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",4),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck06_HamburgerJung_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",5),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck07_Chefen_Belcher_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",6),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck08_ilsecco14_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",7),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck09_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",8),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Gigy_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",9),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_gazmon48_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",10),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck12_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",11),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_ManuelDanninger_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",12),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_audio336_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",13),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",14),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck16_Jenara19_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",15),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_LordofPuntlantis_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",16),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck18_Jositoshekel_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",17),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_Polikasoll_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",18),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck20_GideonRavensword_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",19),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Beltan3_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",20),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",21),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "EnduringIdeal",
                null,
                null
            );
        }

        [Test]
        public void Deck23_joetru_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",22),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck24_futureshok_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",23),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck25_Erik157751_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",24),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_PhantasmalBear_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",25),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck27_MissTrigger_Bogles_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",26),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck28_HotBread_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",27),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_ziofrancone_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",28),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Elementals",
                null,
                null
            );
        }

        [Test]
        public void Deck30_OscarFranco_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",29),
                "PostZendikarRising",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Batutinha_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",30),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_Bayesta93_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",31),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
