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
#01 FreshKale: Izzet Prowess (UR)
#02 Jedermann: Snoop Goblins (BR)
#03 busso9494: Izzet Restore Balance (URG)
#04 Tarmofir3: Golgari Midrange (BG)
#05 JMoney8771: Infect (UG)
#06 White_Fish: Grixis Shadow (UBR)
#07 AZN7: Amulet Titan (WURG)
#08 twilightSSparkle: Neobrand (WUG)
#09 Parrit: Hardened Scales (BG, Lurrus)
#10 Termahgerf: Uroza (WUG, Yorion)
#11 Ennuixd: UBRG Shadow (UBRG)
#12 Ayzkub_: UBRG Control (UBRG)
#13 ArchaeusDota: Green Eldrazi Tron (G)
#14 MrJayngles: Red Prison (R)
#15 equites: Incinerator Burn (R)
#16 UrbanPope: Rakdos Prowess (BR, Lurrus)
#17 number1pwnr: U Tron (U)
#18 rojanosa: Orzhov Tokens (WB)
#19 mikey_g43: Bant Midrange (WUG)
#20 Kotva: Ninja Faeries (UB)
#21 gazmon48: Izzet Prowess (UR)
#22 zMunkeyXz: Mill (UBG)
#23 TheDogFish: Merfolk (UG)
#24 Metcalf23: Boros Taxes (WR, Lurrus)
#25 Asoen: Rakdos Midrange (BR)
#26 maear: Izzet Control (UR)
#27 JFK_Defied_Bolas: Martyr Proc (W)
#28 B4nn3D22: Snoop Goblins (BR)
#29 umeboshijiisan: Snoop Goblins (WBR)
#30 RENDGT: WURG Control (WURG, Yorion)
#31 MegaMollt: Gifts Storm (UR)
#32 TheWonderLord: Golgari Midrange (BG)
#33 Boin: Snoop Goblins (BR)
#34 ArchaeusDota: E Tron (BG)
#35 ToniCalzoni: Ad Nauseam (WUB)
#36 andresambiaze: Dredge (BRG)
#37 Janh: Scapeshift (URG, Yorion)
#38 freneticefreet: Gruul Midrange (RG)
#39 CloakedAlvis: G Tron (G)
#40 Musagete: Orzhov Eldrazi Taxes (WB)
#41 mac121711: Sultai Control (UBG)
#42 DFrank: Thopter Urza (WUB)
#43 Doni_Dominaria: Incinerator Burn (BR)
#44 Jiggywiggy: Kinnan Legends (WURG, Yorion)
#45 Trellon: U Tron (U)
#46 kensportsfan: Mono Red Prowess (R)
#47 Taracogenius: Titan Shift (RG)
#48 TscheggschDePoegg: Temur Control (URG)
#49 Ivan1227: Azorius Control (WU)
#50 musasabi: Jund Smallpox (BRG)
#51 Brunister: Dredge (WBR)
#52 Mad-Ramon: Temur Reclamation (URG, Yorion)
#53 osk4: Niv To Light (WUBRG, Yorion)
#54 BanjoCaveman: Polymorph (RG)
#55 kumuhl00: Elementals (WUBRG)
#56 TBagTom: UBRG Control (UBRG)
#57 RealJoy: Jund Shadow (BRG)
#58 albert62: Jund Midrange (BRG)
#59 Joao_Andrade: Mono Red Prowess (R, Jegantha)
#60 SeventhProphet: Uroza (URG)
#61 TuggaNaxos: Temur Midrange (URG)
#62 victgobra10: Burn (WR)
#63 yutya: Bant Control (WUG, Yorion)
#64 Simpleliquid: Humans (WUBRG)
#65 sten626: Devoted (WG, Lurrus)
#66 Traft: WURG Control (WURG)
#67 gogogadgetblunt: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_league_2020_07_07 : EventTest
    {
        [Test]
        public void Deck01_FreshKale_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",0),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Jedermann_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",1),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck03_busso9494_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",2),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck04_Tarmofir3_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",3),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_JMoney8771_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",4),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_WhiteFish_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",5),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck07_AZN7_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",6),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_twilightSSparkle_Neobrand_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",7),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Parrit_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-07",8),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Termahgerf_Uroza_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",9),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_Ennuixd_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",10),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Ayzkub_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",11),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_ArchaeusDota_GreenEldraziTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-07",12),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(GreenEldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_MrJayngles_RedPrison_R()
        {
            Test(
                GetDeck("modern-league-2020-07-07",13),
                new PostM21(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck15_equites_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-07-07",14),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck16_UrbanPope_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-07",15),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_number1pwnr_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-07",16),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck18_rojanosa_OrzhovTokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-07",17),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(Tokens),
                typeof(OrzhovTokens),
                null
            );
        }

        [Test]
        public void Deck19_mikeyg43_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",18),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Kotva_NinjaFaeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-07",19),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(NinjaFaeries),
                null,
                null
            );
        }

        [Test]
        public void Deck21_gazmon48_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",20),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck22_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",21),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck23_TheDogFish_Merfolk_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",22),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Metcalf23_BorosTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-07",23),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Asoen_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",24),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_maear_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",25),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_JFKDefiedBolas_MartyrProc_W()
        {
            Test(
                GetDeck("modern-league-2020-07-07",26),
                new PostM21(),
                ArchetypeColor.W,
                typeof(MartyrProc),
                null,
                null
            );
        }

        [Test]
        public void Deck28_B4nn3D22_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",27),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck29_umeboshijiisan_SnoopGoblins_WBR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",28),
                new PostM21(),
                ArchetypeColor.WBR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck30_RENDGT_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",29),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_MegaMollt_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",30),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck32_TheWonderLord_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",31),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Boin_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",32),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck34_ArchaeusDota_ETron_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",33),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck35_ToniCalzoni_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-07",34),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck36_andresambiaze_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",35),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Janh_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",36),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck38_freneticefreet_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",37),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck39_CloakedAlvis_GTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-07",38),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Musagete_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-07",39),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck41_mac121711_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",40),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck42_DFrank_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-07",41),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck43_DoniDominaria_IncineratorBurn_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",42),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck44_Jiggywiggy_KinnanLegends_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",43),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(KinnanLegends),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck45_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-07",44),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck46_kensportsfan_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-07",45),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Taracogenius_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",46),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck48_TscheggschDePoegg_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",47),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Ivan1227_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-07",48),
                new PostM21(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck50_musasabi_JundSmallpox_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",49),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(JundSmallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Brunister_Dredge_WBR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",50),
                new PostM21(),
                ArchetypeColor.WBR,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck52_MadRamon_TemurReclamation_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",51),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck53_osk4_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",52),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck54_BanjoCaveman_Polymorph_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",53),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck55_kumuhl00_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",54),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck56_TBagTom_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",55),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck57_RealJoy_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",56),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck58_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",57),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck59_JoaoAndrade_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-07",58),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck60_SeventhProphet_Uroza_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",59),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck61_TuggaNaxos_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",60),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck62_victgobra10_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-07",61),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck63_yutya_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-07",62),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck64_Simpleliquid_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",63),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck65_sten626_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-07",64),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck66_Traft_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",65),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck67_gogogadgetblunt_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-07",66),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
