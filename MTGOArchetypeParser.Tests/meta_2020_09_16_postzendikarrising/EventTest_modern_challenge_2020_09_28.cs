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
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_alexmw14_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",1),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck03_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",2),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck04_HouseOfManaMTG_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",3),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck05_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",4),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck06_HamburgerJung_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",5),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck07_Chefen_Belcher_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",6),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ilsecco14_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",7),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck09_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",8),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Gigy_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",9),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_gazmon48_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",10),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",11),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_ManuelDanninger_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",12),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_audio336_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",13),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",14),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck16_Jenara19_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",15),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_LordofPuntlantis_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",16),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck18_Jositoshekel_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",17),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_Polikasoll_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",18),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck20_GideonRavensword_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",19),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Beltan3_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",20),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",21),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck23_joetru_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",22),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck24_futureshok_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",23),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Erik157751_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",24),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_PhantasmalBear_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",25),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck27_MissTrigger_Bogles_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",26),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck28_HotBread_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",27),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_ziofrancone_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",28),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck30_OscarFranco_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",29),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Batutinha_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",30),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Bayesta93_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-28",31),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
