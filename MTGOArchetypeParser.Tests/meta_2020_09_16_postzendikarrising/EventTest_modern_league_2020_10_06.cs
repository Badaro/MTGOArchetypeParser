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
#01 Ivc: Azorius Control (WU)
#02 RagingTiltMonster: Grixis Shadow (UBR)
#03 _Logic_: Rakdos Prowess (BR, Lurrus)
#04 gurig: Burn (WR)
#05 xElBonk: Humans (WUBRG)
#06 Luckyfinish: Rakdos Midrange (BR)
#07 REDBOX: Heliod Combo (WRG)
#08 Maniac3130: Jeskai Control (WUR)
#09 Buttai: Hammer Time (WR, Lurrus)
#10 katoriarch123: Bant Control (WUG)
#11 weishengzhishabi: Gruul Midrange (RG)
#12 benchsummer: UBRG Shadow (UBRG)
#13 Aphiladon: Hardened Scales (G)
#14 KoDiamonds: Abzan Midrange (WBG)
#15 FreakNightmare: Belcher (RG)
#16 SgtMcMuffins: Saheeli Combo (WUR)
#17 Eyedea90: Mill (UB)
#18 mashmalovsky: E Tron (C)
#19 SamuelGraebner: WURG Control (WURG)
#20 seasonofmists: Selenya Eldrazi Taxes (WG)
#21 MHayashi: Obosh Aggro (R, Obosh)
#22 Goerajaponica: Izzet Control (UR)
#23 hermanomlg: Bant Midrange (WUG)
#24 facematt: Gruul Midrange (RG, Obosh)
#25 Selami: Ad Nauseam (WUB)
#26 SawphtBoi: Orzhov Midrange (WB)
#27 Czechito: Selenya Blink (WG)
#28 petator: Jeskai Control (WUR)
#29 Skvoznyak: Ad Nauseam (WUB)
#30 Trailovsky: Grixis Control (UBR)
#31 Somefellow: Amulet Titan (UBRG)
#32 Tiemuuu: Izzet Control (UR)
#33 Akkomier: Hammer Time (WU, Lurrus)
#34 ejk: KGC Amulet Titan (URG)
#35 Antoine57437: Abzan Company (WUBRG)
#36 ContraEgo: Thopter Urza (UBR)
#37 Fosioe: Shadow Prowess (BR, Lurrus)
#38 MATTOMARINAIO: UBRG Control (UBRG)
#39 abisbocci: Grixis Shadow (UBR, Lurrus)
#40 DoctorQueller: Spirits (WUG)
#41 bawhsome: Dredge (UBRG)
#42 stefanocanclini: Reclaimer Titan (WRG)
#43 maear: Kiki Chord (WRG, Yorion)
#44 GodOfSlaughter: Bring To Niv (WUBRG, Yorion)
#45 Jenara19: Oops All Spells (WUBRG)
#46 Gods_Shadow: Mono White Taxes (W)
#47 1yo2yo: Omnath Saheeli (WURG)
#48 tuckbear: Sultai Midrange (UBG)
#49 Tarrasque1: Golgari Elves (BG)
#50 johnyvolta: Kiki Chord (WRG, Yorion)
#51 didoguidotti1: WURG Control (WURG)
#52 TubbyBatman: Spirits (WU)
#53 DragonFodder: Skelementals (BR)
#54 B1gDan: Shadow Prowess (BRG, Lurrus)
#55 Game_Night: Shadow Prowess (WBR, Lurrus)
#56 Iplantz: Heliod Combo (WG)
#57 hugofreitas1: Izzet Restore Balance (URG)
#58 termidor: Mono White Taxes (W)
#59 Ibaitor: Golgari Midrange (BG)
#60 zfgao66: KGC Tron (G)
#61 CrusherBotBG: Hammer Time (W, Lurrus)
#62 ice_nine_: Boros Land Destruction (WR)
#63 TscheggschDePoegg: Bant Blink (WUG)
#64 Trebz: Sultai Control (UBG)
#65 nahuel10: Izzet Prowess (UR)
#66 Motown123: Merfolk (UB)
#67 AFX: Bring To Niv (WUBRG, Jegantha)
#68 balltap: Jeskai Breach (WURG, Jegantha)
#69 N3to: Gifts Storm (UR)
#70 Jaschalomaeus: Mono Red Prowess (R)
#71 smarties24: Jund Midrange (BRG)
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
        public void Deck21_MHayashi_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-10-06",20),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
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
        public void Deck42_stefanocanclini_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",41),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
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
        public void Deck47_1yo2yo_OmnathSaheeli_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-06",46),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
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
        public void Deck62_icenine_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-06",61),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosLandDestruction),
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
