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
#01 Nextep: Izzet Control (UR)
#02 pandanaconda: Hardened Scales (RG)
#03 Parole: Selenya Midrange (WG)
#04 gyyby297: Oops All Spells (WUBG)
#05 TheDogFish: Merfolk (U)
#06 Alcander: Shadow Prowess (BRG, Lurrus)
#07 Jadacant: Dice Factory Tron (C)
#08 cnotiog: Grixis Shadow (UBR)
#09 Rebellion1308: Mono Red Prowess (R)
#10 bresett123: Jeskai Control (WUR)
#11 Qoiet: U Tron (U)
#12 Vertyx_: Izzet Prowess (UR)
#13 SpiderSpace: Izzet Restore Balance (UR)
#14 TscheggschDePoegg: Selenya Taxes (WG)
#15 Wuhsa: Niv To Light (WUBRG)
#16 Binolino: Reclaimer Titan (WRG)
#17 Ramp: Shadow Prowess (BR, Lurrus)
#18 Kurusu: Kiki Chord (WRG, Yorion)
#19 Krenca: Infect (UG)
#20 CrusherBotBG: Hammer Time (W, Lurrus)
#21 _Stream: Naya Prowess (WRG, Lurrus)
#22 heyakita: Omnath Saheeli (WURG, Yorion)
#23 603Leb: Jund Midrange (BRG)
#24 JustBurn420: Slivers (WUBRG)
#25 flatnose: Merfolk (UG)
#26 AlexFromTheNorth: Bushwhacker Zoo (WRG)
#27 VonCireot: Mill (UB)
#28 Foxantes: E Tron (C)
#29 Nikachu: Merfolk (UG)
#30 Pomeelo98: Bant Midrange (WUG)
#31 Krukgar: Rakdos Midrange (BR)
#32 calexa: KGC Tron (G)
#33 AbelMolto: Burn (WRG)
#34 tzio: Orzhov Midrange (WB)
#35 BenMishania: Temur Control (URG)
#36 FriskiFraska: Titan Stompy (BRG, Gyruda)
#37 Asoen: Rakdos Midrange (BR)
#38 qbturtle15: Azorius Control (WU)
#39 ThatAsianGuy8: Gruul Midrange (RG)
#40 CRYPTIC_C4SSIE: Sultai Control (UBG)
#41 Leviathan102: Amulet Titan (UG)
#42 CitrusD: Yawgmoth (BG)
#43 iuriper: Belcher (URG)
#44 129th: Spirits (WUG)
#45 MrRaeb: UBRG Control (UBRG, Yorion)
#46 yuseimax: Soulflayer (BRG)
#47 WaToO: Esper Control (WUB)
#48 keyan926: Heliod Combo (WG)
#49 NickPensy: Humans (WUBRG)
#50 Lucabireskusku: Izzet Control (UR)
#51 Furtch: Rakdos Midrange (BR)
#52 ANinjaCake: Heliod Combo (WG)
#53 btr_be_lucky_thn_gud: Izzet Control (UR)
#54 Amplumnox: Shadow Prowess (WBR, Lurrus)
#55 daibloXSC: Azorius Control (WU)
#56 apriolo1: Amulet Titan (WRG)
#57 MHayashi: Obosh Aggro (R, Obosh)
#58 FlxEx: Battle Of Wits (WUBRG, Yorion)
#59 adbnau: Dredge (BRG)
#60 WhiTe TsaR: Azorius Control (WU)
#61 _GORRAS_: Gifts Storm (UR)
#62 Gabriel0288: Omnath Saheeli (WURG, Jegantha)
#63 ZYX_Jerry: Selective Oracle (WU)
#64 crazybaloth: Devoted (WG, Lurrus)
#65 eXavie: Azorius Taxes (WU, Yorion)
#66 shown117: WURG Control (WURG)
#67 BluePlasma: Burn (WR)
#68 eclipse4343: Azorius Control (WU)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_11_10 : EventTest
    {
        [Test]
        public void Deck01_Nextep_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-10",0),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_pandanaconda_HardenedScales_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",1),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Parole_SelenyaMidrange_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",2),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_gyyby297_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck05_TheDogFish_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-11-10",4),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Alcander_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-10",5),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Jadacant_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-league-2020-11-10",6),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(DiceFactoryTron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_cnotiog_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-11-10",7),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Rebellion1308_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-11-10",8),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_bresett123_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-11-10",9),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Qoiet_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-11-10",10),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Vertyx_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-10",11),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_SpiderSpace_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-10",12),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck14_TscheggschDePoegg_SelenyaTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",13),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Wuhsa_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",14),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Binolino_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",15),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck17_Ramp_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-10",16),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-10",17),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Krenca_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",18),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck20_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-10",19),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Stream_NayaProwess_WRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-10",20),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_heyakita_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-10",21),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_603Leb_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",22),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",23),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck25_flatnose_Merfolk_UG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",24),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck26_AlexFromTheNorth_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",25),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Zoo),
                typeof(BushwhackerZoo),
                null
            );
        }

        [Test]
        public void Deck27_VonCireot_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-11-10",26),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Foxantes_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-11-10",27),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Nikachu_Merfolk_UG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",28),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Pomeelo98_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",29),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Krukgar_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-10",30),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_calexa_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-11-10",31),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck33_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",32),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck34_tzio_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-11-10",33),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck35_BenMishania_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",34),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck36_FriskiFraska_TitanStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-11-10",35),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(TitanStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck37_Asoen_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-10",36),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck38_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-10",37),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck39_ThatAsianGuy8_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",38),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck40_CRYPTICC4SSIE_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",39),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Leviathan102_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",40),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck42_CitrusD_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",41),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck43_iuriper_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",42),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck44_129th_Spirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",43),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck45_MrRaeb_UBRGControl_UBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-10",44),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck46_yuseimax_Soulflayer_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",45),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Soulflayer),
                null,
                null
            );
        }

        [Test]
        public void Deck47_WaToO_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-league-2020-11-10",46),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck48_keyan926_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",47),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck49_NickPensy_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",48),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Lucabireskusku_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-10",49),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Furtch_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-10",50),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck52_ANinjaCake_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",51),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck53_btrbeluckythngud_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-10",52),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck54_Amplumnox_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-10",53),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck55_daibloXSC_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-10",54),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck56_apriolo1_AmuletTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",55),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck57_MHayashi_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-11-10",56),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck58_FlxEx_BattleOfWits_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-10",57),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BattleOfWits),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck59_adbnau_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",58),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck60_WhiTeTsaR_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-10",59),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck61_GORRAS_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-10",60),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck62_Gabriel0288_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-11-10",61),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck63_ZYXJerry_SelectiveOracle_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-10",62),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(SelectiveOracle),
                null,
                null
            );
        }

        [Test]
        public void Deck64_crazybaloth_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-10",63),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck65_eXavie_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-10",64),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck66_shown117_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-10",65),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck67_BluePlasma_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-11-10",66),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck68_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-10",67),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
