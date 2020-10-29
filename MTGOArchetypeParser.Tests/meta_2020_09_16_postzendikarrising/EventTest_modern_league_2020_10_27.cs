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
#01 JogandoPelado: BorosLandDestruction (WR)
#02 calexa: KGCTron (G)
#03 xame3: Burn (WR)
#04 pandanaconda: HardenedScales (BG, Lurrus)
#05 iuriper: OboshAggro (R, Obosh)
#06 yeaux: HeliodCombo (W)
#07 Moniz0801: AmuletTitan (WUBRG)
#08 Chrhey: IzzetProwess (UR)
#09 Reflax: AzoriusControl (WU)
#10 SpikeYou: UBRGControl (UBRG)
#11 CobaltOak: OrzhovMidrange (WB)
#12 MruLoNGx: JundMidrange (BRG)
#13 PietroSas: Devoted (WG, Lurrus)
#14 Piccio36: PrimevalTitan (BRG)
#15 haubidtran: KinnanLegends (WURG, Yorion)
#16 TheTunnelingCat: ETron (C)
#17 lucajak: IzzetControl (UR)
#18 CooperTheRed: Yawgmoth (BG)
#19 BSK_hercules: PrimevalTitan (WURG)
#20 Schiapponetor: HeliodCombo (WG)
#21 Nagato_Boran: OopsAllSpells (WUBRG)
#22 Amplumnox: ShadowProwess (BR, Lurrus)
#23 Stabbington: PrimevalTitan (WRG)
#24 meanfannypack: OrzhovEldraziTaxes (WB)
#25 yintao: IncineratorBurn (R)
#26 rofelos: WURGControl (WURG)
#27 PhantasmalBear: SultaiMidrange (UBG)
#28 oinkmage: Humans (WUBRG)
#29 iuriper: AdNauseam (WUB)
#30 CordoTwin: ShadowProwess (BRG, Lurrus)
#31 TheMason: GolgariMidrange (BG)
#32 LakadMatataaag: JeskaiControl (WUR)
#33 ShzockChan: Cycling (WR)
#34 Kurusu: KikiChord (WRG, Yorion)
#35 ElPuerco: GrixisShadow (UBR)
#36 Rakdos91: HardenedScales (G)
#37 POC: Infect (BG, Lurrus)
#38 spiritmonger17: GruulMidrange (RG)
#39 DoctorQueller: BantSpirits (WUG)
#40 stayrospet: SaheeliCombo (WURG, Jegantha)
#41 Somefellow: EsperControl (WUB)
#42 SvenSveeterSven: IzzetControl (UR)
#43 Ryan_39: Scapeshift (WURG)
#44 DemianDesposito10: BorosProwess (WR, Lurrus)
#45 Antoine57437: AbzanCompany (WBRG)
#46 krusader666: TitanShift (RG)
#47 TuggaNaxos: IzzetControl (UR)
#48 hugofreitas1: GiftsStorm (UR)
#49 FluffyWolf2: EsperReanimator (WUB)
#50 katoriarch123: BringToNiv (WUBRG, Jegantha)
#51 Theo_Jung: MonoWhiteTaxes (W)
#52 ADSkinner: Mill (UB)
#53 kensportsfan: MonoRedProwess (R)
#54 Ben_Illig: GruulMidrange (RG)
#55 MagicalHack99: BantControl (WUG, Yorion)
#56 win_and_in: HammerTime (W, Lurrus)
#57 Selfeisek: LivingEnd (BRG)
#58 Jetparrot: SnoopGoblins (BR)
#59 SpiderSpace: Inverter (UB)
#60 Luckyfinish: RakdosMidrange (BR)
#61 futureshok: Dredge (BRG)
#62 TscheggschDePoegg: BantBlink (WUG)
#63 mikro22: Mill (UB)
#64 FeeltheRush: BantMidrange (WUG)
#65 Megalov: TitanStompy (BRG, Gyruda)
#66 Tarrasque1: Elementals (WUBRG)
#67 ManPants: JundMidrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_10_27 : EventTest
    {
        [Test]
        public void Deck01_JogandoPelado_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-27",0),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosLandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck02_calexa_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-10-27",1),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck03_xame3_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-27",2),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck04_pandanaconda_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-27",3),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_iuriper_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-10-27",4),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_yeaux_HeliodCombo_W()
        {
            Test(
                GetDeck("modern-league-2020-10-27",5),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Moniz0801_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",6),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_Chrhey_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-27",7),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Reflax_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-27",8),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_SpikeYou_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",9),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_CobaltOak_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-10-27",10),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_MruLoNGx_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",11),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_PietroSas_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-27",12),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Piccio36_PrimevalTitan_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",13),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck15_haubidtran_KinnanLegends_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-27",14),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(KinnanLegends),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_TheTunnelingCat_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-10-27",15),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_lucajak_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-27",16),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_CooperTheRed_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",17),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck19_BSKhercules_PrimevalTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",18),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck20_Schiapponetor_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",19),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck21_NagatoBoran_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",20),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Amplumnox_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-27",21),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_Stabbington_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",22),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck24_meanfannypack_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-10-27",23),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck25_yintao_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-10-27",24),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck26_rofelos_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",25),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_PhantasmalBear_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",26),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_oinkmage_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",27),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck29_iuriper_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-10-27",28),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck30_CordoTwin_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-27",29),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_TheMason_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",30),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_LakadMatataaag_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-27",31),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_ShzockChan_Cycling_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-27",32),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Cycling),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-27",33),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck35_ElPuerco_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-27",34),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck36_Rakdos91_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-10-27",35),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck37_POC_Infect_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-27",36),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck38_spiritmonger17_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",37),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck39_DoctorQueller_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",38),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck40_stayrospet_SaheeliCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-27",39),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck41_Somefellow_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-league-2020-10-27",40),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck42_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-27",41),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Ryan39_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",42),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck44_DemianDesposito10_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-27",43),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck45_Antoine57437_AbzanCompany_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",44),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(AbzanCompany),
                null,
                null
            );
        }

        [Test]
        public void Deck46_krusader666_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",45),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck47_TuggaNaxos_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-27",46),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck48_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-27",47),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck49_FluffyWolf2_EsperReanimator_WUB()
        {
            Test(
                GetDeck("modern-league-2020-10-27",48),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(EsperReanimator),
                null,
                null
            );
        }

        [Test]
        public void Deck50_katoriarch123_BringToNiv_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-27",49),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck51_TheoJung_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-10-27",50),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck52_ADSkinner_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-27",51),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck53_kensportsfan_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-10-27",52),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck54_BenIllig_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",53),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck55_MagicalHack99_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-27",54),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck56_winandin_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-27",55),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck57_Selfeisek_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",56),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck58_Jetparrot_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-27",57),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck59_SpiderSpace_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-27",58),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck60_Luckyfinish_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-27",59),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck61_futureshok_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",60),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck62_TscheggschDePoegg_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",61),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck63_mikro22_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-27",62),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck64_FeeltheRush_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",63),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck65_Megalov_TitanStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-10-27",64),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(TitanStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck66_Tarrasque1_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",65),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck67_ManPants_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-27",66),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
