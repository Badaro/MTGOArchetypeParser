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
#01 Yumas2: Ad Nauseam (WUB)
#02 dunkin90: KGC Tron (G)
#03 Antus94: Shadow Prowess (BRG, Lurrus)
#04 ZYX_Jerry: Belcher (URG)
#05 ModoGrinder: Jund Midrange (BRG)
#06 Wuhsa: Niv To Light (WUBRG, Yorion)
#07 DoctorQueller: Spirits (WU)
#08 603Leb: Winota (WR, Yorion)
#09 JUJUBEAN__2004: Heliod Combo (WG)
#10 crazybaloth: Snoop Goblins (BR)
#11 MadMaxErnst: UBRG Control (UBRG)
#12 Usama96: Temur Control (URG)
#13 DukeVitro: Sultai Shadow (UBG)
#14 ContraEgo: Thopter Urza (WUBR)
#15 ColdPier: Hardened Scales (G)
#16 Chichichi: Obosh Aggro (R, Obosh)
#17 Hybrid7: Izzet Prowess (UR)
#18 Moniz0801: Reclaimer Titan (WG)
#19 mariogomes097: Hammer Time (W, Lurrus)
#20 AnneLivleysD3ath: Amulet Titan (G)
#21 murilobds: Burn (WR)
#22 Takizawa: Yawgmoth (BG)
#23 Reynad: Hammer Time (WR, Lurrus)
#24 Alvas: Sultai Control (UBG)
#25 Lock_WI: Mono White Taxes (W)
#26 toondoslav: Oops All Spells (WUBG)
#27 Trailovsky: Temur Midrange (URG)
#28 tcgshin: Titan Shift (RG)
#29 CReactor: Shadow Prowess (BR, Lurrus)
#30 v3sp_tv: Elementals (WUBRG)
#31 Rebus8: Orzhov Taxes (WB)
#32 -Antti-: Devoted (WBG, Lurrus)
#33 visitor636: Smallpox (WBR)
#34 pedrogush: Hammer Time (W, Lurrus)
#35 Stefywefy215: Bant Midrange (WUG)
#36 pan_sarin: Bant Blink (WUG)
#37 Hyperdontia: Mardu Midrange (WBR)
#38 exodusMTG: Gifts Storm (UR)
#39 MartinezDP: Omnath Saheeli (WURG, Yorion)
#40 TubbyBatman: Temur Prowess (URG)
#41 aytor_92: Erayo Prison (WUB)
#42 Ramelao: Bogles (WG, Lurrus)
#43 Goose70: Grixis Shadow (UBR)
#44 Savok: U Tron (U)
#45 122pablo: Jeskai Ascendancy (WURG)
#46 mechint: Hammer Time (WG, Lurrus)
#47 RRozanski: Rogues (UB, Lurrus)
#48 weishengzhishabi: Sultai Control (UBG)
#49 katoriarch123: WURG Control (WURG)
#50 Gigy: Gruul Midrange (RG)
#51 npizzolato: Jeskai Control (WUR)
#52 Ivan1227: Azorius Control (WU)
#53 TERROl2: Izzet Restore Balance (UR)
#54 DemianDesposito10: Burn (WR, Lurrus)
#55 Smdster: Heliod Combo (WR)
#56 Mateusf34: E Tron (C)
#57 tortillathehun: Rakdos Midrange (BR)
#58 Reflax: Scapeshift (URG)
#59 Vertyx_: Rakdos Midrange (BR)
#60 daviusminimus: Enigmatic Incarnation (WUBRG, Yorion)
#61 StreexIT: Izzet Control (UR)
#62 toya: Rakdos Midrange (BR, Lurrus)
#63 __Ghost__: Azorius Control (WU)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_12_01 : EventTest
    {
        [Test]
        public void Deck01_Yumas2_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-01",0),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck02_dunkin90_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-12-01",1),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck03_Antus94_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-01",2),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_ZYXJerry_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",3),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ModoGrinder_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",4),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Wuhsa_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-01",5),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-01",6),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck08_603Leb_Winota_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-01",7),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Winota),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_JUJUBEAN2004_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck10_crazybaloth_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",9),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck11_MadMaxErnst_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",10),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Usama96_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",11),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_DukeVitro_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",12),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck14_ContraEgo_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",13),
                new PostZendikarRising(),
                ArchetypeColor.WUBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck15_ColdPier_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-12-01",14),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Chichichi_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-12-01",15),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck17_Hybrid7_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",16),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Moniz0801_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",17),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck19_mariogomes097_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-01",18),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_AnneLivleysD3ath_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-league-2020-12-01",19),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck21_murilobds_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",20),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Takizawa_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",21),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Reynad_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-01",22),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_Alvas_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",23),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_LockWI_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-12-01",24),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck26_toondoslav_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",25),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Trailovsky_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",26),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_tcgshin_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",27),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck29_CReactor_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-01",28),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_v3sptv_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",29),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Rebus8_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-12-01",30),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Antti_Devoted_WBG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-01",31),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck33_visitor636_Smallpox_WBR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",32),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck34_pedrogush_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-01",33),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck35_Stefywefy215_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",34),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck36_pansarin_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",35),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Hyperdontia_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",36),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck38_exodusMTG_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",37),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck39_MartinezDP_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-01",38),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck40_TubbyBatman_TemurProwess_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",39),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck41_aytor92_ErayoPrison_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-01",40),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(ErayoPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Ramelao_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-01",41),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck43_Goose70_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",42),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Savok_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-12-01",43),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck45_122pablo_JeskaiAscendancy_WURG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",44),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                null
            );
        }

        [Test]
        public void Deck46_mechint_HammerTime_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-01",45),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck47_RRozanski_Rogues_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-01",46),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Rogues),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck48_weishengzhishabi_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",47),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_katoriarch123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",48),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",49),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck51_npizzolato_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",50),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Ivan1227_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-01",51),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck53_TERROl2_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",52),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck54_DemianDesposito10_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-01",53),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck55_Smdster_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",54),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-12-01",55),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck57_tortillathehun_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",56),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck58_Reflax_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-01",57),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck59_Vertyx_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",58),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck60_daviusminimus_EnigmaticIncarnation_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-01",59),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(EnigmaticIncarnation),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck61_StreexIT_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-01",60),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck62_toya_RakdosMidrange_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-01",61),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck63_Ghost_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-01",62),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
