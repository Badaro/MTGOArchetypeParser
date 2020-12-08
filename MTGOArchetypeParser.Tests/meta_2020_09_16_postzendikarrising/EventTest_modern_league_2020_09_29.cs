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
#01 NuBlkAu: Rakdos Shadow (BR)
#02 moyashi0904: WURG Control (WURG)
#03 buddha715: KGC Tron (G)
#04 Rai_K: Bushwhacker Zoo (WRG)
#05 Loganinc: Scapeshift (UBRG)
#06 j_money10: Shadow Prowess (BR, Lurrus)
#07 Tarrasque1: Elementals (WUBRG, Kaheera)
#08 Schnabulant: Oops All Spells (WUBG)
#09 RRozanski: Reclaimer Titan (WURG)
#10 hsandi9: Grixis Shadow (UBR, Lurrus)
#11 saccij92: Jund Midrange (BRG)
#12 yuurari_yuko: Heliod Combo (WG)
#13 midnuzzles: Mardu Midrange (WBR)
#14 Manuel_Danninger: Mardu Midrange (WBR)
#15 JouNick: Humans (WUBRG)
#16 basebuilder: Ad Nauseam (WUB)
#17 MagicalHack99: KGC Amulet Titan (G)
#18 RyanWu: Orzhov Midrange (WB)
#19 GideonRavensword: Crabvine (UBG)
#20 Capiplaf95: Burn (WR)
#21 masakitaro: E Tron (C)
#22 Yanley: Selenya Taxes (WG)
#23 penach010: Smallpox (WBR)
#24 deathandcatmix: Mono White Taxes (W, Lurrus)
#25 kurohiren: Niv To Light (WUBRG, Yorion)
#26 BoltTheBirds: Gifts Storm (UR)
#27 Gafiiis: Spirits (WU)
#28 CyricCanela: Gruul Midrange (RG)
#29 DoctorQueller: Bant Spirits (WUG)
#30 oskiyaa: Obosh Aggro (R, Obosh)
#31 UrbanPope: Rakdos Prowess (BR, Lurrus)
#32 Gods_Shadow: Azorius Control (WU)
#33 Jokersrwild: Golgari Midrange (BG)
#34 The_nayr: Devoted (WG, Lurrus)
#35 cntrlfreak: Sultai Shadow (UBG)
#36 StormGuyisme: Oops All Spells (BRG)
#37 Sonkerz: Rogues (UB)
#38 TheDogFish: Merfolk (UG)
#39 tendercloud: Hardened Scales (G)
#40 cccaspar: Bant Blink (WUG)
#41 aooaaooa: Lantern (UB)
#42 Trid0n: Bant Midrange (WUG)
#43 Nideon: Belcher (RG)
#44 wambocombo2020: UBRG Control (UBRG)
#45 SaborDeSoledad: Naya Taxes (WRG)
#46 ImmanuelKantrolGod: Jeskai Control (WUR)
#47 XxquestionablyawesomexX: Bogles (WG, Lurrus)
#48 kensportsfan: Mono Red Prowess (R)
#49 keyan926: Burn (BR, Lurrus)
#50 kaktusowysmok: Snoop Goblins (BR)
#51 Polikasoll: Izzet Prowess (UR)
#52 wingsfan24: Naya Landfall (WRG, Lurrus)
#53 thelastgod: Selenya Midrange (WG)
#54 KrowNinja49: Jeskai Control (WUR)
#55 salvamala: Jund Midrange (BRG)
#56 Fix_hem_all: Boros Sunforger (WRG)
#57 Pepi94: Dredge (BRG)
#58 IzzetSignetIsTheBest: Reclaimer Titan (WRG)
#59 The_GingerBrute: Hammer Time (WR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_09_29 : EventTest
    {
        [Test]
        public void Deck01_NuBlkAu_RakdosShadow_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-29",0),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck02_moyashi0904_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_buddha715_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-09-29",2),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck04_RaiK_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",3),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Zoo),
                typeof(BushwhackerZoo),
                null
            );
        }

        [Test]
        public void Deck05_Loganinc_Scapeshift_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",4),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck06_jmoney10_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-29",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Tarrasque1_Elementals_WUBRG_Kaheera()
        {
            Test(
                GetDeck("modern-league-2020-09-29",6),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck08_Schnabulant_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",7),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck09_RRozanski_ReclaimerTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",8),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck10_hsandi9_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-29",9),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_saccij92_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",10),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_yuurariyuko_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",11),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck13_midnuzzles_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-09-29",12),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_ManuelDanninger_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-09-29",13),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_JouNick_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",14),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_basebuilder_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-09-29",15),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck17_MagicalHack99_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("modern-league-2020-09-29",16),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck18_RyanWu_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-09-29",17),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_GideonRavensword_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",18),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Capiplaf95_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-09-29",19),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck21_masakitaro_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-09-29",20),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Yanley_SelenyaTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",21),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck23_penach010_Smallpox_WBR()
        {
            Test(
                GetDeck("modern-league-2020-09-29",22),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck24_deathandcatmix_MonoWhiteTaxes_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-29",23),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_kurohiren_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-29",24),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck26_BoltTheBirds_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-29",25),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Gafiiis_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-29",26),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck28_CyricCanela_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",27),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_DoctorQueller_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",28),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck30_oskiyaa_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-09-29",29),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck31_UrbanPope_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-29",30),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_GodsShadow_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-29",31),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Jokersrwild_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",32),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Thenayr_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-29",33),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck35_cntrlfreak_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",34),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck36_StormGuyisme_OopsAllSpells_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",35),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Sonkerz_Rogues_UB()
        {
            Test(
                GetDeck("modern-league-2020-09-29",36),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Rogues),
                null,
                null
            );
        }

        [Test]
        public void Deck38_TheDogFish_Merfolk_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",37),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck39_tendercloud_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-09-29",38),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck40_cccaspar_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",39),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck41_aooaaooa_Lantern_UB()
        {
            Test(
                GetDeck("modern-league-2020-09-29",40),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Lantern),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Trid0n_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",41),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Nideon_Belcher_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",42),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck44_wambocombo2020_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",43),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck45_SaborDeSoledad_NayaTaxes_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",44),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck46_ImmanuelKantrolGod_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-09-29",45),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_XxquestionablyawesomexX_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-29",46),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck48_kensportsfan_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-09-29",47),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck49_keyan926_Burn_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-29",48),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck50_kaktusowysmok_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-29",49),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck51_Polikasoll_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-29",50),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck52_wingsfan24_NayaLandfall_WRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-29",51),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(NayaLandfall),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck53_thelastgod_SelenyaMidrange_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",52),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck54_KrowNinja49_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-09-29",53),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck55_salvamala_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",54),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Fixhemall_BorosSunforger_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",55),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(BorosSunforger),
                null,
                null
            );
        }

        [Test]
        public void Deck57_Pepi94_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",56),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck58_IzzetSignetIsTheBest_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-29",57),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck59_TheGingerBrute_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-29",58),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
