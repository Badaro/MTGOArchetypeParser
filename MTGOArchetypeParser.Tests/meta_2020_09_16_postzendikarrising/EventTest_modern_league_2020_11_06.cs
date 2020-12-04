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
#01 Brunister: Azorius Taxes (WU, Yorion)
#02 iuriper: Belcher (URG)
#03 lovepsy: Heliod Combo (WG)
#04 Aczino: Obosh Aggro (R, Obosh)
#05 Amplumnox: Shadow Prowess (BR, Lurrus)
#06 cntrlfreak: Sultai Shadow (UBG)
#07 BoromirofGondor: Bant Midrange (WUG)
#08 BSK_hercules: Sultai Control (UBG)
#09 Noxae: Humans (WUBRG)
#10 TCMindsculptor: Amulet Titan (G)
#11 jacenty_b: Burn (WR)
#12 pegleg: WURG Control (WURG)
#13 RandomDrooler: Primeval Titan (URG)
#14 LeoFa: Sultai Control (UBG)
#15 MartinezDP: WURG Control (WURG, Yorion)
#16 cavedan: Zombies (WB)
#17 AlpInco: Skred Red (R)
#18 Krenca: Bant Spirits (WUG)
#19 ManPants: Jund Midrange (BRG, Lurrus)
#20 BernardoDG: Reclaimer Titan (WRG)
#21 Tarrasque1: Heliod Combo (W)
#22 stan: Orzhov Midrange (WB)
#23 SparTaNxX: Ad Nauseam (WUB)
#24 DrDree: Infect (UG)
#25 IntrepidZero: Heliod Combo (WG)
#26 Vandervecken: Izzet Prowess (UR)
#27 FriskiFraska: Titan Stompy (BRG, Gyruda)
#28 TuggaNaxos: Primeval Titan (WURG)
#29 Silence9428: Dredge (BRG)
#30 JensLund: Oops All Spells (WUBG)
#31 Jiggywiggy: Kinnan Legends (UG, Jegantha)
#32 Rakdos91: Hardened Scales (G)
#33 aspiringspike: Azorius Control (WU)
#34 maple049: Hardened Scales (RG)
#35 CrusherBotBG: Allies (WUBRG)
#36 Qoiet: E Tron (C)
#37 Atone: Azorius Taxes (WU)
#38 martindoktor: Azorius Control (WU)
#39 Riceball20: Mono Red Prowess (R)
#40 Jack_Kashtan: Izzet Control (UR)
#41 Jaberwocki: Jund Midrange (BRG)
#42 yneves: Gruul Midrange (RG)
#43 StormCount-1: Infect (UG)
#44 hugofreitas1: Gifts Storm (UR)
#45 AFX: WURG Control (WURG)
#46 jmeyer2030: Jeskai Control (WUR)
#47 rameison: KGC Tron (G)
#48 fabee1: Mono White Taxes (W)
#49 litianshuo670: Omnath Saheeli (WURG, Jegantha)
#50 SpicyLeche: Izzet Control (UR)
#51 Parrit: Orzhov Taxes (WB)
#52 DemianDesposito10: Boros Prowess (WR, Lurrus)
#53 POC: Infect (BG, Lurrus)
#54 bgoose321: Shadow Prowess (BRG, Lurrus)
#55 Gatorman: Eight Rack (WB)
#56 LewisCBR: Scapeshift (URG)
#57 SKTV: Mono White Taxes (W)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_11_06 : EventTest
    {
        [Test]
        public void Deck01_Brunister_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-06",0),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_iuriper_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",1),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck03_lovepsy_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",2),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Aczino_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-11-06",3),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck05_Amplumnox_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-06",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_cntrlfreak_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",5),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck07_BoromirofGondor_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",6),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_BSKhercules_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",7),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Noxae_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",8),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TCMindsculptor_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-league-2020-11-06",9),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck11_jacentyb_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-11-06",10),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck12_pegleg_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",11),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_RandomDrooler_PrimevalTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",12),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck14_LeoFa_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",13),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_MartinezDP_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-06",14),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_cavedan_Zombies_WB()
        {
            Test(
                GetDeck("modern-league-2020-11-06",15),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(Zombies),
                null,
                null
            );
        }

        [Test]
        public void Deck17_AlpInco_SkredRed_R()
        {
            Test(
                GetDeck("modern-league-2020-11-06",16),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(SkredRed),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Krenca_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",17),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck19_ManPants_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-06",18),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_BernardoDG_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",19),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck21_Tarrasque1_HeliodCombo_W()
        {
            Test(
                GetDeck("modern-league-2020-11-06",20),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck22_stan_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-11-06",21),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_SparTaNxX_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-11-06",22),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck24_DrDree_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",23),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck25_IntrepidZero_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",24),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Vandervecken_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-06",25),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck27_FriskiFraska_TitanStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-11-06",26),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(TitanStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck28_TuggaNaxos_PrimevalTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",27),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Silence9428_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",28),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck30_JensLund_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",29),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Jiggywiggy_KinnanLegends_UG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-11-06",30),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(KinnanLegends),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck32_Rakdos91_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-11-06",31),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck33_aspiringspike_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-06",32),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_maple049_HardenedScales_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",33),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck35_CrusherBotBG_Allies_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",34),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Allies),
                null,
                null
            );
        }

        [Test]
        public void Deck36_Qoiet_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-11-06",35),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Atone_AzoriusTaxes_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-06",36),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck38_martindoktor_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-06",37),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Riceball20_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-11-06",38),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck40_JackKashtan_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-06",39),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Jaberwocki_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",40),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck42_yneves_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",41),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck43_StormCount1_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",42),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck44_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-06",43),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck45_AFX_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",44),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck46_jmeyer2030_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-11-06",45),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_rameison_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-11-06",46),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck48_fabee1_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-11-06",47),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck49_litianshuo670_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-11-06",48),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck50_SpicyLeche_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-06",49),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Parrit_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-11-06",50),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck52_DemianDesposito10_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-06",51),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck53_POC_Infect_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-06",52),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck54_bgoose321_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-06",53),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck55_Gatorman_EightRack_WB()
        {
            Test(
                GetDeck("modern-league-2020-11-06",54),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(EightRack),
                null,
                null
            );
        }

        [Test]
        public void Deck56_LewisCBR_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-06",55),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck57_SKTV_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-11-06",56),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }


    }
}
