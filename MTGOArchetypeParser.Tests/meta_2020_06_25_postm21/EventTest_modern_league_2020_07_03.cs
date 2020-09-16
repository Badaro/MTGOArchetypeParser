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
#01 _Batutinha_: SultaiReclamation (UBG)
#02 mechint: DimirControl (UB)
#03 _Nevar_More: MonoRedProwess (R)
#04 Drakanar: Merfolk (UG)
#05 robedarcourt: OrzhovTaxes (WB)
#06 marcofabrizi: WUBGControl (WUBG)
#07 _titoWii_96: WURGControl (WURG, Yorion)
#08 Mr_Sheep: Burn (WR)
#09 Tarrasque1: Elementals (WUBRG)
#10 didoguidotti1: Scapeshift (URG, Yorion)
#11 daniventrue: GrixisShadow (UBR)
#12 MHayashi: MonoRedProwess (R, Jegantha)
#13 kogamo: SnoopGoblins (BR)
#14 ScreenwriterNY: AmuletTitan (WUBRG)
#15 Maratiam: ETron (C)
#16 mrounds1216: GolgariElves (BG)
#17 npercario: IzzetRestoreBalance (UR)
#18 Weasley: SultaiReclamation (UBG, Yorion)
#19 CHILLEDADED: TitanShift (RG)
#20 GR_DONKIN: AdNauseam (WUB)
#21 sicsmoo: GTron (G)
#22 Nilsfit: HeliodDevoted (WUG)
#23 hugofreitas1: GiftsStorm (UR)
#24 Wirmaleff: Mill (UBG)
#25 DoubleB_33: HeliodSisters (W)
#26 Blkspds: Neobrand (UG)
#27 L3D91: GruulMidrange (RG)
#28 saccij92: Humans (WUBRG)
#29 HNSDMPF: HardenedScales (G)
#30 thepensword: IzzetControl (UR)
#31 rojanosa: OrzhovTokens (WB)
#32 Jiggywiggy: KinnanUrza (URG, Yorion)
#33 aspiringspike: IzzetControl (UR)
#34 penips: MonoWhiteEldraziTaxes (W)
#35 Bruno_Mineiro: UBRGShadow (UBRG)
#36 122pablo: JeskaiAscendancy (WURG)
#37 B4nn3D22: SnoopGoblins (BR)
#38 Nagato_Boran: JundMidrange (BRG)
#39 Cherryxman: GrixisDelver (UBR)
#40 Morrys: SnoopGoblins (BR)
#41 Zxrogue: BorosTaxes (WR, Lurrus)
#42 Draken44: Uroza (UBG, Yorion)
#43 Wuhsa: BringToNiv (WUBRG, Yorion)
#44 RadioactiveTortoise: Dredge (BRG)
#45 lopi: HeliodCombo (WG)
#46 TubbyBatman: IzzetProwess (UR)
#47 TrueHero: TakingTurns (URG)
#48 MadMaxErnst: UBRGControl (UBRG)
#49 Trellon: UTron (U)
#50 Ryan_39: IzzetProwess (UR)
#51 Kurusu: KikiChord (WBRG, Yorion)
#52 Rosie54: SelenyaTaxes (WG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_league_2020_07_03 : EventTest
    {
        [Test]
        public void Deck01_Batutinha_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",0),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck02_mechint_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-03",1),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_NevarMore_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-03",2),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Drakanar_Merfolk_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",3),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck05_robedarcourt_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-03",4),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck06_marcofabrizi_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",5),
                new PostM21(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_titoWii96_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",6),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_MrSheep_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",7),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Tarrasque1_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",8),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck10_didoguidotti1_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",9),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_daniventrue_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",10),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck12_MHayashi_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-03",11),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_kogamo_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",12),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck14_ScreenwriterNY_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",13),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck15_Maratiam_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-03",14),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_mrounds1216_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",15),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck17_npercario_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",16),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck18_Weasley_SultaiReclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",17),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_CHILLEDADED_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",18),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck20_GRDONKIN_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-03",19),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck21_sicsmoo_GTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-03",20),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Nilsfit_HeliodDevoted_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",21),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck23_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",22),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Wirmaleff_Mill_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",23),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck25_DoubleB33_HeliodSisters_W()
        {
            Test(
                GetDeck("modern-league-2020-07-03",24),
                new PostM21(),
                ArchetypeColor.W,
                typeof(SoulSisters),
                typeof(HeliodSisters),
                null
            );
        }

        [Test]
        public void Deck26_Blkspds_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",25),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck27_L3D91_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",26),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_saccij92_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",27),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck29_HNSDMPF_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-07-03",28),
                new PostM21(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck30_thepensword_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",29),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_rojanosa_OrzhovTokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-03",30),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(Tokens),
                typeof(OrzhovTokens),
                null
            );
        }

        [Test]
        public void Deck32_Jiggywiggy_KinnanUrza_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",31),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck33_aspiringspike_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",32),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_penips_MonoWhiteEldraziTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-03",33),
                new PostM21(),
                ArchetypeColor.W,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck35_BrunoMineiro_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",34),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck36_122pablo_JeskaiAscendancy_WURG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",35),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                null
            );
        }

        [Test]
        public void Deck37_B4nn3D22_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",36),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck38_NagatoBoran_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",37),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Cherryxman_GrixisDelver_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",38),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(Delver),
                typeof(GrixisDelver),
                null
            );
        }

        [Test]
        public void Deck40_Morrys_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",39),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck41_Zxrogue_BorosTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-03",40),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck42_Draken44_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",41),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck43_Wuhsa_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",42),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck44_RadioactiveTortoise_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",43),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck45_lopi_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",44),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck46_TubbyBatman_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",45),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck47_TrueHero_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",46),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck48_MadMaxErnst_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",47),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-03",48),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Ryan39_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",49),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Kurusu_KikiChord_WBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",50),
                new PostM21(),
                ArchetypeColor.WBRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck52_Rosie54_SelenyaTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",51),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }


    }
}
