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
#02 yneves: Gruul Midrange (RG)
#03 RRozanski: Rakdos Midrange (BR)
#04 Kzrds: Izzet Prowess (UR)
#05 bozo2112: Snoop Goblins (BR)
#06 derramedefogo: Gifts Storm (UR)
#07 manu_chao: Temur Control (URG)
#08 Tsius: Dredge (WBRG)
#09 CrusherBotBG: Hammer Time (W)
#10 Zebrah: Humans (WUBRG)
#11 Kurusu: Kiki Chord (WRG, Yorion)
#12 markchalice: Mono Red Prowess (R)
#13 azax: Neobrand (UG)
#14 Kk-: Orzhov Eldrazi Taxes (WB)
#15 GoblinK1ng: Goblins (BRG)
#16 Karhusaatana: Bogles (WG)
#17 Cantergiani: Selenya Eldrazi Taxes (WG)
#18 Parrit: Hardened Scales (G)
#19 tylerjjobrien: Niv To Light (WUBRG, Yorion)
#20 armstrong36: Abzan Midrange (WBG)
#21 osmanozguney: Smallpox (B)
#22 bigjc00: Amulet Titan (URG)
#23 dani_chad: Jund Midrange (BRG)
#24 DaSneakyPete: Ad Nauseam (WUB)
#25 _Cygnus: Tokens (WB)
#26 Do0mSwitch: Bant Control (WUG)
#27 Chaughey: Jeskai Delver (WUR)
#28 sydneydude: Boros Prowess (WR)
#29 .//Automaton: Golgari Elves (BG)
#30 MartinezDP: Simic Control (UG, Yorion)
#31 Mathieu23: Azorius Control (WU)
#32 konoyubitomare15: Heliod Combo (WG)
#33 SpicyLeche: Crabvine (UBG)
#34 hkavery: WURG Control (WURG)
#35 Delthar: Infect (BG)
#36 fpawlusz: Reclaimer Titan (WRG)
#37 toya: Rakdos Midrange (BR, Lurrus)
#38 brancusi: Grixis Shadow (UBR)
#39 HannoLee: Temur Superfriends (URG)
#40 Elad_Win: Jeskai Control (WUR)
#41 Darzyn: Bant Midrange (WUG)
#42 asihtos: Primeval Titan (URG)
#43 bobthyllama2: Rakdos Prowess (BR, Lurrus)
#44 sepomon: Smallpox (WB)
#45 Drakanar: Merfolk (UG)
#46 ocelot823: Azorius Midrange (WU)
#47 voodookick: Sultai Reclamation (UBG)
#48 Galanator: Dimir Control (UB)
#49 jmeyer2030: Izzet Control (UR)
#50 MagicDevil666: U Tron (U)
#51 MrJayngles: Red Prison (RG)
#52 Nis2a: Mono White Eldrazi Taxes (W)
#53 TheDogFish: Merfolk (WU, Lurrus)
#54 shiven djinn: Obosh Aggro (R, Obosh)
#55 AngledLuffa: Lantern (UBG)
#56 AbelMolto: Burn (WRG)
#57 cntrlfreak: UBRG Shadow (UBRG)
#58 Grisel_Dad: E Tron (C)
#59 JMAK2000: KGC Tron (G)
#60 Luzur: Sultai Control (UBG)
#61 SlayItWithRoses: Elementals (WUBRG)
#62 _Logic_: Bant Blink (WUG)
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
        public void Deck02_yneves_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",1),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
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
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Kzrds_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_bozo2112_SnoopGoblins_BR()
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
                typeof(GenericControl),
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
        public void Deck12_markchalice_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-08-07",11),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
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
        public void Deck14_Kk_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-07",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
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
        public void Deck17_Cantergiani_SelenyaEldraziTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
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
        public void Deck19_tylerjjobrien_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-07",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_armstrong36_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
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
        public void Deck22_bigjc00_AmuletTitan_URG()
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
        public void Deck23_danichad_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",22),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
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
        public void Deck26_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Chaughey_JeskaiDelver_WUR()
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
        public void Deck28_sydneydude_BorosProwess_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Automaton_GolgariElves_BG()
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
        public void Deck30_MartinezDP_SimicControl_UG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-07",29),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_Mathieu23_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-07",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
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
        public void Deck34_hkavery_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
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
        public void Deck36_fpawlusz_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",35),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
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
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck38_brancusi_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",37),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
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
        public void Deck40_EladWin_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
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
                typeof(GenericMidrange),
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
        public void Deck43_bobthyllama2_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-07",42),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
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
        public void Deck46_ocelot823_AzoriusMidrange_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-07",45),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_voodookick_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",46),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
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
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_jmeyer2030_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-07",48),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
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
        public void Deck52_Nis2a_MonoWhiteEldraziTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-08-07",51),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
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
        public void Deck54_shivendjinn_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-08-07",53),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
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
        public void Deck57_cntrlfreak_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",56),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
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
        public void Deck59_JMAK2000_KGCTron_G()
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
        public void Deck60_Luzur_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-07",59),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
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
                typeof(GenericBlink),
                null,
                null
            );
        }


    }
}
