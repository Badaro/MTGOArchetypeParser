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
#01 hugofreitas1: Gifts Storm (UR)
#02 w0llsm0th: Serum Powder Eldrazi (C)
#03 visitor636: Esper Taxes (WUB)
#04 Kairos92: Red Prison (R)
#05 Lavaridge: Temur Control (URG)
#06 DoctorQueller: Spirits (WUG)
#07 fabee1: Saheeli Combo (WUR)
#08 calmdownbronco: Heliod Combo (WG)
#09 MagicDevil666: U Tron (UB)
#10 SYMO991: Shadow Prowess (BRG, Lurrus)
#11 touto_Isle: Dredge (BRG)
#12 Magic_Dan: Rakdos Prowess (BR, Lurrus)
#13 apriolo1: Amulet Titan (WURG)
#14 coffee_tomato: Boros Taxes (WR)
#15 oskiyaa: Scapeshift (URG)
#16 GGBud1717: Obosh Aggro (R, Obosh)
#17 Bruno_Mineiro: Jund Midrange (BRG)
#18 Xenowan: Yawgmoth (BG)
#19 eclipse4343: Azorius Control (WU)
#20 Skrug092: Izzet Prowess (UR)
#21 twinlesstwin: Izzet Control (UR)
#22 AMetnik: Jeskai Control (WUR)
#23 _Stream: Naya Prowess (WRG, Lurrus)
#24 Parrit: Orzhov Taxes (WB)
#25 Happyflower: U Tron (UR)
#26 fl0urish: Shadow Prowess (WBR, Lurrus)
#27 MiguelCaster: Mono White Taxes (W, Yorion)
#28 billster47: Hammer Time (W, Lurrus)
#29 oosunq: Omnath Saheeli (WURG, Jegantha)
#30 Ryuuji89: Gruul Midrange (RG)
#31 tcgshin: Titan Shift (RG)
#32 Ely_Silva: Burn (WRG)
#33 utilitybelt: Reclaimer Titan (WRG)
#34 Parrit: Mono White Taxes (W)
#35 russell_wilson: Humans (WUBRG)
#36 Wuhsa: Niv To Light (WUBRG, Yorion)
#37 RespectTheCat: Azorius Taxes (WU, Yorion)
#38 reswax: WURG Control (WURG)
#39 christiano7: Orzhov Midrange (WB)
#40 panbeier: Golgari Midrange (BG)
#41 ArcanisRestored: Bogles (WG)
#42 603Leb: Elves (G)
#43 Krully: Ad Nauseam (WUB)
#44 MrSeri: Hardened Scales (RG)
#45 ZYX_Jerry: Selective Oracle (WU)
#46 wang: Bant Midrange (WUG)
#47 NorthLagos: Ad Nauseam (WUB)
#48 keyan926: Izzet Control (UR)
#49 ragingpikey: Spirits (WU)
#50 George_Clooners: Dice Factory Tron (C)
#51 Acores88: Shadow Prowess (BR, Lurrus)
#52 ander_lizarrakoa: Oops All Spells (WUBRG)
#53 Aigis: Oops All Spells (BRG)
#54 rameison: Izzet Restore Balance (URG)
#55 Cabrita: E Tron (C)
#56 Captainschwiggles: Azorius Control (WU)
#57 pegleg: UBRG Control (UBRG, Yorion)
#58 The_GingerBrute: Hammer Time (WR, Lurrus)
#59 SoulStrong: Dimir Control (UB)
#60 TheRaf: KGC Tron (G)
#61 coert: Heliod Combo (WG, Yorion)
#62 SpiderSpace: Mono White Taxes (W, Yorion)
#63 Moniz0801: Amulet Titan (URG)
#64 Borjillamtg10: Rakdos Midrange (BR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_11_17 : EventTest
    {
        [Test]
        public void Deck01_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-17",0),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck02_w0llsm0th_SerumPowderEldrazi_C()
        {
            Test(
                GetDeck("modern-league-2020-11-17",1),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(SerumPowderEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck03_visitor636_EsperTaxes_WUB()
        {
            Test(
                GetDeck("modern-league-2020-11-17",2),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Kairos92_RedPrison_R()
        {
            Test(
                GetDeck("modern-league-2020-11-17",3),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Lavaridge_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",4),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_DoctorQueller_Spirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",5),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck07_fabee1_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-league-2020-11-17",6),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_calmdownbronco_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck09_MagicDevil666_UTron_UB()
        {
            Test(
                GetDeck("modern-league-2020-11-17",8),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_SYMO991_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-17",9),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_toutoIsle_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",10),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_MagicDan_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-17",11),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_apriolo1_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",12),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck14_coffeetomato_BorosTaxes_WR()
        {
            Test(
                GetDeck("modern-league-2020-11-17",13),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck15_oskiyaa_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",14),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck16_GGBud1717_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-11-17",15),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck17_BrunoMineiro_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",16),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Xenowan_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",17),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck19_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-17",18),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Skrug092_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-17",19),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck21_twinlesstwin_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-17",20),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_AMetnik_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-11-17",21),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Stream_NayaProwess_WRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-17",22),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_Parrit_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-11-17",23),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Happyflower_UTron_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-17",24),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck26_fl0urish_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-17",25),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_MiguelCaster_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-17",26),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_billster47_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-17",27),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_oosunq_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-11-17",28),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck30_Ryuuji89_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",29),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_tcgshin_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",30),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck32_ElySilva_Burn_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",31),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck33_utilitybelt_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",32),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck34_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-11-17",33),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck35_russellwilson_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",34),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck36_Wuhsa_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-17",35),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_RespectTheCat_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-17",36),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck38_reswax_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",37),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck39_christiano7_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-11-17",38),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck40_panbeier_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",39),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck41_ArcanisRestored_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",40),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck42_603Leb_Elves_G()
        {
            Test(
                GetDeck("modern-league-2020-11-17",41),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Elves),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Krully_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-11-17",42),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck44_MrSeri_HardenedScales_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",43),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck45_ZYXJerry_SelectiveOracle_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-17",44),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(SelectiveOracle),
                null,
                null
            );
        }

        [Test]
        public void Deck46_wang_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",45),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_NorthLagos_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-11-17",46),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck48_keyan926_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-17",47),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_ragingpikey_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-17",48),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck50_GeorgeClooners_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-league-2020-11-17",49),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(DiceFactoryTron),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Acores88_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-17",50),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck52_anderlizarrakoa_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",51),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Aigis_OopsAllSpells_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",52),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck54_rameison_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",53),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck55_Cabrita_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-11-17",54),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Captainschwiggles_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-17",55),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck57_pegleg_UBRGControl_UBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-17",56),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck58_TheGingerBrute_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-17",57),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck59_SoulStrong_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-11-17",58),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck60_TheRaf_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-11-17",59),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck61_coert_HeliodCombo_WG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-17",60),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck62_SpiderSpace_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-17",61),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck63_Moniz0801_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-17",62),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck64_Borjillamtg10_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-17",63),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
