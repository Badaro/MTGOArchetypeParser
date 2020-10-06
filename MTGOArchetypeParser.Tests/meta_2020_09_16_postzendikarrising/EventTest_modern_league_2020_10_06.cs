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
#01 Ivc: AzoriusControl (WU)
#02 RagingTiltMonster: GrixisShadow (UBR)
#03 _Logic_: RakdosProwess (BR, Lurrus)
#04 gurig: Burn (WR)
#05 xElBonk: Humans (WUBRG)
#06 Luckyfinish: RakdosMidrange (BR)
#07 REDBOX: HeliodCombo (WRG)
#08 Maniac3130: JeskaiControl (WUR)
#09 Buttai: HammerTime (WR, Lurrus)
#10 katoriarch123: BantControl (WUG)
#11 weishengzhishabi: GruulMidrange (RG)
#12 benchsummer: UBRGShadow (UBRG)
#13 Aphiladon: HardenedScales (G)
#14 KoDiamonds: AbzanMidrange (WBG)
#15 FreakNightmare: Belcher (RG)
#16 SgtMcMuffins: SaheeliCombo (WUR)
#17 Eyedea90: Mill (UB)
#18 mashmalovsky: ETron (C)
#19 SamuelGraebner: WURGControl (WURG)
#20 seasonofmists: SelenyaEldraziTaxes (WG)
#21 MHayashi: MonoRedProwess (R, Obosh)
#22 Goerajaponica: IzzetControl (UR)
#23 hermanomlg: BantMidrange (WUG)
#24 facematt: GruulMidrange (RG, Obosh)
#25 Selami: AdNauseam (WUB)
#26 SawphtBoi: OrzhovMidrange (WB)
#27 Czechito: SelenyaBlink (WG)
#28 petator: JeskaiControl (WUR)
#29 Skvoznyak: AdNauseam (WUB)
#30 Trailovsky: GrixisControl (UBR)
#31 Somefellow: AmuletTitan (UBRG)
#32 Tiemuuu: IzzetControl (UR)
#33 Akkomier: HammerTime (WU, Lurrus)
#34 ejk: KGCAmuletTitan (URG)
#35 Antoine57437: AbzanCompany (WUBRG)
#36 ContraEgo: ThopterUrza (UBR)
#37 Fosioe: ShadowProwess (BR, Lurrus)
#38 MATTOMARINAIO: UBRGControl (UBRG)
#39 abisbocci: GrixisShadow (UBR, Lurrus)
#40 DoctorQueller: Spirits (WUG)
#41 bawhsome: Dredge (UBRG)
#42 stefanocanclini: PrimevalTitan (WRG)
#43 maear: KikiChord (WRG, Yorion)
#44 GodOfSlaughter: BringToNiv (WUBRG, Yorion)
#45 Jenara19: OopsAllSpells (WUBRG)
#46 Gods_Shadow: MonoWhiteTaxes (W)
#47 1yo2yo: SaheeliCombo (WURG)
#48 tuckbear: SultaiMidrange (UBG)
#49 Tarrasque1: GolgariElves (BG)
#50 johnyvolta: KikiChord (WRG, Yorion)
#51 didoguidotti1: WURGControl (WURG)
#52 TubbyBatman: Spirits (WU)
#53 DragonFodder: Skelementals (BR)
#54 B1gDan: ShadowProwess (BRG, Lurrus)
#55 Game_Night: ShadowProwess (WBR, Lurrus)
#56 Iplantz: HeliodCombo (WG)
#57 hugofreitas1: IzzetRestoreBalance (URG)
#58 termidor: MonoWhiteTaxes (W)
#59 Ibaitor: GolgariMidrange (BG)
#60 zfgao66: KGCTron (G)
#61 CrusherBotBG: HammerTime (W, Lurrus)
#62 ice_nine_: BorosPrison (WR)
#63 TscheggschDePoegg: BantBlink (WUG)
#64 Trebz: SultaiControl (UBG)
#65 nahuel10: IzzetProwess (UR)
#66 Motown123: Merfolk (UB)
#67 AFX: BringToNiv (WUBRG, Jegantha)
#68 balltap: JeskaiBreach (WURG, Jegantha)
#69 N3to: GiftsStorm (UR)
#70 Jaschalomaeus: MonoRedProwess (R)
#71 smarties24: JundMidrange (BRG)
#72 matiaskm: Devoted (WG, Lurrus)
#73 XxquestionablyawesomexX: Bogles (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_10_06 : EventTest
    {
        [Test]
        public void Deck01_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-06",0),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_RagingTiltMonster_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",1),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Logic_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-06",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_gurig_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",3),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck05_xElBonk_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",4),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Luckyfinish_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_REDBOX_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",6),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Maniac3130_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",7),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Buttai_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-06",8),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",9),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_weishengzhishabi_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",10),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",11),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Aphiladon_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-10-06",12),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck14_KoDiamonds_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",13),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_FreakNightmare_Belcher_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",14),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck16_SgtMcMuffins_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",15),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Eyedea90_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-06",16),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck18_mashmalovsky_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-10-06",17),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck19_SamuelGraebner_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",18),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_seasonofmists_SelenyaEldraziTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",19),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck21_MHayashi_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-10-06",20),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck22_Goerajaponica_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",21),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_hermanomlg_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",22),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_facematt_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-10-06",23),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck25_Selami_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-10-06",24),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck26_SawphtBoi_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-10-06",25),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Czechito_SelenyaBlink_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",26),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck28_petator_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",27),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Skvoznyak_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-10-06",28),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Trailovsky_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",29),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Somefellow_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",30),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck32_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",31),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Akkomier_HammerTime_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-06",32),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck34_ejk_KGCAmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",33),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck35_Antoine57437_AbzanCompany_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",34),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(AbzanCompany),
                null,
                null
            );
        }

        [Test]
        public void Deck36_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",35),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Fosioe_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-06",36),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck38_MATTOMARINAIO_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",37),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck39_abisbocci_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-06",38),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck40_DoctorQueller_Spirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",39),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck41_bawhsome_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",40),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck42_stefanocanclini_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",41),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck43_maear_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-06",42),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck44_GodOfSlaughter_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-06",43),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck45_Jenara19_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",44),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck46_GodsShadow_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-10-06",45),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck47_1yo2yo_SaheeliCombo_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",46),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck48_tuckbear_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",47),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Tarrasque1_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",48),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck50_johnyvolta_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-06",49),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck51_didoguidotti1_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",50),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_TubbyBatman_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-06",51),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck53_DragonFodder_Skelementals_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",52),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Skelementals),
                null,
                null
            );
        }

        [Test]
        public void Deck54_B1gDan_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-06",53),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck55_GameNight_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-06",54),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck56_Iplantz_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",55),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck57_hugofreitas1_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",56),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck58_termidor_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-10-06",57),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck59_Ibaitor_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",58),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck60_zfgao66_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-10-06",59),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck61_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-06",60),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck62_icenine_BorosPrison_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",61),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck63_TscheggschDePoegg_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",62),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck64_Trebz_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",63),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck65_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",64),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck66_Motown123_Merfolk_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-06",65),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck67_AFX_BringToNiv_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-06",66),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck68_balltap_JeskaiBreach_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-06",67),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck69_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",68),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck70_Jaschalomaeus_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-10-06",69),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck71_smarties24_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",70),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck72_matiaskm_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-06",71),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck73_XxquestionablyawesomexX_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-06",72),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}