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
#01 aspiringspike: Zombies (UB)
#02 TheWonderLord: Golgari Midrange (BG)
#03 Zxrogue: Elves (G)
#04 russell_wilson: Burn (BR, Lurrus)
#05 Costola91: Heliod Combo (WG)
#06 StarFonta: Shadow Prowess (BR, Lurrus)
#07 devtin: Abzan Midrange (WBG)
#08 llabmonkey: Omnath Saheeli (WURG, Jegantha)
#09 GutsMTG: Scapeshift (URG)
#10 Trellon: U Tron (U)
#11 hermanomlg: Bant Midrange (WUG)
#12 Strubb: Ad Nauseam (WUB)
#13 MHayashi: Obosh Aggro (R, Obosh)
#14 asmitchler: UBRG Shadow (UBRG)
#15 heyakita: Snow Saheeli (WURG, Yorion)
#16 yatoyatoya: Mono White Eldrazi Taxes (W)
#17 Dudleythedog: Mono Red Prowess (R)
#18 daibloXSC: Azorius Control (WU)
#19 radmc: Jeskai Control (WUR)
#20 ExtraEasy88: Mardu Prowess (WBR, Lurrus)
#21 SenorLarson: Izzet Control (UR)
#22 daibloXSC: Jeskai Breach (WURG, Jegantha)
#23 buddha715: Belcher (WRG)
#24 ittoku1: Bant Blink (WUG)
#25 matiaskm: Devoted (WG, Lurrus)
#26 zyuraru: UBRG Control (UBRG)
#27 IzzetSignetIsTheBest: Reclaimer Titan (WRG)
#28 Metcalf23: Mono White Taxes (W)
#29 N3to: Gifts Storm (UR)
#30 Leviathan102: KGC Amulet Titan (WURG)
#31 __BMJ__: Kinnan Legends (WURG, Jegantha)
#32 Borjillamtg10: Rakdos Midrange (BR)
#33 Yozis: Mill (UB, Lurrus)
#34 yPrincipe: Gruul Breach (RG)
#35 calexa: KGC Tron (G)
#36 AkiraKryne: Mill (UBG)
#37 nekomap: Naya Landfall (WRG)
#38 maear: Kiki Chord (WRG, Yorion)
#39 yPrincipe: E Tron (C)
#40 Krukgar: Rakdos Midrange (BR)
#41 magicplayer103472: Jund Midrange (BRG)
#42 fabee1: Bant Midrange (WUG)
#43 SgtMcMuffins: Sultai Reclamation (UBG)
#44 Heir_of_Elendil15: Grixis Shadow (UBR)
#45 Wuhsa: Niv To Light (WUBRG)
#46 jacobricher: Humans (WUBRG)
#47 GuardianShield: Kor Equipments (WR)
#48 romanmy: Gruul Eldrazi (RG)
#49 Haricot-Rouge: Dredge (UBR)
#50 yunari-456: Izzet Prowess (UR)
#51 qbturtle15: Gruul Midrange (RG)
#52 aspiringspike: Azorius Control (WU)
#53 aplapp: Orzhov Midrange (WB)
#54 GideonRavensword: Dredge (BRG)
#55 SebastianStueckl: Belcher (URG)
#56 katobu: Merfolk (UR)
#57 ncowden: Grixis Control (UBR)
#58 tylerjjobrien: Sultai Control (UBG)
#59 CasperKhaos: Izzet Restore Balance (URG)
#60 AMetnik: Azorius Control (WU)
#61 AngelicExecution: White Devotion (W)
#62 CitrusD: Yawgmoth (BG)
#63 Sodeq: Oops All Spells (WUBRG)
#64 jvidarte: Burn (WR, Lurrus)
#65 Kurusu: Kiki Chord (WRG, Yorion)
#66 bamzing: WURG Control (WURG)
#67 DoctorQueller: Spirits (WU)
#68 XxdhampirxX: Goryo Reanimator (UBR)
#69 HouseOfManaMTG: Heliod Combo (WG)
#70 BrandedGrisel: Titan Shift (RG)
#71 ContraEgo: Thopter Urza (UBR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_10_13 : EventTest
    {
        [Test]
        public void Deck01_aspiringspike_Zombies_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-13",0),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Zombies),
                null,
                null
            );
        }

        [Test]
        public void Deck02_TheWonderLord_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",1),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Zxrogue_Elves_G()
        {
            Test(
                GetDeck("modern-league-2020-10-13",2),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Elves),
                null,
                null
            );
        }

        [Test]
        public void Deck04_russellwilson_Burn_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-13",3),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Costola91_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",4),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck06_StarFonta_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-13",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_devtin_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",6),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_llabmonkey_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-13",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_GutsMTG_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",8),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-10-13",9),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_hermanomlg_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",10),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Strubb_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-10-13",11),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck13_MHayashi_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-10-13",12),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck14_asmitchler_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",13),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_heyakita_SnowSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-13",14),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(SnowSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_yatoyatoya_MonoWhiteEldraziTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-10-13",15),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Dudleythedog_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-10-13",16),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck18_daibloXSC_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-13",17),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_radmc_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",18),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ExtraEasy88_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-13",19),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_SenorLarson_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",20),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_daibloXSC_JeskaiBreach_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-13",21),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck23_buddha715_Belcher_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",22),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck24_ittoku1_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",23),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck25_matiaskm_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-13",24),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_zyuraru_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",25),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_IzzetSignetIsTheBest_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",26),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck28_Metcalf23_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-10-13",27),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck29_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",28),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Leviathan102_KGCAmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",29),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck31_BMJ_KinnanLegends_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-13",30),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(KinnanLegends),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck32_Borjillamtg10_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",31),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Yozis_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-13",32),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck34_yPrincipe_GruulBreach_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",33),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GruulBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck35_calexa_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-10-13",34),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck36_AkiraKryne_Mill_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",35),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck37_nekomap_NayaLandfall_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",36),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(NayaLandfall),
                null,
                null
            );
        }

        [Test]
        public void Deck38_maear_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-13",37),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck39_yPrincipe_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-10-13",38),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Krukgar_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",39),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck41_magicplayer103472_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",40),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck42_fabee1_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",41),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck43_SgtMcMuffins_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",42),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck44_HeirofElendil15_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",43),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Wuhsa_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",44),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck46_jacobricher_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",45),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck47_GuardianShield_KorEquipments_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",46),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(KorEquipments),
                null,
                null
            );
        }

        [Test]
        public void Deck48_romanmy_GruulEldrazi_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",47),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GruulEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck49_HaricotRouge_Dredge_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",48),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck50_yunari456_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",49),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck51_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",50),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck52_aspiringspike_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-13",51),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck53_aplapp_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-10-13",52),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck54_GideonRavensword_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",53),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck55_SebastianStueckl_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",54),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck56_katobu_Merfolk_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",55),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck57_ncowden_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",56),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck58_tylerjjobrien_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",57),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck59_CasperKhaos_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",58),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck60_AMetnik_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-13",59),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck61_AngelicExecution_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-league-2020-10-13",60),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck62_CitrusD_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",61),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck63_Sodeq_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",62),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck64_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-13",63),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck65_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-13",64),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck66_bamzing_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",65),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck67_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-13",66),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck68_XxdhampirxX_GoryoReanimator_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",67),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GoryoReanimator),
                null,
                null
            );
        }

        [Test]
        public void Deck69_HouseOfManaMTG_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",68),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck70_BrandedGrisel_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-13",69),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck71_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-13",70),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }


    }
}
