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
#01 Capipf95: Burn (WR)
#02 yneves: Ponza (RG)
#03 RRozanski: RakdosMidrange (BR)
#04 Kzrds: IzzetProwess (UR)
#05 bozo2112: SnoopGoblins (BR)
#06 derramedefogo: GiftsStorm (UR)
#07 manu_chao: TemurControl (URG)
#08 Tsius: Dredge (WBRG)
#09 CrusherBotBG: HammerTime (W)
#10 Zebrah: Humans (WUBRG)
#11 Kurusu: KikiChord (WRG, Yorion)
#12 markchalice: Prowess (R)
#13 azax: Neobrand (UG)
#14 Kk-: EldraziTaxes (WB)
#15 GoblinK1ng: Goblins (BRG)
#16 Karhusaatana: Bogles (WG)
#17 Cantergiani: EldraziTaxes (WG)
#18 Parrit: HardenedScales (G)
#19 tylerjjobrien: BringToNiv (WUBRG, Yorion)
#20 armstrong36: Rock (WBG)
#21 osmanozguney: Smallpox (B)
#22 bigjc00: AmuletTitan (URG)
#23 dani_chad: Jund (BRG)
#24 DaSneakyPete: AdNauseam (WUB)
#25 _Cygnus: Tokens (WB)
#26 Do0mSwitch: SnowControl (WUG)
#27 Chaughey: JeskaiDelver (WUR)
#28 sydneydude: Prowess (WR)
#29 .//Automaton: GolgariElves (BG)
#30 MartinezDP: SnowTitan (UG, Yorion)
#31 Mathieu23: AzoriusStoneblade (WU)
#32 konoyubitomare15: HeliodCombo (WG)
#33 SpicyLeche: Crabvine (UBG)
#34 hkavery: BantControl (WURG)
#35 Delthar: Infect (BG)
#36 fpawlusz: TitanVial (WRG)
#37 toya: RakdosMidrange (BR, Lurrus)
#38 brancusi: GrixisShadow (UBR)
#39 HannoLee: TemurSuperfriends (URG)
#40 Elad_Win: JeskaiStoneblade (WUR)
#41 Darzyn: BantMidrange (WUG)
#42 asihtos: PrimevalTitan (URG)
#43 bobthyllama2: RakdosProwess (BR, Lurrus)
#44 sepomon: Smallpox (WB)
#45 Drakanar: Merfolk (UG)
#46 ocelot823: AzoriusTempo (WU)
#47 voodookick: WildernessReclamation (UBG)
#48 Galanator: DimirControl (UB)
#49 jmeyer2030: IzzetBreach (UR)
#50 MagicDevil666: UTron (U)
#51 MrJayngles: RedPrison (RG)
#52 Nis2a: EldraziTaxes (W)
#53 TheDogFish: Merfolk (WU, Lurrus)
#54 shiven djinn: RedDeckWins (R, Obosh)
#55 AngledLuffa: Lantern (UBG)
#56 AbelMolto: Burn (WRG)
#57 cntrlfreak: TraverseShadow (UBRG)
#58 Grisel_Dad: ETron (C)
#59 JMAK2000: KGCTron (G)
#60 Luzur: SultaiSnow (UBG)
#61 SlayItWithRoses: Elementals (WUBRG)
#62 _Logic_: BantBlink (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_08_07 : EventTest
    {
        [Test]
        public void Deck01_Capipf95_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck02_yneves_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",1),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck03_RRozanski_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",2),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Kzrds_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck05_bozo2112_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",4),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck06_derramedefogo_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck07_manuchao_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",6),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TemurControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Tsius_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_CrusherBotBG_HammerTime_W()
        {
            Test(
                GetDeck("modern-league-2020-08-07",8),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Zebrah_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-07",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_markchalice_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-08-07",11),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_azax_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Kk_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-07",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck15_GoblinK1ng_Goblins_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Karhusaatana_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Cantergiani_DeathAndTaxes_EldraziTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck18_Parrit_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-08-07",17),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck19_tylerjjobrien_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-07",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_armstrong36_Rock_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck21_osmanozguney_Smallpox_B()
        {
            Test(
                GetDeck("modern-league-2020-08-07",20),
                new PostAstrolabeBan(),
                ArchetypeColor.B,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck22_bigjc00_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",21),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck23_danichad_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",22),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck24_DaSneakyPete_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-07",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Cygnus_Tokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-07",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Do0mSwitch_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Chaughey_Delver_JeskaiDelver_WUR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(Delver),
                typeof(JeskaiDelver),
                null
            );
        }

        [Test]
        public void Deck28_sydneydude_Prowess_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Automaton_Elves_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",28),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck30_MartinezDP_SnowControl_SnowTitan_UG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-07",29),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(SnowControl),
                typeof(SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_Mathieu23_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-07",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck32_konoyubitomare15_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck33_SpicyLeche_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",32),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck34_hkavery_BantControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Delthar_Infect_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",34),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck36_fpawlusz_TitanVial_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",35),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(TitanVial),
                null,
                null
            );
        }

        [Test]
        public void Deck37_toya_RakdosMidrange_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-07",36),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck38_brancusi_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",37),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck39_HannoLee_TemurSuperfriends_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",38),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TemurSuperfriends),
                null,
                null
            );
        }

        [Test]
        public void Deck40_EladWin_JeskaiControl_JeskaiStoneblade_WUR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                typeof(JeskaiStoneblade),
                null
            );
        }

        [Test]
        public void Deck41_Darzyn_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",40),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck42_asihtos_PrimevalTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",41),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck43_bobthyllama2_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-07",42),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck44_sepomon_Smallpox_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-07",43),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Drakanar_Merfolk_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",44),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck46_ocelot823_AzoriusTempo_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-07",45),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusTempo),
                null,
                null
            );
        }

        [Test]
        public void Deck47_voodookick_WildernessReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",46),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Galanator_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-08-07",47),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(DimirControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_jmeyer2030_IzzetControl_IzzetBreach_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",48),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                typeof(IzzetBreach),
                null
            );
        }

        [Test]
        public void Deck50_MagicDevil666_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-08-07",49),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck51_MrJayngles_RedPrison_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",50),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Nis2a_DeathAndTaxes_EldraziTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-08-07",51),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck53_TheDogFish_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-07",52),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck54_shivendjinn_RedDeckWins_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-08-07",53),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck55_AngledLuffa_Lantern_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",54),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Lantern),
                null,
                null
            );
        }

        [Test]
        public void Deck56_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",55),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck57_cntrlfreak_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",56),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck58_GriselDad_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-08-07",57),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck59_JMAK2000_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-08-07",58),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck60_Luzur_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",59),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck61_SlayItWithRoses_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",60),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck62_Logic_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",61),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                null
            );
        }


    }
}
