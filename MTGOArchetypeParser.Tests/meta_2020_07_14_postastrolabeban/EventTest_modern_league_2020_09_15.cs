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
#01 SpikeYou: Sultai Control (UBG)
#02 Supercazzola: Azorius Control (WU)
#03 DFrank: Temur Control (URG)
#04 katobu: Heliod Combo (WG)
#05 hurricanexyz: Izzet Prowess (UR)
#06 hugofreitas1: Gifts Storm (UR)
#07 hcook725: Mardu Shadow (WBR)
#08 time_is_a_goon: Delver (UR)
#09 Azuregun: Humans (WUBRG)
#10 LewisCBR: Scapeshift (URG)
#11 TomKr: Dredge (BRG)
#12 kokoko098: Heliod Devoted (WBG)
#13 kulszewe: Obosh Aggro (R, Obosh)
#14 apple_Neosky: Merfolk (WU, Lurrus)
#15 Predicted: Yawgmoth (BG)
#16 timewalkinonsunshine: Taking Turns (URG)
#17 Nilsfit: Esper Control (WUB)
#18 slow_brz: Mardu Prowess (WBR, Lurrus)
#19 hermanomlg: Bant Control (WUG)
#20 TubbyBatman: Temur Midrange (URG)
#21 jtl005: Heliod Combo (W)
#22 MrZarukai: Gruul Midrange (RG)
#23 mao1986: Grixis Shadow (UBR, Lurrus)
#24 MChoq: Titan Shift (RG)
#25 atonofbutts: Grixis Delver (UBR)
#26 KAKOLOLO: Bogles (WG)
#27 Tieig: Red Prison (R)
#28 Daryl_Ayers: Amulet Titan (RG)
#29 chaba_lol: Hammer Time (W)
#30 kotka: Hollow One (BR, Obosh)
#31 GrandpaBiceps: Rakdos Midrange (BR)
#32 FloorFlower: Grixis Shadow (UBR)
#33 grinderA: Bant Control (WUG)
#34 BenMishania: Golgari Midrange (BG)
#35 rage_hs: Reclaimer Titan (WG)
#36 Belenus: Jund Midrange (BRG)
#37 K4rl1991: Hardened Scales (BG, Lurrus)
#38 Tarrasque1: Mono White Taxes (W)
#39 Jaschalomaeus: Mono Red Prowess (R)
#40 IanHoff: Merfolk (UG)
#41 Atpex: Gruul Midrange (RG)
#42 Misplacedginger: Boros Prowess (WR, Lurrus)
#43 Flowers94: Jund Midrange (BRG)
#44 JMAK2000: KGC Tron (G)
#45 j_money10: Enduring Ideal (W)
#46 Evasive_Ebu: Eight Rack (B)
#47 TomTenderloin: Ad Nauseam (WUB)
#48 SeeFour: Lantern (WUBR)
#49 eminemberry: Burn (WR)
#50 Math_God: Jund Shadow (BRG, Lurrus)
#51 Kurusu: Kiki Chord (WRG, Yorion)
#52 NEWBIN: Infect (UG)
#53 Killabee: Neobrand (UG)
#54 A22en: Snoop Goblins (BR)
#55 Kk-: Orzhov Taxes (WB)
#56 mxlzxk: Sultai Control (UBG)
#57 milikin: Jund Shadow (BRG)
#58 Kuhb: Devoted (WG, Lurrus)
#59 Kingslowking19: E Tron (C)
#60 Borjillamtg10: Azorius Control (WU)
#61 llabmonkey: Azorius Control (WU)
#62 ContraEgo: Thopter Urza (WUBR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_09_15 : EventTest
    {
        [Test]
        public void Deck01_SpikeYou_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",0),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Supercazzola_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-15",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_DFrank_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",2),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_katobu_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_hurricanexyz_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-15",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-15",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck07_hcook725_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-league-2020-09-15",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck08_timeisagoon_Delver_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-15",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Delver),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Azuregun_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_LewisCBR_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",9),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck11_TomKr_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_kokoko098_HeliodDevoted_WBG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck13_kulszewe_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-09-15",12),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck14_appleNeosky_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-15",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Predicted_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck16_timewalkinonsunshine_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",15),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Nilsfit_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-league-2020-09-15",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_slowbrz_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-15",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_hermanomlg_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_TubbyBatman_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",19),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_jtl005_HeliodCombo_W()
        {
            Test(
                GetDeck("modern-league-2020-09-15",20),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck22_MrZarukai_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",21),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_mao1986_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-15",22),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_MChoq_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",23),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck25_atonofbutts_GrixisDelver_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-15",24),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(Delver),
                typeof(GrixisDelver),
                null
            );
        }

        [Test]
        public void Deck26_KAKOLOLO_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Tieig_RedPrison_R()
        {
            Test(
                GetDeck("modern-league-2020-09-15",26),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck28_DarylAyers_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",27),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck29_chabalol_HammerTime_W()
        {
            Test(
                GetDeck("modern-league-2020-09-15",28),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck30_kotka_HollowOne_BR_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-09-15",29),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(HollowOne),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck31_GrandpaBiceps_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-15",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_FloorFlower_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-15",31),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck33_grinderA_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",32),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_BenMishania_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",33),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck35_ragehs_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck36_Belenus_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",35),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck37_K4rl1991_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-15",36),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck38_Tarrasque1_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-09-15",37),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Jaschalomaeus_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-09-15",38),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck40_IanHoff_Merfolk_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",39),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Atpex_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",40),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Misplacedginger_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-15",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck43_Flowers94_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",42),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck44_JMAK2000_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-09-15",43),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck45_jmoney10_EnduringIdeal_W()
        {
            Test(
                GetDeck("modern-league-2020-09-15",44),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck46_EvasiveEbu_EightRack_B()
        {
            Test(
                GetDeck("modern-league-2020-09-15",45),
                new PostAstrolabeBan(),
                ArchetypeColor.B,
                typeof(EightRack),
                null,
                null
            );
        }

        [Test]
        public void Deck47_TomTenderloin_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-09-15",46),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck48_SeeFour_Lantern_WUBR()
        {
            Test(
                GetDeck("modern-league-2020-09-15",47),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBR,
                typeof(Lantern),
                null,
                null
            );
        }

        [Test]
        public void Deck49_eminemberry_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-09-15",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck50_MathGod_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-15",49),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck51_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-15",50),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck52_NEWBIN_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",51),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Killabee_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",52),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck54_A22en_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-15",53),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck55_Kk_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-09-15",54),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck56_mxlzxk_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",55),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck57_milikin_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-15",56),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck58_Kuhb_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-15",57),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck59_Kingslowking19_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-09-15",58),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck60_Borjillamtg10_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-15",59),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck61_llabmonkey_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-15",60),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck62_ContraEgo_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-league-2020-09-15",61),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }


    }
}
