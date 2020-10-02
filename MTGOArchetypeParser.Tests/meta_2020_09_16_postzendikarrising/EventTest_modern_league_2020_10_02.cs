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
#01 benchsummer: UBRGShadow (UBRG)
#02 PvtEnormous: UBRGControl (UBRG)
#03 crazyklicker: Devoted (WG, Lurrus)
#04 D00mwake: Belcher (URG)
#05 Ozymandias17: JundProwess (BRG, Lurrus)
#06 stefanocanclini: SaheeliCombo (WUR)
#07 Azuregun: KGCAmuletTitan (WUBRG)
#08 muckymuck_dc5: MonoWhiteTaxes (W)
#09 AJRubenstein: MonoWhiteEldraziTaxes (W)
#10 Surpriz3: GrixisControl (UBR)
#11 Fabrioteo: GruulMidrange (RG)
#12 Kr0k39: SnoopGoblins (BR)
#13 sfitz: ThopterUrza (UBR)
#14 woetert: Mill (UB)
#15 Mordeka1ser: BringToNiv (WUBRG, Yorion)
#16 Red_Beam: SelenyaMidrange (WG)
#17 Stoonian: AdNauseam (WUB)
#18 merliche: BantBlink (WUG, Yorion)
#19 Eyedea90: Mill (UB)
#20 E_Kaminuma: HeliodCombo (WG)
#21 Eotoi: OrzhovMidrange (WB)
#22 llabmonkey: BantMidrange (WUG)
#23 Borjillamtg10: RakdosProwess (BR, Lurrus)
#24 Musagete: OrzhovEldraziTaxes (WB)
#25 Gautcho: OopsAllSpells (WUBRG)
#26 TheWonderLord: GolgariMidrange (BG)
#27 yumad3988: OrzhovShadow (WB)
#28 dabiggestb: NinjaFaeries (WUB)
#29 willpulliam: AmuletTitan (UBRG)
#30 MaybeLotuses: JundMidrange (BRG)
#31 MaLiam: Humans (WUBRG)
#32 balltap: JeskaiBreach (WURG, Jegantha)
#33 Keggers: SultaiControl (UBG)
#34 RiceTackler: GiftsStorm (UR)
#35 Esqpoe: GruulMidrange (RG)
#36 GrandpaBiceps: MarduMidrange (WBR)
#37 MyNameTidus: Elementals (WUBRG, Kaheera)
#38 vebbing12: Infect (WUG)
#39 nahuel10: IzzetProwess (UR)
#40 AlphaBlade: ETron (C)
#41 FestiFan: SnowSaheeli (WURG, Yorion)
#42 Beenew: ShadowProwess (BR, Lurrus)
#43 Imfranlv: Burn (WR)
#44 Gods_Shadow: GrixisControl (UBR)
#45 egadd2894: BringToNiv (WUBRG, Jegantha)
#46 joohyun: JeskaiControl (WUR)
#47 AstralPlane: MonoRedProwess (R, Jegantha)
#48 Rebus8: BorosTaxes (WR)
#49 teeve: KGCTron (G)
#50 ivanguille: GrixisShadow (UBR, Lurrus)
#51 Parrit: MonoWhiteTaxes (W)
#52 Pepi94: Dredge (BRG)
#53 Leviathan102: PrimevalTitan (WRG)
#54 Dwarshadow: BantSpirits (WUG)
#55 Magicofplayer1: AzoriusControl (WU)
#56 Aphiladon: HardenedScales (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_10_02 : EventTest
    {
        [Test]
        public void Deck01_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",0),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck02_PvtEnormous_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",1),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_crazyklicker_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-02",2),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_D00mwake_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",3),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Ozymandias17_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-02",4),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_stefanocanclini_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-02",5),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Azuregun_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",6),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_muckymuckdc5_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-10-02",7),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck09_AJRubenstein_MonoWhiteEldraziTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-10-02",8),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Surpriz3_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-02",9),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Fabrioteo_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",10),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Kr0k39_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-02",11),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck13_sfitz_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-02",12),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck14_woetert_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-02",13),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Mordeka1ser_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-02",14),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_RedBeam_SelenyaMidrange_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",15),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Stoonian_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-10-02",16),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck18_merliche_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-02",17),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Eyedea90_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-02",18),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck20_EKaminuma_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",19),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Eotoi_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-10-02",20),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_llabmonkey_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",21),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Borjillamtg10_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-02",22),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_Musagete_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-10-02",23),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Gautcho_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",24),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck26_TheWonderLord_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",25),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_yumad3988_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-league-2020-10-02",26),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck28_dabiggestb_NinjaFaeries_WUB()
        {
            Test(
                GetDeck("modern-league-2020-10-02",27),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(NinjaFaeries),
                null,
                null
            );
        }

        [Test]
        public void Deck29_willpulliam_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",28),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck30_MaybeLotuses_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",29),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_MaLiam_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",30),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck32_balltap_JeskaiBreach_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-02",31),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck33_Keggers_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",32),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_RiceTackler_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-02",33),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Esqpoe_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",34),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck36_GrandpaBiceps_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-10-02",35),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck37_MyNameTidus_Elementals_WUBRG_Kaheera()
        {
            Test(
                GetDeck("modern-league-2020-10-02",36),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck38_vebbing12_Infect_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",37),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck39_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-02",38),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck40_AlphaBlade_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-10-02",39),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck41_FestiFan_SnowSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-02",40),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(SnowSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck42_Beenew_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-02",41),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck43_Imfranlv_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-02",42),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck44_GodsShadow_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-02",43),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck45_egadd2894_BringToNiv_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-02",44),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck46_joohyun_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-02",45),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_AstralPlane_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-02",46),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck48_Rebus8_BorosTaxes_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-02",47),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck49_teeve_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-10-02",48),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck50_ivanguille_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-02",49),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck51_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-10-02",50),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Pepi94_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",51),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Leviathan102_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",52),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck54_Dwarshadow_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-02",53),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck55_Magicofplayer1_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-02",54),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Aphiladon_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-10-02",55),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }


    }
}
