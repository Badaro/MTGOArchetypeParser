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
#01 SgtMcMuffins: Titan Shift (RG)
#02 janssiekees: Dimir Control (UB)
#03 rcazcueta: Izzet Prowess (UR)
#04 Tarrasque1: Golgari Elves (BG)
#05 greenboy011: Azorius Control (WU)
#06 Zar0s: Reclaimer Titan (WG)
#07 jacenty_b: Burn (WR)
#08 Capin_ahab: Mono Red Prowess (R)
#09 Munich_Casual: Jund Midrange (BRG)
#10 zMunkeyXz: Mill (UBG)
#11 NAP_DARKMAGE_MJM: E Tron (C)
#12 Tw33Ty: Bogles (WG, Lurrus)
#13 Lillia: KGC Amulet Titan (UG)
#14 Ivc: Azorius Control (WU)
#15 DarthMalak: Mono Black Midrange (B)
#16 K4rl1991: Hardened Scales (G)
#17 RyanWu: Orzhov Midrange (WB)
#18 brandon__logan: Kiki Chord (WURG, Yorion)
#19 SuperCow12653: Eight Rack (B)
#20 wambocombo2020: Devoted (WG, Lurrus)
#21 yu-ki: Mill (UB, Lurrus)
#22 603Leb: Valakut Field (BRG)
#23 brainstorm39: Jeskai Control (WUR, Yorion)
#24 katobu: Heliod Combo (WG)
#25 smirabitoMTG: Sultai Shadow (UBG)
#26 Lord_of_Puntlantis: Izzet Restore Balance (UR)
#27 TJMcChillin: Naya Midrange (WRG)
#28 Insidious: Boros Prowess (WR, Lurrus)
#29 SeeFour: Thopter Urza (WUB)
#30 Rossello: Ad Nauseam (WUB)
#31 cjucjujp: Grixis Shadow (UBR)
#32 Motown123: Merfolk (WU, Lurrus)
#33 GHash77: Neobrand (UG)
#34 gyyby297: Thopter Urza (UB)
#35 cftsoc3: Bant Blink (WUG)
#36 timewalkinonsunshine: Taking Turns (URG)
#37 daviusminimus: Kiki Chord (WRG, Yorion)
#38 MagicDevil666: U Tron (U)
#39 Shazzam: Temur Delver (URG)
#40 ZeroTheCat: Jund Shadow (BRG, Lurrus)
#41 pavementisrad7: Humans (WUBRG)
#42 Stranger99: Gruul Midrange (RG)
#43 Nevetmage: Tokens (WB)
#44 Artem_Kuhtin: White Devotion (W)
#45 Sarv: Bant Control (WUG)
#46 kasa: Obosh Aggro (R, Obosh)
#47 gentleman_m_: Gifts Storm (UR)
#48 PanJ: Golgari Midrange (BG)
#49 DoctorQueller: Spirits (WU)
#50 GrandpaBiceps: Rakdos Midrange (BR)
#51 Colossum: KGC Tron (G)
#52 kojirohyuga1: Dredge (BRG)
#53 bobinchese: Bant Control (WUG)
#54 Bajka85: Dice Factory Tron (C)
#55 Mordeka1ser: Niv To Light (WUBRG, Yorion)
#56 Darkwonyx: Rakdos Prowess (BR, Lurrus)
#57 MonsterCC: Merfolk (U)
#58 DoubleB_33: Heliod Sisters (W)
#59 MagicEd: Crabvine (UBG)
#60 Bodingle: Mardu Midrange (WBR)
#61 doughhater: Valakut Field (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_09_01 : EventTest
    {
        [Test]
        public void Deck01_SgtMcMuffins_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",0),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck02_janssiekees_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-09-01",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_rcazcueta_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-01",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Tarrasque1_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck05_greenboy011_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-01",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Zar0s_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck07_jacentyb_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-09-01",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Capinahab_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-09-01",7),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_MunichCasual_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",8),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck11_NAPDARKMAGEMJM_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-09-01",10),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Tw33Ty_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-01",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Lillia_KGCAmuletTitan_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck14_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-01",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_DarthMalak_MonoBlackMidrange_B()
        {
            Test(
                GetDeck("modern-league-2020-09-01",14),
                new PostAstrolabeBan(),
                ArchetypeColor.B,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_K4rl1991_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-09-01",15),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck17_RyanWu_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-09-01",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_brandonlogan_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-01",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_SuperCow12653_EightRack_B()
        {
            Test(
                GetDeck("modern-league-2020-09-01",18),
                new PostAstrolabeBan(),
                ArchetypeColor.B,
                typeof(EightRack),
                null,
                null
            );
        }

        [Test]
        public void Deck20_wambocombo2020_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-01",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_yuki_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-01",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_603Leb_ValakutField_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",21),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(ValakutField),
                null,
                null
            );
        }

        [Test]
        public void Deck23_brainstorm39_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-01",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_katobu_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck25_smirabitoMTG_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",24),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck26_LordofPuntlantis_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-01",25),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck27_TJMcChillin_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Insidious_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-01",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_SeeFour_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-league-2020-09-01",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Rossello_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-09-01",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck31_cjucjujp_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-01",30),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Motown123_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-01",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck33_GHash77_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",32),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck34_gyyby297_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-league-2020-09-01",33),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck35_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck36_timewalkinonsunshine_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",35),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck37_daviusminimus_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-01",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck38_MagicDevil666_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-09-01",37),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Shazzam_TemurDelver_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",38),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Delver),
                typeof(TemurDelver),
                null
            );
        }

        [Test]
        public void Deck40_ZeroTheCat_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-01",39),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck41_pavementisrad7_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",40),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Stranger99_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",41),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Nevetmage_Tokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-09-01",42),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck44_ArtemKuhtin_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-league-2020-09-01",43),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Sarv_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",44),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck46_kasa_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-09-01",45),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck47_gentlemanm_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-01",46),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck48_PanJ_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",47),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck49_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-01",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck50_GrandpaBiceps_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-01",49),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Colossum_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-09-01",50),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck52_kojirohyuga1_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",51),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck53_bobinchese_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",52),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck54_Bajka85_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-league-2020-09-01",53),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(DiceFactoryTron),
                null,
                null
            );
        }

        [Test]
        public void Deck55_Mordeka1ser_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-01",54),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck56_Darkwonyx_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-01",55),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck57_MonsterCC_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-09-01",56),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck58_DoubleB33_HeliodSisters_W()
        {
            Test(
                GetDeck("modern-league-2020-09-01",57),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(SoulSisters),
                typeof(HeliodSisters),
                null
            );
        }

        [Test]
        public void Deck59_MagicEd_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",58),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck60_Bodingle_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-09-01",59),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck61_doughhater_ValakutField_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-01",60),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(ValakutField),
                null,
                null
            );
        }


    }
}
