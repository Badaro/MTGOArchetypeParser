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
#01 psych4tog: Elementals (WUBRG)
#02 tcgshin: TitanShift (RG)
#03 PanCement_JP: BantSpirits (WUG)
#04 saccij92: Humans (WUBRG)
#05 yPrincipe: BringToNiv (WUBRG, Yorion)
#06 ArchaeusDota: KGCTron (G)
#07 Big_And_Easy: MonoRedProwess (R)
#08 Rossello: IncineratorBurn (WR)
#09 meanfannypack: OrzhovShadow (WB)
#10 Doni_Dominaria: RakdosProwess (BR, Lurrus)
#11 AndersPovirk: Dredge (BRG)
#12 Polikasoll: IncineratorBurn (R)
#13 Parrit: HardenedScales (G)
#14 kogamo: ETron (C)
#15 Phyziks42: NayaMidrange (WRG)
#16 musasabi: SnoopGoblins (BR)
#17 Silence9428: Infect (UG)
#18 Do0mSwitch: SultaiControl (UBG)
#19 mauricio998: Mill (UB)
#20 _Shatun_: GruulMidrange (RG)
#21 Panic_Daddy: AdNauseam (WUB)
#22 MrRaeb: Uroza (UBG, Yorion)
#23 Pendragon15038: Merfolk (U)
#24 babamm: IzzetRestoreBalance (URG)
#25 Hiro_Hsiang: IzzetProwess (UR)
#26 Curveiganhei: MonoRedProwess (R, Jegantha)
#27 KieranT: JundMidrange (BRG)
#28 yPrincipe: BantControl (WUG, Yorion)
#29 SvenSveeterSven: IzzetControl (UR)
#30 wefald: Inverter (UB)
#31 scvslayer: Scapeshift (URG, Yorion)
#32 MartinezDP: BantBlink (WUG, Yorion)
#33 maear: IzzetControl (UR)
#34 Loreington: GiftsStorm (UR)
#35 Evaros: MonoWhiteTaxes (W)
#36 yumad3988: HollowOne (BR)
#37 gobboboy: OrzhovEldraziTaxes (WB)
#38 osmanozguney: DimirControl (UB)
#39 AnneLivleysD3ath: KGCAmuletTitan (WUBRG)
#40 SiDa1991: UTron (U)
#41 Dylan_MTG: Neobrand (UG)
#42 BossBr: AzoriusTaxes (WU)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_league_2020_07_10 : EventTest
    {
        [Test]
        public void Deck01_psych4tog_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",0),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck02_tcgshin_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",1),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck03_PanCementJP_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",2),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck04_saccij92_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",3),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_yPrincipe_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-10",4),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_ArchaeusDota_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-10",5),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck07_BigAndEasy_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-10",6),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Rossello_IncineratorBurn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",7),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck09_meanfannypack_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-10",8),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck10_DoniDominaria_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-10",9),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_AndersPovirk_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",10),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Polikasoll_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-07-10",11),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck13_Parrit_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-07-10",12),
                new PostM21(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck14_kogamo_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-10",13),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Phyziks42_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",14),
                new PostM21(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_musasabi_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",15),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck17_Silence9428_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",16),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Do0mSwitch_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",17),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_mauricio998_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-10",18),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",19),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_PanicDaddy_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-10",20),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck22_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-10",21),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_Pendragon15038_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-07-10",22),
                new PostM21(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck24_babamm_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",23),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck25_HiroHsiang_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",24),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Curveiganhei_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-10",25),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck27_KieranT_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",26),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_yPrincipe_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-10",27),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",28),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_wefald_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-10",29),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck31_scvslayer_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-10",30),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_MartinezDP_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-10",31),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck33_maear_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",32),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Loreington_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",33),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Evaros_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-10",34),
                new PostM21(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck36_yumad3988_HollowOne_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-10",35),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(HollowOne),
                null,
                null
            );
        }

        [Test]
        public void Deck37_gobboboy_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-10",36),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck38_osmanozguney_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-10",37),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck39_AnneLivleysD3ath_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",38),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck40_SiDa1991_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-10",39),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck41_DylanMTG_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-10",40),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck42_BossBr_AzoriusTaxes_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-10",41),
                new PostM21(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                null
            );
        }


    }
}
