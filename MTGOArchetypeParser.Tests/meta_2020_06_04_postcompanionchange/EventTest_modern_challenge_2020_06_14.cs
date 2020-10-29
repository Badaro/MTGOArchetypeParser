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
#01 bobthedog: Sultai Control (UBG)
#02 SvenSveeterSven: Izzet Control (UR)
#03 Mcleskey: Burn (WR)
#04 Laplasjan: Devoted (WG, Lurrus)
#05 indianpancake: Gruul Midrange (RG)
#06 MadMaxErnst: Uroza (URG)
#07 tendercloud: Hardened Scales (BG, Lurrus)
#08 TSPJendrek: UBRG Control (UBRG)
#09 TheTunnelingCat: E Tron (C)
#10 GoblinK1ng: Goblins (WUBRG)
#11 bcs8995: Bant Control (WUG, Yorion)
#12 SchulzCubed: Fires Turns (UR)
#13 Lord_Beerus: Burn (WR, Lurrus)
#14 lovealienzzz: Temur Control (URG)
#15 sakuragi21722749: E Tron (C)
#16 staples87: E Tron (C)
#17 AndyAWKWARD: Scapeshift (URG)
#18 Sonso JF: Thopter Urza (UBR)
#19 ConnorM426: Sultai Reclamation (UBG, Yorion)
#20 headshotcatcher: Gruul Midrange (RG)
#21 Chris_Concarnage: E Tron (C)
#22 GedionRavenor: Bant Control (WUG)
#23 Nyph: Amulet Titan (UBRG)
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
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",1),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",2),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",3),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_indianpancake_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",4),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_MadMaxErnst_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",5),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck07_tendercloud_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",6),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_TSPJendrek_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",7),
                new PostCompanionChange(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_TheTunnelingCat_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",8),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_GoblinK1ng_Goblins_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",9),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck11_bcs8995_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",10),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_SchulzCubed_FiresTurns_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",11),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(TakingTurns),
                typeof(FiresTurns),
                null
            );
        }

        [Test]
        public void Deck13_LordBeerus_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",12),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_lovealienzzz_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",13),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_sakuragi21722749_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",14),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_staples87_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",15),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_AndyAWKWARD_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",16),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck18_SonsoJF_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",17),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck19_ConnorM426_SultaiReclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",18),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_headshotcatcher_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",19),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_ChrisConcarnage_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",20),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck22_GedionRavenor_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",21),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Nyph_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",22),
                new PostCompanionChange(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_eminemberry_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",23),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck25_dpeliser_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",24),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",25),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck27_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",26),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_PeanutBrittle_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",27),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Kuhb_GrindingBreach_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",28),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck30_MathGod_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",29),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck31_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",30),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck32_exoticherman_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",31),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }


    }
}
