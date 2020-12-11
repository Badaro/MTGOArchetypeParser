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
#01 cccaspar: White Devotion (W)
#02 ContraEgo: Thopter Urza (WUBR)
#03 bone55: Jund Midrange (BRG)
#04 aspiringspike: Jeskai Control (WUR)
#05 Bosh N Roll: Kiki Chord (WURG, Yorion)
#06 ittoku1: Bant Midrange (WUG)
#07 Chris_Concarnage: Obosh Aggro (R, Obosh)
#08 Kzrds: Heliod Combo (WG)
#09 Plus1Plus1: Heliod Combo (WG)
#10 BernardoDG: Reclaimer Titan (WRG)
#11 tibalt_of_red_sub: Mill (UB)
#12 MlckyB: Bogles (WG)
#13 SvenSveeterSven: Mardu Midrange (WBR)
#14 yPrincipe: Snoop Goblins (BR)
#15 IPlayBadDecks: Yawgmoth (BG)
#16 SoulStrong: Rogues (UB, Lurrus)
#17 B1gDan: Saheeli Combo (WUR)
#18 V_Olkhovikov: Sultai Shadow (UBG)
#19 BSK_hercules: Sultai Control (UBG)
#20 masakitaro: E Tron (C)
#21 NicDamian: Bant Midrange (WUG)
#22 Somefellow: Amulet Titan (BG)
#23 mashmalovsky: Ad Nauseam (WUB)
#24 SugarMountain: Mardu Midrange (WBR)
#25 Curryvore: Azorius Control (WU, Yorion)
#26 TheVlagh: Belcher (URG)
#27 Gallows_Humor: Humans (WUBRG)
#28 facematt: Gruul Midrange (RG, Obosh)
#29 A22en: Mill (UB, Lurrus)
#30 White_Fish: Hardened Scales (BG, Lurrus)
#31 nahuel10: Izzet Prowess (UR)
#32 Parrit: Winota (WR, Yorion)
#33 HouseOfManaMTG: Reclaimer Titan (UG)
#34 Lord_of_Puntlantis: Izzet Restore Balance (UR)
#35 603Leb: Obosh Aggro (R, Obosh)
#36 B1gDan: Shadow Prowess (BRG, Lurrus)
#37 BadMagicPlayer1: Izzet Control (UR)
#38 jvidarte: Burn (WR, Lurrus)
#39 Tarrasque1: Mono White Taxes (W)
#40 katoriarch123: WURG Control (WURG)
#41 mdvayu2: Shadow Prowess (BR, Lurrus)
#42 Jaberwocki: Jund Midrange (BRG)
#43 darthjacen: Dredge (BRG)
#44 ivanguille: Dimir Control (UB)
#45 Chichichi: Mono Red Prowess (R)
#46 J0SE: Oops All Spells (WUBG)
#47 Nikachu: Merfolk (U, Lurrus)
#48 starfall: Heliod Combo (WR)
#49 dsnavely13: Gifts Storm (UR)
#50 IPlayBadDecks: Twiddle Storm (UB)
#51 Tedpanic: Azorius Control (WU)
#52 Laplasjan: Hammer Time (WB, Lurrus)
#53 Curveiganhei: Temur Control (URG)
#54 Hooky: Niv To Light (WUBRG, Yorion)
#55 Captainschwiggles: Rakdos Midrange (BR)
#56 HighArtificer: Thopter Urza (WUBR)
#57 TuggaNaxos: Sultai Control (UBG)
#58 NuclearAdam: Devoted (WG, Lurrus)
#59 Wtnof: Gruul Midrange (RG)
#60 NIMAME: KGC Tron (G)
#61 Clexxor: Azorius Taxes (WU, Yorion)
#62 Vago_1: Bant Spirits (WUG)
#63 Antoine57437: Bant Blink (WUG)
#64 UnderwaterBimbo: Delver (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_12_11 : EventTest
    {
        [Test]
        public void Deck01_cccaspar_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-league-2020-12-11",0),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck02_ContraEgo_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",1),
                new PostZendikarRising(),
                ArchetypeColor.WUBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck03_bone55_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",2),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_aspiringspike_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",3),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_BoshNRoll_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-11",4),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_ittoku1_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",5),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_ChrisConcarnage_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-12-11",6),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck08_Kzrds_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Plus1Plus1_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck10_BernardoDG_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",9),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck11_tibaltofredsub_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-12-11",10),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck12_MlckyB_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",11),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck13_SvenSveeterSven_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",12),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_yPrincipe_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",13),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck15_IPlayBadDecks_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",14),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck16_SoulStrong_Rogues_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-11",15),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Rogues),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_B1gDan_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",16),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck18_VOlkhovikov_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",17),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck19_BSKhercules_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",18),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_masakitaro_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-12-11",19),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck21_NicDamian_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",20),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Somefellow_AmuletTitan_BG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",21),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck23_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-11",22),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck24_SugarMountain_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",23),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Curryvore_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-11",24),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck26_TheVlagh_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",25),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck27_GallowsHumor_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",26),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck28_facematt_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-12-11",27),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck29_A22en_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-11",28),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_WhiteFish_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-11",29),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",30),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Parrit_Winota_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-11",31),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Winota),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck33_HouseOfManaMTG_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",32),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck34_LordofPuntlantis_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",33),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck35_603Leb_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-12-11",34),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck36_B1gDan_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-11",35),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck37_BadMagicPlayer1_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",36),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck38_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-11",37),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck39_Tarrasque1_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-12-11",38),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck40_katoriarch123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",39),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck41_mdvayu2_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-11",40),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck42_Jaberwocki_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",41),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck43_darthjacen_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",42),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck44_ivanguille_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-12-11",43),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Chichichi_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-12-11",44),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck46_J0SE_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",45),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Nikachu_Merfolk_U_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-11",46),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck48_starfall_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",47),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck49_dsnavely13_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",48),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck50_IPlayBadDecks_TwiddleStorm_UB()
        {
            Test(
                GetDeck("modern-league-2020-12-11",49),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(TwiddleStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Tedpanic_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-11",50),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-11",51),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck53_Curveiganhei_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",52),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck54_Hooky_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-11",53),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck55_Captainschwiggles_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",54),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck56_HighArtificer_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",55),
                new PostZendikarRising(),
                ArchetypeColor.WUBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck57_TuggaNaxos_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",56),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck58_NuclearAdam_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-11",57),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck59_Wtnof_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",58),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck60_NIMAME_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-12-11",59),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck61_Clexxor_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-11",60),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck62_Vago1_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",61),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck63_Antoine57437_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-11",62),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck64_UnderwaterBimbo_Delver_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-11",63),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(Delver),
                null,
                null
            );
        }


    }
}
