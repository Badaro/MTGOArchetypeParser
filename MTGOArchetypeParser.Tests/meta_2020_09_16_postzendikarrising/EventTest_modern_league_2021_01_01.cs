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
#01 Kurusu: Kiki Chord (WURG, Yorion)
#02 Boldy44: Burn (RG)
#03 jay44bab: Obosh Aggro (R, Obosh)
#04 Dawnpiper: Burn (WR)
#05 Sundayss: Azorius Control (WU)
#06 NightKnight131: Heliod Combo (WG)
#07 marcofabrizi: Shadow Prowess (BR, Lurrus)
#08 Busterbrown52: Humans (WUBRG)
#09 GHash77: WURG Midrange (WURG, Jegantha)
#10 Harry13: Sultai Control (UBG)
#11 Voltzwagon: Gruul Midrange (RG)
#12 pokerswizard: Spirits (WU)
#13 IanHoff: Bant Midrange (WUG)
#14 Robsan: Yawgmoth (BG)
#15 B1gDan: Golgari Midrange (BG)
#16 kaikalbuquerque: Bogles (WUG)
#17 hoveydw: Grixis Shadow (UBR, Lurrus)
#18 603Leb: Temur Midrange (URG)
#19 SpiderSpace: Belcher (URG)
#20 oskiyaa: Izzet Prowess (UR)
#21 Teston: Gifts Storm (UR)
#22 daibloXSC: Grixis Midrange (UBR)
#23 Hampuse1: Dice Factory Tron (C)
#24 Curveiganhei: Hammer Time (WG)
#25 NHA37: Heliod Combo (WR)
#26 HummingBard: Primeval Titan (UG)
#27 Rebus8: Orzhov Taxes (WB)
#28 Owl1013: Thopter Urza (WUB)
#29 MastaHorus: Izzet Living End (UR)
#30 Shadowz2005: Simic Control (UG)
#31 chachibuoh: Jund Midrange (BRG)
#32 adorno666: Thopter Urza (UBR)
#33 yneves: Taking Turns (URG)
#34 bigjc00: Amulet Titan (G)
#35 tbrantl99: Ad Nauseam (WUB)
#36 FluffyWolf2: Red Prison (R)
#37 joncos: Hammer Time (W, Lurrus)
#38 scipios: Dredge (BRG)
#39 fabee1: Mono Red Prowess (R)
#40 Sonkerz: Rogues (UB, Lurrus)
#41 obeylord: Oops All Spells (WUBG)
#42 BernardoDG: Neobrand (UG)
#43 OlavoJusMTM: Izzet Control (UR)
#44 cftsoc3: Gruul Midrange (RG)
#45 mei0024: Grixis Shadow (UBR, Lurrus)
#46 Skrug092: Heliod Combo (WG)
#47 Daking3603: Reclaimer Titan (WRG)
#48 Dean911: KGC Tron (G)
#49 FemboyHowoters: Incinerator Burn (R)
#50 AlabasterWolfie: Shadow Prowess (BRG, Lurrus)
#51 spiritmonger17: Winota (WRG)
#52 MTGBullent: Snoop Goblins (BR)
#53 Trailovsky: Twiddle Storm (URG)
#54 Metcalf23: Mono White Taxes (W, Yorion)
#55 joetru: Niv To Light (WUBRG, Yorion)
#56 TopDeckTown: Izzet Control (UR)
#57 Shadowz2005: Mardu Midrange (WBR)
#58 Blade400: E Tron (C)
#59 toondoslav: Infect (UG)
#60 Bullwinkkle6705: Temur Control (URG)
#61 MartinezDP: Omnath Saheeli (WURG, Yorion)
#62 MagicEd: Shadow Prowess (BR, Lurrus)
#63 Ganksyou: WURG Control (WURG)
#64 Hyperdontia: Mardu Midrange (WBR)
#65 bobthedog: Mono Black Midrange (B)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2021_01_01 : EventTest
    {
        [Test]
        public void Deck01_Kurusu_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2021-01-01",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_Boldy44_Burn_RG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",1),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck03_jay44bab_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2021-01-01",2),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck04_Dawnpiper_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2021-01-01",3),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Sundayss_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2021-01-01",4),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_NightKnight131_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",5),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_marcofabrizi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2021-01-01",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Busterbrown52_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",7),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck09_GHash77_WURGMidrange_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2021-01-01",8),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck10_Harry13_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",9),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",10),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_pokerswizard_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2021-01-01",11),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck13_IanHoff_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",12),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Robsan_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",13),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck15_B1gDan_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",14),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_kaikalbuquerque_Bogles_WUG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",15),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck17_hoveydw_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2021-01-01",16),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_603Leb_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",17),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_SpiderSpace_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",18),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck20_oskiyaa_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2021-01-01",19),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Teston_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2021-01-01",20),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck22_daibloXSC_GrixisMidrange_UBR()
        {
            Test(
                GetDeck("modern-league-2021-01-01",21),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Hampuse1_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-league-2021-01-01",22),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(DiceFactoryTron),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Curveiganhei_HammerTime_WG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",23),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck25_NHA37_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-league-2021-01-01",24),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck26_HummingBard_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",25),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Rebus8_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2021-01-01",26),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Owl1013_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-league-2021-01-01",27),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck29_MastaHorus_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-league-2021-01-01",28),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetLivingEnd),
                null
            );
        }

        [Test]
        public void Deck30_Shadowz2005_SimicControl_UG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",29),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_chachibuoh_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",30),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_adorno666_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2021-01-01",31),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck33_yneves_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",32),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck34_bigjc00_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-league-2021-01-01",33),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck35_tbrantl99_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2021-01-01",34),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck36_FluffyWolf2_RedPrison_R()
        {
            Test(
                GetDeck("modern-league-2021-01-01",35),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck37_joncos_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2021-01-01",36),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck38_scipios_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",37),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck39_fabee1_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2021-01-01",38),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Sonkerz_Rogues_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2021-01-01",39),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Rogues),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck41_obeylord_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",40),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck42_BernardoDG_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",41),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck43_OlavoJusMTM_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2021-01-01",42),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck44_cftsoc3_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",43),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck45_mei0024_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2021-01-01",44),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck46_Skrug092_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",45),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Daking3603_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",46),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck48_Dean911_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2021-01-01",47),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck49_FemboyHowoters_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2021-01-01",48),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck50_AlabasterWolfie_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2021-01-01",49),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck51_spiritmonger17_Winota_WRG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",50),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck52_MTGBullent_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2021-01-01",51),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck53_Trailovsky_TwiddleStorm_URG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",52),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(TwiddleStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck54_Metcalf23_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2021-01-01",53),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck55_joetru_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2021-01-01",54),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck56_TopDeckTown_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2021-01-01",55),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck57_Shadowz2005_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2021-01-01",56),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck58_Blade400_ETron_C()
        {
            Test(
                GetDeck("modern-league-2021-01-01",57),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck59_toondoslav_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",58),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck60_Bullwinkkle6705_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",59),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck61_MartinezDP_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2021-01-01",60),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck62_MagicEd_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2021-01-01",61),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck63_Ganksyou_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2021-01-01",62),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck64_Hyperdontia_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2021-01-01",63),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck65_bobthedog_MonoBlackMidrange_B()
        {
            Test(
                GetDeck("modern-league-2021-01-01",64),
                new PostZendikarRising(),
                ArchetypeColor.B,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
