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
#01 tibalt_of_red_sub: Mill (UB, Lurrus)
#02 rurlref: AdNauseam (WUB)
#03 cntrlfreak: UBRGShadow (UBRG)
#04 Oscar_Franco: GrixisShadow (UBR)
#05 nick4567: SultaiControl (UBG)
#06 AsturianDreams: PrimevalTitan (WRG)
#07 WhiTe TsaR: Humans (WUBRG)
#08 JRDC14: RakdosMidrange (BR)
#09 zMunkeyXz: Mill (UBG)
#10 Teston: MarduProwess (WBR, Lurrus)
#11 bobthedog: BantBlink (WUG)
#12 SpiderSpace: ThaliaStompy (WR)
#13 fuma-mtgcampinas: ETron (C)
#14 PuntThenWhine: KGCAmuletTitan (WUBRG)
#15 fabee1: MonoWhiteEldraziTaxes (W)
#16 buddha715: Neobrand (UG)
#17 Trid0n: Bogles (WG, Lurrus)
#18 GideonRavensword: Dredge (BRG)
#19 genmatsu: Uroza (UG)
#20 dzedz_: Devoted (WG, Lurrus)
#21 akjets6: GrixisShadow (UBR, Lurrus)
#22 Zar0s: TemurControl (URG)
#23 Phill_Hellmuth: GruulMidrange (RG)
#24 Rulleboren: Belcher (C)
#25 otakkun: KGCTron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_09_18 : EventTest
    {
        [Test]
        public void Deck01_tibaltofredsub_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-18",0),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_rurlref_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-09-18",1),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck03_cntrlfreak_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-18",2),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck04_OscarFranco_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-18",3),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_nick4567_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-18",4),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_AsturianDreams_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-18",5),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck07_WhiTeTsaR_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-18",6),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck08_JRDC14_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-18",7),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-18",8),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Teston_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-18",9),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_bobthedog_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-18",10),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SpiderSpace_ThaliaStompy_WR()
        {
            Test(
                GetDeck("modern-league-2020-09-18",11),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(ThaliaStompy),
                null,
                null
            );
        }

        [Test]
        public void Deck13_fumamtgcampinas_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-09-18",12),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck14_PuntThenWhine_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-18",13),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck15_fabee1_MonoWhiteEldraziTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-09-18",14),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck16_buddha715_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-18",15),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Trid0n_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-18",16),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_GideonRavensword_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-18",17),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_genmatsu_Uroza_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-18",18),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck20_dzedz_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-18",19),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_akjets6_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-18",20),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_Zar0s_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-18",21),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_PhillHellmuth_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-18",22),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Rulleboren_Belcher_C()
        {
            Test(
                GetDeck("modern-league-2020-09-18",23),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck25_otakkun_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-09-18",24),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }


    }
}
