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
#01 bobthedog: SultaiSnow (UBG)
#02 SvenSveeterSven: IzzetControl (UR)
#03 Mcleskey: Burn (WR)
#04 Laplasjan: Devoted (WG, Lurrus)
#05 indianpancake: Ponza (RG)
#06 MadMaxErnst: Uroza (URG)
#07 tendercloud: HardenedScales (BG, Lurrus)
#08 TSPJendrek: SultaiSnow (UBRG)
#09 TheTunnelingCat: ETron (C)
#10 GoblinK1ng: Goblins (WUBRG)
#11 bcs8995: SnowTitan (WUG, Yorion)
#12 SchulzCubed: FiresTurns (UR)
#13 Lord_Beerus: Burn (WR, Lurrus)
#14 lovealienzzz: TemurSnow (URG)
#15 sakuragi21722749: ETron (C)
#16 staples87: ETron (C)
#17 AndyAWKWARD: Scapeshift (URG)
#18 Sonso JF: ThopterUrza (UBR)
#19 ConnorM426: SnowReclamation (UBG, Yorion)
#20 headshotcatcher: Ponza (RG)
#21 Chris_Concarnage: ETron (C)
#22 GedionRavenor: SnowBlade (WUG)
#23 Nyph: AmuletTitan (UBRG)
#24 eminemberry: Burn (WR)
#25 d_peliser: SnowControl (WUG)
#26 ContraEgo: ThopterUrza (UBR)
#27 SebastianStueckl: Ponza (RG)
#28 PeanutBrittle: GiftsStorm (UR)
#29 Kuhb: GrindingBreach (WURG)
#30 Math_God: GiftsStorm (UR)
#31 SunofNothing: Uroza (URG)
#32 exoticherman: Infect (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_challenge_2020_06_14 : EventTest
    {
        [Test]
        public void Deck01_bobthedog_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",0),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
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
                typeof(IzzetControl),
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
        public void Deck05_indianpancake_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",4),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
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
        public void Deck08_TSPJendrek_SnowControl_SultaiSnow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",7),
                new PostCompanionChange(),
                ArchetypeColor.UBRG,
                typeof(SnowControl),
                typeof(SultaiSnow),
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
        public void Deck11_bcs8995_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",10),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_SchulzCubed_TakingTurns_FiresTurns_UR()
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
        public void Deck14_lovealienzzz_SnowControl_TemurSnow_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",13),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(TemurSnow),
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
        public void Deck19_ConnorM426_SnowControl_SnowReclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",18),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_headshotcatcher_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",19),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
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
        public void Deck22_GedionRavenor_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",21),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck23_Nyph_PrimevalTitan_AmuletTitan_UBRG()
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
        public void Deck25_dpeliser_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",24),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
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
        public void Deck27_SebastianStueckl_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-14",26),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
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
