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
#01 Tarrasque1: Elementals (WUBRG)
#02 Mateusf34: ETron (C)
#03 Wuhsa: BringToNiv (WUBRG)
#04 HeyPharaoh: AzoriusControl (WU)
#05 Teston: GiftsStorm (UR, Jegantha)
#06 cftsoc3: BantBlink (WUG, Yorion)
#07 Jakesbaked: Scapeshift (URG)
#08 PaChA94s: AdNauseam (WUB)
#09 Sonso JF: HeliodDevoted (WBG)
#10 cfilly4460: GolosTron (G, Jegantha)
#11 matyo804: Winota (WRG)
#12 kaikalbuquerque: Bogles (WG)
#13 Matts: Dredge (BRG)
#14 WotC_AndrewB: MonoWhiteTaxes (W)
#15 Madwolf87: JundShadow (BRG)
#16 fupalorda: IzzetRestoreBalance (URG)
#17 litianshuo670: OrzhovEldraziTaxes (WB)
#18 thepensword: IzzetControl (UR)
#19 ScreenwriterNY: WUBGControl (WUBG, Yorion)
#20 Urzza100: BantControl (WUG, Yorion)
#21 Old-bag-o-bones: Smallpox (WB)
#22 Kotva: NinjaFaeries (UB)
#23 ContraEgo: ThopterUrza (UBR)
#24 Blindside09: HardenedScales (BG, Lurrus)
#25 il_matagatto: Burn (WR)
#26 DarkKeeper: WUBGControl (WUBG, Yorion)
#27 FuryGarruk: EmeriaTitan (WU)
#28 MarmotaStore: RakdosProwess (BR, Lurrus)
#29 Blademaster777: HammerTime (WR)
#30 Nagato_Boran: JundMidrange (BRG)
#31 XOPYC: MonoWhiteTaxes (W, Yorion)
#32 Traft: Infect (UG)
#33 MHayashi: RedDeckWins (R, Jegantha)
#34 hoveydw: Delver (UR)
#35 MasterA: Goblins (BRG)
#36 MrRaeb: Uroza (UBG, Yorion)
#37 C4N7O: WUBGControl (WUBG)
#38 Never_DidntHaveIt: BorosProwess (WR)
#39 Justodeangelo: Scapeshift (URG, Yorion)
#40 CordoTwin: GrixisShadow (UBR)
#41 vixyp: BantMidrange (WUG)
#42 wambocombo2020: JeskaiBreach (WURG)
#43 Diem4x: BantControl (WUG)
#44 Dfeanor: PrimevalTitan (BRG)
#45 Lucabireskusku: Inverter (UB)
#46 mrjgiles: UTron (U)
#47 sandoiche: TitanShift (RG)
#48 kyon1024: Polymorph (WUBRG, Yorion)
#49 Girolamo1996: Humans (WUBRG)
#50 Rvng: MonoRedProwess (R)
#51 zectrooperdelta: IzzetControl (UR)
#52 TscheggschDePoegg: SultaiControl (UBG)
#53 PuNk_: TakingTurns (UR)
#54 Doomed_Necromancer: AbzanMidrange (WBG)
#55 willtheelf1: GruulMidrange (RG)
#56 Somefellow: Neobrand (UG)
#57 illwill552: SultaiControl (UBG)
#58 MartinezDP: HeliodDevoted (WUG)
#59 Kurusu: KikiChord (WBRG, Yorion)
#60 603Leb: AmuletTitan (URG)
#61 mashmalovsky: Yawgmoth (BG)
#62 Termahgerf: Uroza (WUG, Yorion)
#63 marcofabrizi: TakingTurns (URG)
#64 yriel: JundMidrange (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_league_2020_06_09 : EventTest
    {
        [Test]
        public void Deck01_Tarrasque1_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",0),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-06-09",1),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Wuhsa_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",2),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck04_HeyPharaoh_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-09",3),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Teston_GiftsStorm_UR_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-09",4),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck06_cftsoc3_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",5),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_Jakesbaked_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",6),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck08_PaChA94s_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-06-09",7),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck09_SonsoJF_HeliodDevoted_WBG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",8),
                new PostCompanionChange(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck10_cfilly4460_GolosTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-09",9),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(GolosTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck11_matyo804_Winota_WRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",10),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck12_kaikalbuquerque_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",11),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Matts_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",12),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck14_WotCAndrewB_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-06-09",13),
                new PostCompanionChange(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Madwolf87_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",14),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck16_fupalorda_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",15),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck17_litianshuo670_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-09",16),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck18_thepensword_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",17),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_ScreenwriterNY_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",18),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_Urzza100_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",19),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck21_Oldbagobones_Smallpox_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-09",20),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Kotva_NinjaFaeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-06-09",21),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(NinjaFaeries),
                null,
                null
            );
        }

        [Test]
        public void Deck23_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",22),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Blindside09_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-09",23),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_ilmatagatto_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",24),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck26_DarkKeeper_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",25),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_FuryGarruk_EmeriaTitan_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-09",26),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(EmeriaTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck28_MarmotaStore_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-09",27),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Blademaster777_HammerTime_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",28),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck30_NagatoBoran_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",29),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_XOPYC_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",30),
                new PostCompanionChange(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_Traft_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",31),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck33_MHayashi_RedDeckWins_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-09",32),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck34_hoveydw_Delver_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",33),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(Delver),
                null,
                null
            );
        }

        [Test]
        public void Deck35_MasterA_Goblins_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",34),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck36_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",35),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_C4N7O_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",36),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck38_NeverDidntHaveIt_BorosProwess_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",37),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Justodeangelo_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",38),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck40_CordoTwin_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",39),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck41_vixyp_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",40),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck42_wambocombo2020_JeskaiBreach_WURG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",41),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                null
            );
        }

        [Test]
        public void Deck43_Diem4x_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",42),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Dfeanor_PrimevalTitan_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",43),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Lucabireskusku_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-06-09",44),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck46_mrjgiles_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-06-09",45),
                new PostCompanionChange(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck47_sandoiche_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",46),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck48_kyon1024_Polymorph_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",47),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Polymorph),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck49_Girolamo1996_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",48),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Rvng_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-06-09",49),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck51_zectrooperdelta_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",50),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_TscheggschDePoegg_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",51),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck53_PuNk_TakingTurns_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-09",52),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck54_DoomedNecromancer_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",53),
                new PostCompanionChange(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck55_willtheelf1_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",54),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Somefellow_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",55),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck57_illwill552_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",56),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck58_MartinezDP_HeliodDevoted_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",57),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck59_Kurusu_KikiChord_WBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",58),
                new PostCompanionChange(),
                ArchetypeColor.WBRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck60_603Leb_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",59),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck61_mashmalovsky_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",60),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck62_Termahgerf_Uroza_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-09",61),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck63_marcofabrizi_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-09",62),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck64_yriel_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-09",63),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
