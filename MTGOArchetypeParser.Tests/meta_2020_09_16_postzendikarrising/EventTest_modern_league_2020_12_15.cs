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
#01 Snapcaster-Bolt: Reclaimer Titan (WUG)
#02 DoctorQueller: Spirits (WU)
#03 RespectTheCat: Izzet Phoenix (UR)
#04 Zeranox: Gruul Midrange (RG, Obosh)
#05 TSPJendrek: Azorius Control (WU)
#06 serum_visions: Shadow Prowess (BRG, Lurrus)
#07 InsipidSepiid: Clerics (WBG)
#08 Boucha: Belcher (URG)
#09 aplapp: Primeval Titan (UG)
#10 mindclicer: UBRG Shadow (UBRG)
#11 Tyson555555: Izzet Prowess (UR)
#12 Plus1Plus1: Heliod Combo (WG)
#13 Brunninho: Gifts Storm (UR)
#14 zectrooperdelta: Izzet Control (UR)
#15 MHayashi: Obosh Aggro (R, Obosh)
#16 __BMJ__: Heliod Combo (WR)
#17 Magic_Dan: Rakdos Prowess (BR, Lurrus)
#18 ChillingLauge: Dredge (BRG)
#19 Kurusu: Kiki Chord (WURG, Yorion)
#20 MonoGFalcon: Hardened Scales (RG)
#21 nazart: Heliod Combo (WG)
#22 SpkBri: Shadow Prowess (BR, Lurrus)
#23 Matty_Mumbles: Azorius Taxes (WU, Yorion)
#24 Borjillamtg10: Rakdos Midrange (BR)
#25 yPrincipe: Oops All Spells (WUBG)
#26 Nextep: Jeskai Control (WUR)
#27 6argamel: Heliod Combo (WG, Yorion)
#28 metalloveman: Humans (WUBRG)
#29 Reynad: Hammer Time (WRG)
#30 plamfinator: Jund Midrange (BRG)
#31 FluffyWolf2: Red Prison (R)
#32 koko_lopez: Sultai Control (UBG)
#33 vasko19: Izzet Restore Balance (UR)
#34 Kenzaburo: Kiki Chord (WURG, Yorion)
#35 Iceman76: Snoop Goblins (BR)
#36 Parrit: Winota (WR, Yorion)
#37 weishengzhishabi: Sultai Control (UBG)
#38 Orpheus819: Mill (UB, Lurrus)
#39 fenix4444: KGC Tron (G)
#40 mashmalovsky: Ad Nauseam (WUB)
#41 Parrit: Mono White Taxes (W)
#42 AlphaBlade: Amulet Titan (BG)
#43 HummingBard: U Tron (U)
#44 Rebellion1308: Mono Red Prowess (R)
#45 IzzetSignetIsTheBest: Reclaimer Titan (WG)
#46 Garzanese: Yawgmoth (BG)
#47 MaxCapone: Jeskai Control (WUR)
#48 SB7448: Dimir Shadow (UB)
#49 SpedeRip: Izzet Control (UR)
#50 daibloXSC: Thopter Urza (WUR)
#51 MruLoNGx: Izzet Control (UR)
#52 ACG88: Hammer Time (WB, Lurrus)
#53 kiko: Azorius Taxes (WU, Yorion)
#54 daibloXSC: Erayo Prison (WUB)
#55 StreexIT: Neobrand (UG)
#56 l_escargot: Burn (WR)
#57 DemianDesposito10: Burn (R)
#58 glorybox: E Tron (C)
#59 eclipse4343: Azorius Control (WU)
#60 Voltzwagon: Gruul Midrange (RG)
#61 603Leb: Living End (BRG)
#62 AlSnow: WURG Control (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_12_15 : EventTest
    {
        [Test]
        public void Deck01_SnapcasterBolt_ReclaimerTitan_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",0),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck02_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-15",1),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck03_RespectTheCat_IzzetPhoenix_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetPhoenix),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Zeranox_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-12-15",3),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck05_TSPJendrek_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-15",4),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_serumvisions_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-15",5),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_InsipidSepiid_Clerics_WBG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",6),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(Clerics),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Boucha_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",7),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck09_aplapp_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",8),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck10_mindclicer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",9),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Tyson555555_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",10),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Plus1Plus1_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",11),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Brunninho_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",12),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck14_zectrooperdelta_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",13),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_MHayashi_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-12-15",14),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck16_BMJ_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",15),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck17_MagicDan_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-15",16),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_ChillingLauge_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",17),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Kurusu_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-15",18),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_MonoGFalcon_HardenedScales_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",19),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck21_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",20),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck22_SpkBri_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-15",21),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_MattyMumbles_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-15",22),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_Borjillamtg10_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",23),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_yPrincipe_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",24),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Nextep_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",25),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_6argamel_HeliodCombo_WG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-15",26),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_metalloveman_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",27),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Reynad_HammerTime_WRG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",28),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck30_plamfinator_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",29),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_FluffyWolf2_RedPrison_R()
        {
            Test(
                GetDeck("modern-league-2020-12-15",30),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck32_kokolopez_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",31),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_vasko19_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",32),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck34_Kenzaburo_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-15",33),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck35_Iceman76_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",34),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck36_Parrit_Winota_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-15",35),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Winota),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_weishengzhishabi_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",36),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Orpheus819_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-15",37),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck39_fenix4444_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-12-15",38),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck40_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-15",39),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-12-15",40),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck42_AlphaBlade_AmuletTitan_BG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",41),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck43_HummingBard_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-12-15",42),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Rebellion1308_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-12-15",43),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck45_IzzetSignetIsTheBest_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",44),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck46_Garzanese_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",45),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck47_MaxCapone_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",46),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck48_SB7448_DimirShadow_UB()
        {
            Test(
                GetDeck("modern-league-2020-12-15",47),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck49_SpedeRip_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",48),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck50_daibloXSC_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",49),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck51_MruLoNGx_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",50),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_ACG88_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-15",51),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck53_kiko_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-15",52),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck54_daibloXSC_ErayoPrison_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-15",53),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(ErayoPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck55_StreexIT_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",54),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck56_lescargot_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-15",55),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck57_DemianDesposito10_Burn_R()
        {
            Test(
                GetDeck("modern-league-2020-12-15",56),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck58_glorybox_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-12-15",57),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck59_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-15",58),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck60_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",59),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck61_603Leb_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",60),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck62_AlSnow_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-12-15",61),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
