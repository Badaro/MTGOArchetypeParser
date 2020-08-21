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
#01 CordoTwin: Crabvine (UBG)
#02 ThePurpleMage: HeliodDevoted (WBG)
#03 harukispecial: SultaiSnow (UBG)
#04 Wite1: Prowess (WR)
#05 SIMONEFIERRO: Dredge (UBRG)
#06 Piccio36: GyrudaStompy (BRG, Gyruda)
#07 Andreas_Mueller: RakdosProwess (BR, Lurrus)
#08 ThekingFor1000years: Infect (UG)
#09 RodolfoSFD0: TitanShift (RG)
#10 katobu: HeliodCombo (WG)
#11 sondrak: NayaMidrange (WRG)
#12 Asoen: RakdosMidrange (BR)
#13 rodebo: UTron (U)
#14 DeepFrdKirby: Slivers (WUBRG)
#15 Sideshowsc: Scapeshift (WURG)
#16 crackerpack: SolemnityCombo (WB)
#17 Mordeka1ser: BringToNiv (WUBRG, Yorion)
#18 Predicted: Yawgmoth (WBG)
#19 SquidNips: IzzetLivingEnd (UR)
#20 FakeFrog: Humans (WUBRG)
#21 Killabee: AzoriusControl (WU)
#22 Hiyori9: Jund (BRG)
#23 ImmanuelKantrolGod: AzoriusStoneblade (WU)
#24 Doni_Dominaria: Bogles (WG)
#25 Shorak123: SnowReclamation (UBG)
#26 Fluffypingo: KGCTron (G)
#27 TheStapler: OrzhovTokens (WB)
#28 Xenowan: HardenedScales (G)
#29 MagicEd: TraverseShadow (BRG)
#30 Moments_Peace: EldraziTaxes (WB)
#31 Lenneth: MarduMidrange (WBR)
#32 shiven djinn: RedDeckWins (R, Obosh)
#33 fatkiddestroyers: SnowBlade (WUG)
#34 Metcalf23: DeathAndTaxes (WR, Yorion)
#35 SKAIANET: EsperMidrange (WUB)
#36 kengaigen: LivingEnd (BRG)
#37 katoriarch123: BantControl (WUG)
#38 AngledLuffa: BantMidrange (WUG)
#39 Callad0: PrimevalTitan (URG)
#40 timewalkinonsunshine: TakingTurns (URG)
#41 crussedull: Rock (WBG)
#42 StripMineBen: Ponza (RG)
#43 SvenSveeterSven: IzzetControl (UR)
#44 paucr5: DeathAndTaxes (WU)
#45 Tar_Heels_82: IncineratorBurn (R)
#46 bershekprc10: Burn (WR)
#47 fradelrock: ETron (C)
#48 manu_chao: TemurControl (URG)
#49 BlueLips: BantControl (WUG)
#50 erose199423: Crabvine (UBG)
#51 10189011: GrixisShadow (UBR)
#52 coert: DeathAndTaxes (W)
#53 ScreenwriterNY: DeathAndTaxes (WU)
#54 ripcalibretto13: Prowess (R)
#55 Max315: Merfolk (U)
#56 bigjc00: AmuletTitan (URG)
#57 cypriankrzysztof: Scapeshift (URG)
#58 bcs8995: SultaiControl (UBG)
#59 Matte8pt: GiftsStorm (UR)
#60 junghans: Devoted (WRG)
#61 Pmizz: IzzetProwess (UR)
#62 DoctorQueller: BantSpirits (WUG)
#63 ice_nine_: BorosPrison (WR)
#64 anamika: Elementals (WUBRG)
#65 brainstorm39: JeskaiControl (WUR, Yorion)
#66 JimmySetzer: SnoopGoblins (BR)
#67 basebuilder: AdNauseam (WUB)
#68 Valyan: Rock (WBG)
#69 TuggaNaxos: ToothAndNail (G)
#70 kokoko098: HeliodDevoted (WUG, Lurrus)
#71 monkeyang: IzzetPhoenix (UR)
#72 m_joe: BantBlink (WUBG)
#73 ilton: DimirControl (UB)
#74 Curveiganhei: ThopterUrza (UBR)
#75 Nikachu: Merfolk (UG)
#76 hizakura: Polymorph (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_08_04 : EventTest
    {
        [Test]
        public void Deck01_CordoTwin_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",0),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck02_ThePurpleMage_Devoted_HeliodDevoted_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck03_harukispecial_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck04_Wite1_Prowess_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_SIMONEFIERRO_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Piccio36_GyrudaStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-08-04",5),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GyrudaStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck07_AndreasMueller_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-04",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_ThekingFor1000years_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck09_RodolfoSFD0_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",8),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck10_katobu_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_sondrak_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(NayaMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Asoen_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",11),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_rodebo_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-08-04",12),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck14_DeepFrdKirby_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Sideshowsc_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck16_crackerpack_SolemnityCombo_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-04",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(SolemnityCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Mordeka1ser_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-04",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Predicted_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck19_SquidNips_IzzetFreeSpells_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetLivingEnd),
                null
            );
        }

        [Test]
        public void Deck20_FakeFrog_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Killabee_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-04",20),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Hiyori9_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",21),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck23_ImmanuelKantrolGod_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-04",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck24_DoniDominaria_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Shorak123_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",24),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck26_Fluffypingo_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-08-04",25),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck27_TheStapler_Tokens_OrzhovTokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-04",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                typeof(OrzhovTokens),
                null
            );
        }

        [Test]
        public void Deck28_Xenowan_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-08-04",27),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck29_MagicEd_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",28),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck30_MomentsPeace_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-04",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck31_Lenneth_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(MarduMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_shivendjinn_RedDeckWins_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-08-04",31),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck33_fatkiddestroyers_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",32),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck34_Metcalf23_DeathAndTaxes_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-04",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck35_SKAIANET_EsperMidrange_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-04",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(EsperMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck36_kengaigen_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",35),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck37_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck38_AngledLuffa_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",37),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Callad0_PrimevalTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",38),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck40_timewalkinonsunshine_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",39),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck41_crussedull_Rock_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",40),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck42_StripMineBen_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",41),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck43_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",42),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck44_paucr5_DeathAndTaxes_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-04",43),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck45_TarHeels82_Burn_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-08-04",44),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck46_bershekprc10_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",45),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck47_fradelrock_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-08-04",46),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck48_manuchao_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",47),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TemurControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_BlueLips_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck50_erose199423_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",49),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck51_10189011_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",50),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck52_coert_DeathAndTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-08-04",51),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck53_ScreenwriterNY_DeathAndTaxes_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-04",52),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck54_ripcalibretto13_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-08-04",53),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck55_Max315_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-08-04",54),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck56_bigjc00_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",55),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck57_cypriankrzysztof_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",56),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck58_bcs8995_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",57),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SultaiControl),
                null,
                null
            );
        }

        [Test]
        public void Deck59_Matte8pt_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",58),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck60_junghans_Devoted_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",59),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck61_Pmizz_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",60),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck62_DoctorQueller_Spirits_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",61),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck63_icenine_BorosPrison_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",62),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(BorosPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck64_anamika_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",63),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck65_brainstorm39_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-04",64),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck66_JimmySetzer_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",65),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck67_basebuilder_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-04",66),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck68_Valyan_Rock_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",67),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck69_TuggaNaxos_ToothAndNail_G()
        {
            Test(
                GetDeck("modern-league-2020-08-04",68),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(ToothAndNail),
                null,
                null
            );
        }

        [Test]
        public void Deck70_kokoko098_Devoted_HeliodDevoted_WUG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-04",69),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck71_monkeyang_IzzetPhoenix_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",70),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetPhoenix),
                null,
                null
            );
        }

        [Test]
        public void Deck72_mjoe_BantBlink_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",71),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBG,
                typeof(BantBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck73_ilton_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-08-04",72),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(DimirControl),
                null,
                null
            );
        }

        [Test]
        public void Deck74_Curveiganhei_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-04",73),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck75_Nikachu_Merfolk_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",74),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck76_hizakura_Polymorph_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-04",75),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Polymorph),
                null,
                null
            );
        }


    }
}
