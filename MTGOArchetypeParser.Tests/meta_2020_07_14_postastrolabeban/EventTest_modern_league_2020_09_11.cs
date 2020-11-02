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
#01 Kerrick_: Eight Rack (B)
#02 ragingpikey: Spirits (WU)
#03 AndersPovirk: Dredge (WBRG)
#04 junior97: Rakdos Midrange (BR)
#05 Boin: Burn (WR, Lurrus)
#06 DarkKeeper: Bant Control (WUG)
#07 POC: Infect (BG, Lurrus)
#08 rastaf: Bogles (WG, Lurrus)
#09 bobthyllama2: Heliod Combo (WG)
#10 Wolfie98: Primeval Titan (URG)
#11 yPrincipe: E Tron (C)
#12 ROBINMASK: U Tron (U)
#13 AJV20: Grixis Shadow (UBR)
#14 harukispecial: Jeskai Control (WUR)
#15 kokoko098: Heliod Devoted (WBG)
#16 Granham: KGC Tron (G)
#17 Middeterminist: Simic Reclamation (UG)
#18 MagikarpTheDeity: Infect (UG)
#19 Janh: Sultai Control (UBG)
#20 lawrencer12: Jund Midrange (BRG)
#21 GingerAllanPoe: Boros Prowess (WR, Lurrus)
#22 PuntThenWhine: KGC Amulet Titan (WUBRG)
#23 Irkus: Ad Nauseam (WUB)
#24 Mistakenn: Amulet Titan (URG)
#25 Parrit: Mono White Taxes (W)
#26 sicsmoo: Temur Control (URG)
#27 _Stream: Grixis Prowess (UBR)
#28 B1gDan: Jund Shadow (BRG, Lurrus)
#29 RAINkratos: Hammer Time (W)
#30 anamika: Elementals (WUBRG)
#31 Albyz: Titan Stompy (BRG)
#32 aspiringspike: Azorius Control (WU)
#33 Pablo Figuero: Humans (WUBRG)
#34 GiovaniMF: Jund Shadow (BRG)
#35 Karlennon: Titan Shift (RG)
#36 KIMCHIMAN: Snoop Goblins (BR)
#37 K4rl1991: Hardened Scales (G)
#38 Toastxp: Rakdos Prowess (BR, Lurrus)
#39 SebastianStueckl: Gruul Midrange (RG)
#40 MatheusTetu: Izzet Prowess (UR)
#41 Sonkerz: Scapeshift (UBRG)
#42 Predicted: Yawgmoth (WBG)
#43 Masontj: Obosh Aggro (R, Obosh)
#44 chaba_lol: Hammer Time (W)
#45 Messssenger: Izzet Restore Balance (URG)
#46 WingedHussar: Neobrand (UG)
#47 Wuhsa: Niv To Light (WUBRG, Yorion)
#48 Trebz: Azorius Control (WU)
#49 abijhavs: Mono Red Prowess (R)
#50 davito: Merfolk (UG)
#51 komattaman: Gruul Midrange (RG)
#52 Kurusu: Kiki Chord (WRG, Yorion)
#53 blastoids: Uroza (WUG)
#54 MHayashi: Merfolk (U)
#55 hermanomlg: Golgari Midrange (BG)
#56 Ivc: Azorius Control (WU)
#57 bwheezy: Jeskai Control (WUR)
#58 LeonardoBeghine: Golgari Elves (BG)
#59 Iwouldliketorespond: Taking Turns (UR)
#60 scenekiid: Reclaimer Titan (WRG)
#61 mikel88888888: Taking Turns (URG)
#62 LORiWWA: Gifts Storm (UR)
#63 Jrcitizen: Izzet Phoenix (UR)
#64 Curtisaxel: U Tron (U)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_09_11 : EventTest
    {
        [Test]
        public void Deck01_Kerrick_EightRack_B()
        {
            Test(
                GetDeck("modern-league-2020-09-11",0),
                new PostAstrolabeBan(),
                ArchetypeColor.B,
                typeof(EightRack),
                null,
                null
            );
        }

        [Test]
        public void Deck02_ragingpikey_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-11",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck03_AndersPovirk_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_junior97_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-11",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Boin_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-11",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_DarkKeeper_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_POC_Infect_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-11",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_rastaf_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-11",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_bobthyllama2_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Wolfie98_PrimevalTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",9),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck11_yPrincipe_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-09-11",10),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ROBINMASK_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-09-11",11),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck13_AJV20_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-11",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck14_harukispecial_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-09-11",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_kokoko098_HeliodDevoted_WBG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck16_Granham_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-09-11",15),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck17_Middeterminist_SimicReclamation_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck18_MagikarpTheDeity_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Janh_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_lawrencer12_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",19),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_GingerAllanPoe_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-11",20),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_PuntThenWhine_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck23_Irkus_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-09-11",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Mistakenn_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",23),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck25_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-09-11",24),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck26_sicsmoo_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",25),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Stream_GrixisProwess_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-11",26),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck28_B1gDan_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-11",27),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_RAINkratos_HammerTime_W()
        {
            Test(
                GetDeck("modern-league-2020-09-11",28),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck30_anamika_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Albyz_TitanStompy_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(TitanStompy),
                null,
                null
            );
        }

        [Test]
        public void Deck32_aspiringspike_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-11",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_PabloFiguero_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",32),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck34_GiovaniMF_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",33),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Karlennon_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",34),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck36_KIMCHIMAN_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-11",35),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck37_K4rl1991_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-09-11",36),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Toastxp_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-11",37),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck39_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",38),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck40_MatheusTetu_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-11",39),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Sonkerz_Scapeshift_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",40),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Predicted_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Masontj_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-09-11",42),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck44_chabalol_HammerTime_W()
        {
            Test(
                GetDeck("modern-league-2020-09-11",43),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Messssenger_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",44),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck46_WingedHussar_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",45),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Wuhsa_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-11",46),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck48_Trebz_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-11",47),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_abijhavs_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-09-11",48),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck50_davito_Merfolk_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",49),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck51_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",50),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-11",51),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck53_blastoids_Uroza_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",52),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck54_MHayashi_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-09-11",53),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck55_hermanomlg_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",54),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-11",55),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck57_bwheezy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-09-11",56),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck58_LeonardoBeghine_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",57),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck59_Iwouldliketorespond_TakingTurns_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-11",58),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck60_scenekiid_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",59),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck61_mikel88888888_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-11",60),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck62_LORiWWA_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-11",61),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck63_Jrcitizen_IzzetPhoenix_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-11",62),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetPhoenix),
                null,
                null
            );
        }

        [Test]
        public void Deck64_Curtisaxel_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-09-11",63),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }


    }
}
