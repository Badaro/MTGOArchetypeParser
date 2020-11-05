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
#01 Kurusu: Kiki Chord (WRG, Yorion)
#02 _Makaveli: Azorius Control (WU)
#03 BaDzIo: Hardened Scales (G)
#04 kensportsfan: Mono Red Prowess (R)
#05 carlosalmeida: Humans (WUBRG)
#06 GHash77: Bant Midrange (WUG)
#07 Ladon: Snow Saheeli (WURG)
#08 Beicodegeia: Mono Red Prowess (R, Jegantha)
#09 aspiringspike: Jund Midrange (BRG)
#10 TurmolL: Izzet Control (UR)
#11 Dylan_MTG: Izzet Restore Balance (URG)
#12 LHaxLover: Scapeshift (URG)
#13 PhantasmalBear: Azorius Midrange (WU)
#14 ContraEgo: Thopter Urza (UBR)
#15 Nilsfit: Sultai Reclamation (UBG)
#16 DeadEyeEneMy: Bogles (WG)
#17 Sharkcaster_Mage: Ad Nauseam (WUB)
#18 cnofafva: KGC Amulet Titan (WUBRG)
#19 ShogunHelios: Crabvine (UBRG)
#20 .//Automaton: Golgari Elves (BG)
#21 Lcario: Grixis Shadow (UBR)
#22 Predicted: Yawgmoth (WBG)
#23 Janh: Saheeli Combo (WUR)
#24 Bosseidon: Incinerator Burn (WR)
#25 603Leb: Amulet Titan (URG)
#26 Albyz: Sultai Control (UBG)
#27 1nfundibulum: E Tron (C)
#28 Zebrah: Boros Taxes (WR, Lurrus)
#29 Gods_Shadow: Grixis Control (UBR)
#30 Baufos: Simic Control (UG)
#31 JimmySetzer: Snoop Goblins (BR)
#32 gobboboy: Tooth And Nail (G)
#33 mwapl: Snoop Goblins (BR)
#34 Werepigs: Mardu Shadow (WBR)
#35 vitto.: Dredge (WBRG)
#36 junghans: Devoted (WRG)
#37 _VFS_: Dimir Control (UB)
#38 katuo079595: Jund Shadow (BRG)
#39 SebastianStueckl: Snoop Goblins (WBR)
#40 Archgaze: Cremator Evolution (WRG)
#41 Trellon: U Tron (U)
#42 Wuhsa: Niv To Light (WUBRG)
#43 Marxelo: Tokens (WB)
#44 esatheking: Boros Prowess (WR)
#45 Denmark_Dan: Titan Shift (RG)
#46 Thrall90: Jund Midrange (BRG)
#47 HouseOfManaMTG: KGC Tron (G)
#48 Polikasoll: Izzet Prowess (UR)
#49 Chaughey: Jeskai Delver (WUR)
#50 Mussie99: Azorius Control (WU)
#51 _Ingles_: Incinerator Burn (R)
#52 cws: Gifts Storm (UR)
#53 MrRaeb: Gruul Midrange (RG)
#54 BlueLips: Bant Control (WUG)
#55 KOKI12: Azorius Control (WU)
#56 SpiderSpace: Mono White Taxes (W)
#57 Mad-Ramon: Temur Reclamation (URG)
#58 Fabrice_K: Simic Reclamation (UG, Yorion)
#59 DreamsOfAshiok: Mardu Prowess (WBR, Lurrus)
#60 Gul_Dukat: Gruul Prowess (RG, Jegantha)
#61 penach010: Heliod Devoted (WRG, Yorion)
#62 brainstorm39: Jeskai Control (WUR, Yorion)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_07_24 : EventTest
    {
        [Test]
        public void Deck01_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-24",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_Makaveli_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-24",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_BaDzIo_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-07-24",2),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck04_kensportsfan_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-24",3),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_carlosalmeida_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck06_GHash77_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Ladon_SnowSaheeli_WURG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(SnowSaheeli),
                null
            );
        }

        [Test]
        public void Deck08_Beicodegeia_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-24",7),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_aspiringspike_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",8),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TurmolL_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_DylanMTG_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",10),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck12_LHaxLover_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",11),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck13_PhantasmalBear_AzoriusMidrange_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-24",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Nilsfit_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",14),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_DeadEyeEneMy_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck17_SharkcasterMage_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-24",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck18_cnofafva_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck19_ShogunHelios_Crabvine_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Automaton_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",19),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck21_Lcario_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Predicted_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Janh_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Bosseidon_IncineratorBurn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck25_603Leb_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",24),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck26_Albyz_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",25),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_1nfundibulum_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-24",26),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Zebrah_BorosTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-24",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_GodsShadow_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Baufos_SimicControl_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",29),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_JimmySetzer_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck32_gobboboy_ToothAndNail_G()
        {
            Test(
                GetDeck("modern-league-2020-07-24",31),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(ToothAndNail),
                null,
                null
            );
        }

        [Test]
        public void Deck33_mwapl_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",32),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck34_Werepigs_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck35_vitto_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck36_junghans_Devoted_WRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",35),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck37_VFS_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-24",36),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck38_katuo079595_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",37),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck39_SebastianStueckl_SnoopGoblins_WBR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",38),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck40_Archgaze_CrematorEvolution_WRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(CrematorEvolution),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-24",40),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Wuhsa_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Marxelo_Tokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-24",42),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck44_esatheking_BorosProwess_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",43),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck45_DenmarkDan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",44),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck46_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",45),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_HouseOfManaMTG_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-24",46),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck48_Polikasoll_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",47),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Chaughey_JeskaiDelver_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(Delver),
                typeof(JeskaiDelver),
                null
            );
        }

        [Test]
        public void Deck50_Mussie99_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-24",49),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Ingles_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-07-24",50),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck52_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",51),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck53_MrRaeb_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",52),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck54_BlueLips_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",53),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck55_KOKI12_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-24",54),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck56_SpiderSpace_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-24",55),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck57_MadRamon_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",56),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck58_FabriceK_SimicReclamation_UG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-24",57),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck59_DreamsOfAshiok_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-24",58),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck60_GulDukat_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-24",59),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck61_penach010_HeliodDevoted_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-24",60),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck62_brainstorm39_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-24",61),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
