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
#01 Endermeap: Infect (UG)
#02 Trellon: U Tron (U)
#03 LooseLois65: Grixis Control (UBR, Lurrus)
#04 darthjacen: Humans (WUBRG)
#05 SHUANEEHOG: Mono Red Prowess (R)
#06 yPrincipe: WURG Control (WURG)
#07 bobthedog: Azorius Control (WU)
#08 flatnose: Merfolk (WU)
#09 remf: Izzet Restore Balance (URG)
#10 bant_is_love: Reclaimer Titan (WURG)
#11 DukeVitro: Sultai Shadow (UBG)
#12 DoctorQueller: Spirits (WU)
#13 MrSeri: Heliod Combo (W)
#14 moralmar: Heliod Devoted (WG)
#15 Chipsoss: Shadow Prowess (BR, Lurrus)
#16 thel0stb0y: Gruul Midrange (RG)
#17 seasonofmists: Abzan Eldrazi Taxes (WBG)
#18 phokmeup: Heliod Combo (WG)
#19 BrianAMarx: Niv To Light (WUBRG)
#20 ContraEgo: Thopter Urza (UBR)
#21 jvidarte: Burn (WR, Lurrus)
#22 Simarisu: Selective Oracle (WU)
#23 futureshok: Abzan Midrange (WBG)
#24 Mateusf34: E Tron (C)
#25 osmanozguney: Rakdos Midrange (BR)
#26 AnxiousHippo: Obosh Aggro (R, Obosh)
#27 Jedermann: Snoop Goblins (BR)
#28 HouseOfManaMTG: Amulet Titan (UBRG)
#29 giftshop: Serum Powder Eldrazi (R)
#30 mw_94gA: Bant Spirits (WUG)
#31 monkie: Grixis Shadow (UBR)
#32 ElectricBob: Mono White Taxes (W)
#33 Iburakema: Boros Land Destruction (WR)
#34 maple049: Hardened Scales (WG)
#35 AlpInco: Omnath Saheeli (WURG, Jegantha)
#36 calexa: KGC Tron (G)
#37 DDMeelow: Uroza (UBG)
#38 MlckyB: Bogles (WG)
#39 jonazo: Izzet Control (UR)
#40 moosedroppings: Heliod Combo (WG)
#41 yumad3988: Jund Shadow (BRG)
#42 gamemaker: Oops All Spells (WUBG)
#43 Xenowan: Neobrand (UG)
#44 Curryvore: Azorius Control (WU, Yorion)
#45 Lachuer: Dredge (BRG)
#46 Va1kyrie099: Boros Midrange (WR)
#47 Jack_Kashtan: Ad Nauseam (WUB)
#48 Pilototo: Jund Shadow (BRG)
#49 ragnarboy: Infect (BG)
#50 Sam_Lewin: Boros Land Destruction (WUR)
#51 Gods_Shadow: White Devotion (W)
#52 Zerito: Rakdos Midrange (BR)
#53 Fatcaster_Mage: Sultai Control (UBG)
#54 A22en: Taking Turns (WURG)
#55 Rebus8: Azorius Taxes (WU)
#56 TuggaNaxos: Izzet Control (UR)
#57 Rakdos91: Hardened Scales (G)
#58 aspiringspike: Jeskai Control (WUR)
#59 BSK_hercules: Jund Midrange (BRG)
#60 hugofreitas1: Gifts Storm (UR)
#61 Alan07: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_10_23 : EventTest
    {
        [Test]
        public void Deck01_Endermeap_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",0),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-10-23",1),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_LooseLois65_GrixisControl_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-23",2),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_darthjacen_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_SHUANEEHOG_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-10-23",4),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_yPrincipe_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_bobthedog_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-23",6),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_flatnose_Merfolk_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-23",7),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck09_remf_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",8),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck10_bantislove_ReclaimerTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",9),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck11_DukeVitro_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",10),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck12_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-23",11),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck13_MrSeri_HeliodCombo_W()
        {
            Test(
                GetDeck("modern-league-2020-10-23",12),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck14_moralmar_HeliodDevoted_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",13),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck15_Chipsoss_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-23",14),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_thel0stb0y_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",15),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_seasonofmists_AbzanEldraziTaxes_WBG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",16),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck18_phokmeup_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",17),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck19_BrianAMarx_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",18),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",19),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-23",20),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_Simarisu_SelectiveOracle_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-23",21),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(SelectiveOracle),
                null,
                null
            );
        }

        [Test]
        public void Deck23_futureshok_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",22),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-10-23",23),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck25_osmanozguney_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",24),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_AnxiousHippo_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-10-23",25),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck27_Jedermann_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",26),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck28_HouseOfManaMTG_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",27),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck29_giftshop_SerumPowderEldrazi_R()
        {
            Test(
                GetDeck("modern-league-2020-10-23",28),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(SerumPowderEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck30_mw94gA_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",29),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck31_monkie_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",30),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck32_ElectricBob_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-10-23",31),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Iburakema_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",32),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosLandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck34_maple049_HardenedScales_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",33),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck35_AlpInco_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-23",34),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck36_calexa_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-10-23",35),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck37_DDMeelow_Uroza_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",36),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck38_MlckyB_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",37),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck39_jonazo_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",38),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck40_moosedroppings_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",39),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck41_yumad3988_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",40),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck42_gamemaker_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",41),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Xenowan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",42),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Curryvore_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-23",43),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck45_Lachuer_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",44),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Va1kyrie099_BorosMidrange_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",45),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_JackKashtan_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-10-23",46),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Pilototo_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",47),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck49_ragnarboy_Infect_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",48),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck50_SamLewin_BorosLandDestruction_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",49),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(BorosLandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck51_GodsShadow_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-league-2020-10-23",50),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Zerito_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",51),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck53_FatcasterMage_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",52),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck54_A22en_TakingTurns_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",53),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck55_Rebus8_AzoriusTaxes_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-23",54),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck56_TuggaNaxos_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",55),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck57_Rakdos91_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-10-23",56),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck58_aspiringspike_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",57),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck59_BSKhercules_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-23",58),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck60_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",59),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck61_Alan07_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-23",60),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
