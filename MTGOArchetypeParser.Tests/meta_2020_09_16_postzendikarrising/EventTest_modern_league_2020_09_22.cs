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
#01 lukystrike: SelenyaTaxes (WG)
#02 DoctorQueller: BantSpirits (WUG)
#03 superaitch: Merfolk (U)
#04 UnstableJoker: Humans (WUBRG)
#05 jwaves: MarduShadow (WBR)
#06 AbelMolto: Burn (WRG)
#07 Dlihchtarw: RakdosMidrange (BR)
#08 danidpf: ThopterUrza (UBR)
#09 Haricot-Rouge: Mill (UB, Lurrus)
#10 yamakiller: Neobrand (UG)
#11 sinforlife54: MonoWhiteTaxes (W)
#12 gurig: Devoted (WG)
#13 yPrincipe: PrimevalTitan (WRG)
#14 ocelot823: RakdosMidrange (BR)
#15 wefald: Inverter (UB)
#16 ThiGuyAgain365164: OboshAggro (R, Obosh)
#17 istillhaveeczema: GrixisShadow (UBR)
#18 Leviathan102: KGCAmuletTitan (URG)
#19 Gandalf_the_Grey: JeskaiControl (WUR)
#20 DoctorQueller: Spirits (WU)
#21 midnuzzles: MarduMidrange (WBR)
#22 BenMishania: GruulMidrange (RG)
#23 LuckyOnline: BushwhackerZoo (WRG)
#24 GanYanCHN: Belcher (RG)
#25 antonio00: GruulMidrange (RG)
#26 Mordeka1ser: BringToNiv (WUBRG, Yorion)
#27 jsmall: GoryoReanimator (UBR)
#28 Capiplaf95: Burn (WR)
#29 chaba_lol: HammerTime (W)
#30 renatoaraujo: KGCTron (G)
#31 DFrank: WURGControl (WURG)
#32 Aphiladon: HardenedScales (G)
#33 SpiderSpace: MonoWhiteTaxes (W)
#34 HotBread: NayaLandfall (WRG, Lurrus)
#35 Kurusu: KikiChord (WRG, Yorion)
#36 jtl005: HeliodCombo (W, Lurrus)
#37 OptimusBro: AdNauseam (WUB)
#38 DFrank: TemurControl (URG)
#39 Mlgb92: DubiousChallenge (WRG)
#40 Kk-: OrzhovEldraziTaxes (WB)
#41 B1gDan: Delver (UR)
#42 phillydrew215: BantMidrange (WUG)
#43 ballestin93: Mill (UB)
#44 F6tmh: Yawgmoth (BG)
#45 Gods_Shadow: AzoriusControl (WU)
#46 XxquestionablyawesomexX: Bogles (WG, Lurrus)
#47 aarongulevich: Scapeshift (URG)
#48 Trebz: AzoriusControl (WU)
#49 Roxas_13: IzzetProwess (UR)
#50 POC: Infect (BG, Lurrus)
#51 kingoftheelves: AbzanMidrange (WBG)
#52 camr0n_1: JeskaiControl (WUR)
#53 kingoftheelves: JundMidrange (BRG)
#54 kensportsfan: MonoRedProwess (R)
#55 bobthyllama2: HeliodCombo (WG)
#56 TheTunnelingCat: ETron (C)
#57 MagicDevil666: UTron (U)
#58 Borjillamtg10: RakdosProwess (BR, Lurrus)
#59 Kuhb: ShadowProwess (BRG)
#60 TuggaNaxos: Mill (WU, Lurrus)
#61 manu_chao: SultaiControl (UBG)
#62 wutang08: JundShadow (BRG)
#63 JONABSF: Infect (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_09_22 : EventTest
    {
        [Test]
        public void Deck01_lukystrike_SelenyaTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",0),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck02_DoctorQueller_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",1),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck03_superaitch_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-09-22",2),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck04_UnstableJoker_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_jwaves_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-league-2020-09-22",4),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck06_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",5),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Dlihchtarw_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-22",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_danidpf_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-22",7),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_HaricotRouge_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-22",8),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_yamakiller_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",9),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck11_sinforlife54_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-09-22",10),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck12_gurig_Devoted_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",11),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck13_yPrincipe_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",12),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck14_ocelot823_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-22",13),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_wefald_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-09-22",14),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck16_ThiGuyAgain365164_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-09-22",15),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck17_istillhaveeczema_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-22",16),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Leviathan102_KGCAmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",17),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck19_GandalftheGrey_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-09-22",18),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-22",19),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck21_midnuzzles_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-09-22",20),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_BenMishania_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",21),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_LuckyOnline_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",22),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck24_GanYanCHN_Belcher_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",23),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck25_antonio00_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",24),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Mordeka1ser_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-22",25),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_jsmall_GoryoReanimator_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-22",26),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GoryoReanimator),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Capiplaf95_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-09-22",27),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck29_chabalol_HammerTime_W()
        {
            Test(
                GetDeck("modern-league-2020-09-22",28),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck30_renatoaraujo_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-09-22",29),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck31_DFrank_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",30),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Aphiladon_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-09-22",31),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck33_SpiderSpace_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-09-22",32),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck34_HotBread_NayaLandfall_WRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-22",33),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(NayaLandfall),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck35_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-22",34),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck36_jtl005_HeliodCombo_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-22",35),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HeliodCombo),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck37_OptimusBro_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-09-22",36),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck38_DFrank_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",37),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Mlgb92_DubiousChallenge_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",38),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(DubiousChallenge),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Kk_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-09-22",39),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck41_B1gDan_Delver_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-22",40),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(Delver),
                null,
                null
            );
        }

        [Test]
        public void Deck42_phillydrew215_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",41),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck43_ballestin93_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-09-22",42),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck44_F6tmh_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",43),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck45_GodsShadow_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-22",44),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck46_XxquestionablyawesomexX_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-22",45),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck47_aarongulevich_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",46),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Trebz_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-22",47),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Roxas13_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-22",48),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck50_POC_Infect_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-22",49),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck51_kingoftheelves_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",50),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck52_camr0n1_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-09-22",51),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck53_kingoftheelves_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",52),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck54_kensportsfan_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-09-22",53),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck55_bobthyllama2_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",54),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck56_TheTunnelingCat_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-09-22",55),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck57_MagicDevil666_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-09-22",56),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck58_Borjillamtg10_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-22",57),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck59_Kuhb_ShadowProwess_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",58),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck60_TuggaNaxos_Mill_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-22",59),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck61_manuchao_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",60),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck62_wutang08_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",61),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck63_JONABSF_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-22",62),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }


    }
}
