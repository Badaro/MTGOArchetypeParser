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
#01 coliobeware: RakdosShadow (BR, Lurrus)
#02 Ivc: AzoriusControl (WU)
#03 GanYanCHN: SultaiControl (UBG)
#04 Metcalf23: MonoWhiteTaxes (W)
#05 egadd2894: BringToNiv (WUBRG)
#06 blavantasian: AdNauseam (WUB)
#07 Borjillamtg10: RakdosProwess (BR, Lurrus)
#08 PieGonti: Humans (WUBRG)
#09 istillhaveeczema: GrixisShadow (UBR)
#10 tendercloud: HardenedScales (G)
#11 mathcore: IncineratorBurn (R, Jegantha)
#12 midcardpromo: GruulMidrange (RG)
#13 GGBud1717: IzzetProwess (UR)
#14 chaba_lol: HammerTime (W)
#15 musasabi: OrzhovMidrange (WB)
#16 GanYanCHN: Belcher (RG)
#17 Iplantz: Devoted (WUG)
#18 camr0n_1: AmuletTitan (UBRG)
#19 TheTunnelingCat: ETron (C)
#20 Bobthebuilder24: HeliodSisters (W)
#21 balltap: JeskaiBreach (WURG, Jegantha)
#22 SknerusMcKwacz: OopsAllSpells (WUBRG)
#23 audio336: JundShadow (BRG, Lurrus)
#24 Czechito: Elementals (WR)
#25 ST0NEHE4RT: MonoRedProwess (R, Obosh)
#26 LordOfDarkness25: Bogles (WG)
#27 _LSN_: Burn (WR)
#28 MagicalHack99: KGCAmuletTitan (WUBRG)
#29 BSK_hercules: WURGControl (WURG)
#30 zbishop: SelenyaTaxes (WG)
#31 Munich_Casual: Spirits (WU)
#32 haubidtran: TemurReclamation (URG)
#33 Ptery: JeskaiControl (WUR)
#34 Bugsy69: ThopterUrza (WUR)
#35 kensportsfan: MonoRedProwess (R)
#36 ImmanuelKantrolGod: JeskaiControl (WUR)
#37 Karolmo: Mill (UB)
#38 foobaj: UBRGShadow (UBRG)
#39 Laplasjan: Devoted (WG, Lurrus)
#40 Antoine57437: AbzanCompany (WBRG)
#41 hermanomlg: BantMidrange (WUG)
#42 joetru: JundMidrange (BRG)
#43 cws: GiftsStorm (UR)
#44 CobaltOak: AzoriusControl (WU)
#45 Bangood: Mill (UB, Lurrus)
#46 kurohiren: BringToNiv (WUBRG, Yorion)
#47 Asoen: RakdosMidrange (BR)
#48 TheRealStormCrow: KikiChord (WURG, Yorion)
#49 Leyline_of_the_Cat: BantSpirits (WUG)
#50 lovealienzzz: AzoriusControl (WU, Yorion)
#51 _Makaveli: AzoriusControl (WU)
#52 SvenSveeterSven: IzzetControl (UR)
#53 Athanbak: Merfolk (UB)
#54 MruLoNGx: KGCTron (G)
#55 MagicDevil666: UTron (U)
#56 HLG42: Mill (UB, Lurrus)
#57 BrokenPots_CB: KikiChord (WRG, Yorion)
#58 Quikeglez99: Dredge (BRG)
#59 Daking3603: PrimevalTitan (WRG)
#60 MTGBullent: HeliodCombo (WG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_09_25 : EventTest
    {
        [Test]
        public void Deck01_coliobeware_RakdosShadow_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-25",0),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-25",1),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_GanYanCHN_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",2),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Metcalf23_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-09-25",3),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck05_egadd2894_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",4),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck06_blavantasian_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-09-25",5),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Borjillamtg10_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-25",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_PieGonti_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",7),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck09_istillhaveeczema_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-25",8),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck10_tendercloud_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-09-25",9),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck11_mathcore_IncineratorBurn_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-09-25",10),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck12_midcardpromo_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",11),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_GGBud1717_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-25",12),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_chabalol_HammerTime_W()
        {
            Test(
                GetDeck("modern-league-2020-09-25",13),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck15_musasabi_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-09-25",14),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_GanYanCHN_Belcher_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",15),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Iplantz_Devoted_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",16),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck18_camr0n1_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",17),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck19_TheTunnelingCat_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-09-25",18),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Bobthebuilder24_HeliodSisters_W()
        {
            Test(
                GetDeck("modern-league-2020-09-25",19),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(SoulSisters),
                typeof(HeliodSisters),
                null
            );
        }

        [Test]
        public void Deck21_balltap_JeskaiBreach_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-09-25",20),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_SknerusMcKwacz_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",21),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck23_audio336_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-25",22),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_Czechito_Elementals_WR()
        {
            Test(
                GetDeck("modern-league-2020-09-25",23),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck25_ST0NEHE4RT_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-09-25",24),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck26_LordOfDarkness25_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",25),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck27_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-09-25",26),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck28_MagicalHack99_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",27),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck29_BSKhercules_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",28),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_zbishop_SelenyaTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",29),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck31_MunichCasual_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-25",30),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck32_haubidtran_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",31),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Ptery_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-09-25",32),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Bugsy69_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-league-2020-09-25",33),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck35_kensportsfan_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-09-25",34),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck36_ImmanuelKantrolGod_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-09-25",35),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Karolmo_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-09-25",36),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck38_foobaj_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",37),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-25",38),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck40_Antoine57437_AbzanCompany_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",39),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(AbzanCompany),
                null,
                null
            );
        }

        [Test]
        public void Deck41_hermanomlg_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",40),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck42_joetru_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",41),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck43_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-25",42),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck44_CobaltOak_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-25",43),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Bangood_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-25",44),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck46_kurohiren_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-25",45),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck47_Asoen_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-25",46),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck48_TheRealStormCrow_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-25",47),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck49_LeylineoftheCat_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",48),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck50_lovealienzzz_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-25",49),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck51_Makaveli_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-25",50),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-25",51),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Athanbak_Merfolk_UB()
        {
            Test(
                GetDeck("modern-league-2020-09-25",52),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck54_MruLoNGx_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-09-25",53),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck55_MagicDevil666_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-09-25",54),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck56_HLG42_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-25",55),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck57_BrokenPotsCB_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-09-25",56),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck58_Quikeglez99_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",57),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck59_Daking3603_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",58),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck60_MTGBullent_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-25",59),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }


    }
}
