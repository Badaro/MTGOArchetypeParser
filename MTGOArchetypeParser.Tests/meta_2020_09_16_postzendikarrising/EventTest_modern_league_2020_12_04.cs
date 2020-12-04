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
#01 TimbersFC: Yawgmoth (BG)
#02 buddha715: Belcher (WRG)
#03 Kurusu: Kiki Chord (WRG, Yorion)
#04 alantur94: Oops All Spells (WUBRG)
#05 MrRaeb: UBRG Control (UBRG)
#06 Denmark_Dan: Titan Shift (RG)
#07 Patxi: Erayo Prison (WUB)
#08 EnricoPalazzo: Faeries (UB)
#09 misteriganya: E Tron (C)
#10 ryurgin: KGC Tron (G)
#11 tanisong1221: Azorius Control (WU, Yorion)
#12 RespectTheCat: Rakdos Midrange (BR)
#13 shown117: WURG Control (WURG)
#14 Trellon: U Tron (UR)
#15 LewisCBR: Scapeshift (URG)
#16 twinlesstwin: Izzet Control (UR)
#17 Chuki322: Saheeli Combo (WUR)
#18 Musagete: Heliod Combo (WG)
#19 FluffyWolf2: Red Prison (R)
#20 penips: Mono White Taxes (W)
#21 Rebus8: Orzhov Taxes (WB)
#22 SoulStrong: Bant Blink (WUG)
#23 silencsong: Izzet Restore Balance (URG)
#24 Smdster: Heliod Combo (WR)
#25 Kzrds: Obosh Aggro (R, Obosh)
#26 zman2340: Snoop Goblins (BR)
#27 Athanasios0708: Jund Midrange (BRG)
#28 MagicalHack99: Sultai Control (UBG)
#29 Foam: Amulet Titan (UBRG)
#30 BigTomTom79: Bogles (WG, Lurrus)
#31 6argamel: Boros Taxes (WR, Yorion)
#32 GoblinK1ng: Goblins (BRG)
#33 MastaHorus: Izzet Living End (UR)
#34 Vailo92: Izzet Control (UR)
#35 marcofabrizi: Bant Midrange (WUG)
#36 603Leb: Winota (WR, Yorion)
#37 DoctorQueller: Bant Spirits (WUG)
#38 TheWolves: Izzet Prowess (UR)
#39 ZYX_Jerry: Belcher (URG)
#40 Maffblue1: Humans (WUBRG)
#41 Amplumnox: Hammer Time (W, Lurrus)
#42 Serguei: Mill (UB, Lurrus)
#43 MrSeri: Hardened Scales (G)
#44 mariogomes097: Devoted (WG, Lurrus)
#45 hermanomlg: Ad Nauseam (WUB)
#46 jaximus5: Burn (WRG)
#47 Amplumnox: Hammer Time (W, Lurrus)
#48 Gigy: Gruul Midrange (RG)
#49 iL_Tedesco: Shadow Prowess (UBRG, Lurrus)
#50 bant_is_love: Reclaimer Titan (WRG)
#51 TBxGreenguy: Neobrand (UG)
#52 moralmar: Gifts Storm (UR)
#53 kanister: Dimir Control (UB)
#54 Gautcho: Shadow Prowess (BR, Lurrus)
#55 greatnate: Jeskai Control (WUR)
#56 Laplasjan: Hammer Time (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_12_04 : EventTest
    {
        [Test]
        public void Deck01_TimbersFC_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",0),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck02_buddha715_Belcher_WRG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",1),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-04",2),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_alantur94_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck05_MrRaeb_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",4),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_DenmarkDan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",5),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck07_Patxi_ErayoPrison_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-04",6),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(ErayoPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck08_EnricoPalazzo_Faeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-12-04",7),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Faeries),
                null,
                null
            );
        }

        [Test]
        public void Deck09_misteriganya_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-12-04",8),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_ryurgin_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-12-04",9),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck11_tanisong1221_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-04",10),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_RespectTheCat_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-04",11),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_shown117_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",12),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Trellon_UTron_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-04",13),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_LewisCBR_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",14),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck16_twinlesstwin_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-04",15),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Chuki322_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-04",16),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Musagete_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",17),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck19_FluffyWolf2_RedPrison_R()
        {
            Test(
                GetDeck("modern-league-2020-12-04",18),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck20_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-12-04",19),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Rebus8_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-12-04",20),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck22_SoulStrong_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",21),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck23_silencsong_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",22),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck24_Smdster_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-04",23),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Kzrds_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-12-04",24),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck26_zman2340_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-04",25),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck27_Athanasios0708_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",26),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_MagicalHack99_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",27),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Foam_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",28),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck30_BigTomTom79_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-04",29),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_6argamel_BorosTaxes_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-04",30),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_GoblinK1ng_Goblins_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",31),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck33_MastaHorus_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-04",32),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetLivingEnd),
                null
            );
        }

        [Test]
        public void Deck34_Vailo92_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-04",33),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_marcofabrizi_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",34),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck36_603Leb_Winota_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-04",35),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Winota),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_DoctorQueller_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",36),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck38_TheWolves_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-04",37),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck39_ZYXJerry_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",38),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Maffblue1_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",39),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Amplumnox_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-04",40),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck42_Serguei_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-04",41),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck43_MrSeri_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-12-04",42),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck44_mariogomes097_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-04",43),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck45_hermanomlg_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-04",44),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck46_jaximus5_Burn_WRG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",45),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Amplumnox_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-04",46),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck48_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",47),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck49_iLTedesco_ShadowProwess_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-04",48),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck50_bantislove_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",49),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck51_TBxGreenguy_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-04",50),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck52_moralmar_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-04",51),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck53_kanister_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-12-04",52),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck54_Gautcho_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-04",53),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck55_greatnate_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-04",54),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Laplasjan_HammerTime_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-04",55),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
