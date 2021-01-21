using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 bobthedog: Sultai Control (UBG)
#02 SvenSveeterSven: Izzet Control (UR)
#03 Mcleskey: Burn (WR)
#04 Laplasjan: Devoted (WG, Lurrus)
#05 indianpancake: Gruul Midrange (RG)
#06 MadMaxErnst: Uroza (URG)
#07 tendercloud: Hardened Scales (BG, Lurrus)
#08 TSPJendrek: UBRG Control (UBRG)
#09 TheTunnelingCat: Eldrazi Tron (C)
#10 GoblinK1ng: Goblins (BRG)
#11 bcs8995: Bant Control (WUG, Yorion)
#12 SchulzCubed: Taking Turns (UR)
#13 Lord_Beerus: Burn (WR, Lurrus)
#14 lovealienzzz: Temur Control (URG)
#15 sakuragi21722749: Eldrazi Tron (C)
#16 staples87: Eldrazi Tron (C)
#17 AndyAWKWARD: Scapeshift (URG)
#18 Sonso JF: Thopter Urza (UBR)
#19 ConnorM426: Reclamation (UBG, Yorion)
#20 headshotcatcher: Gruul Midrange (RG)
#21 Chris_Concarnage: Eldrazi Tron (C)
#22 GedionRavenor: Bant Control (WUG)
#23 Nyph: Amulet Titan (UG)
#24 eminemberry: Burn (WR)
#25 d_peliser: Bant Control (WUG)
#26 ContraEgo: Thopter Urza (UBR)
#27 SebastianStueckl: Gruul Midrange (RG)
#28 PeanutBrittle: Gifts Storm (UR)
#29 Kuhb: Grinding Breach (WURG)
#30 Math_God: Gifts Storm (UR)
#31 SunofNothing: Uroza (URG)
#32 exoticherman: Infect (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_challenge_2020_06_14 : EventTest
    {
        [Test]
        public void Deck01_bobthedog_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",0),
                "PostCompanionChange",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",1),
                "PostCompanionChange",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",2),
                "PostCompanionChange",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck04_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",3),
                "PostCompanionChange",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_indianpancake_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",4),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_MadMaxErnst_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",5),
                "PostCompanionChange",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck07_tendercloud_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",6),
                "PostCompanionChange",
                ArchetypeColor.BG,
                "HardenedScales",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_TSPJendrek_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",7),
                "PostCompanionChange",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",8),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck10_GoblinK1ng_Goblins_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",9),
                "PostCompanionChange",
                ArchetypeColor.BRG,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck11_bcs8995_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",10),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_SchulzCubed_TakingTurns_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",11),
                "PostCompanionChange",
                ArchetypeColor.UR,
                "TakingTurns",
                null,
                null
            );
        }

        [Test]
        public void Deck13_LordBeerus_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",12),
                "PostCompanionChange",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_lovealienzzz_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",13),
                "PostCompanionChange",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_sakuragi21722749_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",14),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck16_staples87_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",15),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck17_AndyAWKWARD_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",16),
                "PostCompanionChange",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck18_SonsoJF_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",17),
                "PostCompanionChange",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck19_ConnorM426_Reclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",18),
                "PostCompanionChange",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_headshotcatcher_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",19),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck21_ChrisConcarnage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",20),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck22_GedionRavenor_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",21),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Nyph_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",22),
                "PostCompanionChange",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck24_eminemberry_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",23),
                "PostCompanionChange",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck25_dpeliser_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",24),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck26_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",25),
                "PostCompanionChange",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck27_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",26),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck28_PeanutBrittle_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",27),
                "PostCompanionChange",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Kuhb_GrindingBreach_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",28),
                "PostCompanionChange",
                ArchetypeColor.WURG,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck30_MathGod_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",29),
                "PostCompanionChange",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck31_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",30),
                "PostCompanionChange",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck32_exoticherman_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",31),
                "PostCompanionChange",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }


    }
}
