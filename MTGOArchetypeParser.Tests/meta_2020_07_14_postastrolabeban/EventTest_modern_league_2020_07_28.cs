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
#01 Tarmofir3: Jund (BRG)
#02 MadMaxErnst: WildernessReclamation (UBG)
#03 Nickburch13: Burn (WR, Lurrus)
#04 MrJayngles: RedPrison (R)
#05 babamm: IzzetRestoreBalance (URG)
#06 umeboshijiisan: SnoopGoblins (WBR)
#07 koji1130: ETron (C)
#08 Werebere: IncineratorBurn (WR)
#09 Cherryxman: TakingTurns (URG)
#10 Rhaikou: Dredge (WBRG)
#11 Yooisa: Infect (UG)
#12 Galanator: IzzetControl (UR)
#13 jvidarte: DeathAndTaxes (WU)
#14 Darkonekosuke: TraverseShadow (UBRG)
#15 GabbaGandalf: SnowBlade (WUG)
#16 sceen: Prowess (R)
#17 fgfonseca182: Ponza (RG)
#18 r0cknati0n: SnowControl (UBG)
#19 shine0905: GyrudaStompy (BRG, Gyruda)
#20 mell0n: SnowBlade (WUG)
#21 MHayashi: RedDeckWins (R, Obosh)
#22 RodolfoSFD0: TitanShift (RG)
#23 77dolltoll: BlueLivingEnd (URG)
#24 Hampuse1: DiceFactoryTron (C)
#25 NuBlkAu: IzzetProwess (UR)
#26 fatkiddestroyers: SnowBlade (WUG)
#27 Samlg01: KGCAmuletTitan (WUBRG)
#28 Fluorspar: Humans (WUBRG)
#29 _Logic_: MarduShadow (WBR)
#30 HandsomeValley: TemurControl (URG)
#31 Zyrnak: BantMidrange (WUG)
#32 GoldenKid24K: KGCTron (G)
#33 BabaBaws94: Prowess (WR, Lurrus)
#34 Mr_Box: Rock (BG)
#35 Chaughey: JeskaiDelver (WUR)
#36 Kuhb: GiftsStorm (UR)
#37 AsturianDreams: Bogles (WG)
#38 andresambiaze: HardenedScales (G)
#39 Bangood: ThopterUrza (UBR)
#40 GoblinK1ng: Goblins (BRG)
#41 Keggers: SnowReclamation (UBG)
#42 ForThoseWhoHaveHeart: SuicideShadow (BRG, Lurrus)
#43 ScreenwriterNY: DeathAndTaxes (WU)
#44 E-GirlUWU: SnoopGoblins (BR)
#45 gabsr: Crabvine (UBRG)
#46 WingedHussar: Neobrand (UG)
#47 gimmeblood: RakdosProwess (WBR, Lurrus)
#48 Asoen: RakdosMidrange (BR)
#49 wowqqqa: GrixisShadow (UBR)
#50 MHayashi: Merfolk (U)
#51 DarkKeeper: Scapeshift (URG)
#52 zbishop: DeathAndTaxes (W)
#53 Busterbrown52: Elementals (WUBRG)
#54 Madvilla1ny: WildernessReclamation (WUG)
#55 takutin09007: BushwhackerZoo (WRG)
#56 Metcalf23: DeathAndTaxes (WR)
#57 konoyubitomare15: HeliodCombo (WG)
#58 _VFS_: DimirControl (UB)
#59 cftsoc3: BantBlink (WUG)
#60 Curryvore: AzoriusControl (WU, Yorion)
#61 ColeUv: RakdosMidrange (BR, Lurrus)
#62 FANFARRAO: Elves (G)
#63 Enigma01: Merfolk (U)
#64 junghans: Devoted (WRG)
#65 cypriankrzysztof: Ponza (RG)
#66 xXLogosXx: TemurSnow (URG)
#67 mac121711: JeskaiStoneblade (WUR)
#68 MTG-Maestro: SaheeliCombo (WUR)
#69 ragingpikey: Spirits (WU)
#70 Mistakenn: AmuletTitan (URG)
#71 Metcalf23: DeathAndTaxes (WR, Yorion)
#72 CanadianNinja: BringToNiv (WUBRG, Yorion)
#73 eastonmd21: AzoriusStoneblade (WU)
#74 Fat_Chocobo: Jund (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_07_28 : EventTest
    {
        [Test]
        public void Deck01_Tarmofir3_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",0),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck02_MadMaxErnst_WildernessReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Nickburch13_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-28",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_MrJayngles_RedPrison_R()
        {
            Test(
                GetDeck("modern-league-2020-07-28",3),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck05_babamm_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",4),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck06_umeboshijiisan_Goblins_SnoopGoblins_WBR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck07_koji1130_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-28",6),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Werebere_Burn_IncineratorBurn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck09_Cherryxman_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",8),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Rhaikou_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Yooisa_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",10),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Galanator_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_jvidarte_DeathAndTaxes_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-28",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Darkonekosuke_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck15_GabbaGandalf_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck16_sceen_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-28",15),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck17_fgfonseca182_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",16),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck18_r0cknati0n_SnowControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_shine0905_GyrudaStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-07-28",18),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GyrudaStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck20_mell0n_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck21_MHayashi_RedDeckWins_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-07-28",20),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck22_RodolfoSFD0_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",21),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck23_77dolltoll_LivingEnd_BlueLivingEnd_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",22),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(LivingEnd),
                typeof(BlueLivingEnd),
                null
            );
        }

        [Test]
        public void Deck24_Hampuse1_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-28",23),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(DiceFactoryTron),
                null,
                null
            );
        }

        [Test]
        public void Deck25_NuBlkAu_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",24),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck26_fatkiddestroyers_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck27_Samlg01_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck28_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Logic_DeathsShadow_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(DeathsShadow),
                typeof(MarduShadow),
                null
            );
        }

        [Test]
        public void Deck30_HandsomeValley_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",29),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TemurControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Zyrnak_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_GoldenKid24K_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-28",31),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck33_BabaBaws94_Prowess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-28",32),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck34_MrBox_Rock_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",33),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Chaughey_Delver_JeskaiDelver_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(Delver),
                typeof(JeskaiDelver),
                null
            );
        }

        [Test]
        public void Deck36_Kuhb_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",35),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck37_AsturianDreams_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck38_andresambiaze_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-07-28",37),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Bangood_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",38),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck40_GoblinK1ng_Goblins_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",39),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Keggers_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",40),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck42_ForThoseWhoHaveHeart_DeathsShadow_SuicideShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-28",41),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(SuicideShadow),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck43_ScreenwriterNY_DeathAndTaxes_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-28",42),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck44_EGirlUWU_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",43),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck45_gabsr_Crabvine_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",44),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck46_WingedHussar_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",45),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck47_gimmeblood_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-28",46),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck48_Asoen_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",47),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck49_wowqqqa_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",48),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck50_MHayashi_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-07-28",49),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck51_DarkKeeper_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",50),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck52_zbishop_DeathAndTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-28",51),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Busterbrown52_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",52),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck54_Madvilla1ny_WildernessReclamation_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",53),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck55_takutin09007_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",54),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Metcalf23_DeathAndTaxes_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",55),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck57_konoyubitomare15_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",56),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck58_VFS_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-28",57),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(DimirControl),
                null,
                null
            );
        }

        [Test]
        public void Deck59_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",58),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck60_Curryvore_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-28",59),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck61_ColeUv_RakdosMidrange_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-28",60),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck62_FANFARRAO_Elves_G()
        {
            Test(
                GetDeck("modern-league-2020-07-28",61),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Elves),
                null,
                null
            );
        }

        [Test]
        public void Deck63_Enigma01_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-07-28",62),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck64_junghans_Devoted_WRG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",63),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck65_cypriankrzysztof_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",64),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck66_xXLogosXx_SnowControl_TemurSnow_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",65),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(TemurSnow),
                null
            );
        }

        [Test]
        public void Deck67_mac121711_JeskaiControl_JeskaiStoneblade_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",66),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                typeof(JeskaiStoneblade),
                null
            );
        }

        [Test]
        public void Deck68_MTGMaestro_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-28",67),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck69_ragingpikey_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-28",68),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck70_Mistakenn_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",69),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck71_Metcalf23_DeathAndTaxes_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-28",70),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck72_CanadianNinja_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-28",71),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck73_eastonmd21_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-28",72),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck74_FatChocobo_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-28",73),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }


    }
}
