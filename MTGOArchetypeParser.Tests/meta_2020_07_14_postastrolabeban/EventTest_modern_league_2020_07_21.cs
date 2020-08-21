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
#01 WingedHussar: Neobrand (UG, Yorion)
#02 MHayashi: RedDeckWins (R, Jegantha)
#03 cypriankrzysztof: Slivers (WUBRG)
#04 Cherryxman: Scapeshift (URG)
#05 MrRaeb: IzzetProwess (UR)
#06 Fabrice_K: GruulEldrazi (RG)
#07 SKAIANET: EsperControl (WUB)
#08 Tiemuuu: IzzetControl (UR)
#09 polinasgiuleppe: Ponza (RG)
#10 djbmppwns: SuicideShadow (BRG, Lurrus)
#11 keytolife: RakdosMidrange (BR, Lurrus)
#12 ArchaeusDota: BringToNiv (WUBRG, Yorion)
#13 imposterbatman: Burn (WR)
#14 fabee1: DeathAndTaxes (WG)
#15 Ladon: SnowSaheeli (WURG)
#16 mogis67: SultaiSnow (UBG)
#17 omgitztommy: IncineratorBurn (R)
#18 Rossello: AdNauseam (WUB)
#19 CodeProvider: Grishoalbrand (BR)
#20 cnofafva: KGCAmuletTitan (WUBRG)
#21 WebZone: Humans (WUBRG)
#22 kotka: Bogles (WG)
#23 nikkuniku: CrematorEvolution (WRG)
#24 A22en: SnoopGoblins (BR)
#25 junghans: Devoted (WRG)
#26 unicornparadise: Tokens (W)
#27 _VFS_: Jund (BRG)
#28 HomerJay: AzoriusControl (WU)
#29 Zetii: DeathAndTaxes (W)
#30 Easyldur1: Dredge (WBRG)
#31 timewalkinonsunshine: TakingTurns (URG)
#32 Ravul: KGCTron (G)
#33 Mhawaii05: Jund (BRG)
#34 AndersPovirk: Prowess (R)
#35 Mussie99: AzoriusStoneblade (WU)
#36 sambran414: HardenedScales (WG, Lurrus)
#37 utopia_mycon: SkredRed (R)
#38 TBagTom: SultaiSnow (UBRG)
#39 MagicalHack99: ETron (C)
#40 Brosterman: SnowBlade (WUG)
#41 sanetomi: Crabvine (UBRG)
#42 Ayzkub_: PrimevalTitan (BRG)
#43 Curryvore: AzoriousBlink (WU)
#44 jtl005: BantBlink (WUG)
#45 andresambiaze: HardenedScales (G)
#46 EdB: Skelementals (BR)
#47 FunkiMunki: Elementals (WUBRG)
#48 hoveydw: GrixisShadow (UBR)
#49 Chaughey: JeskaiDelver (WUR)
#50 qbturtle15: BorosSunforger (WR)
#51 FM3: RedPrison (R)
#52 Huggbees: RakdosMidrange (BR)
#53 BaronOfBacon: TraverseShadow (UBRG)
#54 sps: JeskaiStoneblade (WUR)
#55 jamiieJR: Infect (UG)
#56 DLCabelo: Yawgmoth (BG)
#57 hugofreitas1: GiftsStorm (UR)
#58 fpawlusz: SnowBlade (WUG)
#59 ranspach17: EldraziTaxes (WG)
#60 Albyz: IzzetRestoreBalance (URG)
#61 MartinezDP: NayaMidrange (WRG)
#62 TwistedWombat: Rock (BG)
#63 Metcalf23: ThaliaStompy (WR)
#64 konoyubitomare15: BantMidrange (WUG)
#65 DoctorQueller: Spirits (WU)
#66 tcgshin: TitanShift (RG)
#67 ArchonBlue: BlueLivingEnd (WURG)
#68 kogamo: SnowReclamation (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_07_21 : EventTest
    {
        [Test]
        public void Deck01_WingedHussar_Neobrand_UG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-21",0),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_MHayashi_RedDeckWins_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-21",1),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck03_cypriankrzysztof_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Cherryxman_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",3),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck05_MrRaeb_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck06_FabriceK_GruulEldrazi_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",5),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GruulEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck07_SKAIANET_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-21",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(EsperControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_polinasgiuleppe_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",8),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck10_djbmppwns_DeathsShadow_SuicideShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-21",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(SuicideShadow),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_keytolife_RakdosMidrange_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-21",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_ArchaeusDota_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-21",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_imposterbatman_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck14_fabee1_DeathAndTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Ladon_SaheeliCombo_SnowSaheeli_WURG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(SnowSaheeli),
                null
            );
        }

        [Test]
        public void Deck16_mogis67_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",15),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck17_omgitztommy_Burn_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-07-21",16),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck18_Rossello_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-21",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck19_CodeProvider_Grishoalbrand_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",18),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Grishoalbrand),
                null,
                null
            );
        }

        [Test]
        public void Deck20_cnofafva_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck21_WebZone_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",20),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck22_kotka_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck23_nikkuniku_CrematorEvolution_WRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(CrematorEvolution),
                null,
                null
            );
        }

        [Test]
        public void Deck24_A22en_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",23),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck25_junghans_Devoted_WRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck26_unicornparadise_Tokens_W()
        {
            Test(
                GetDeck("modern-league-2020-07-21",25),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck27_VFS_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",26),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck28_HomerJay_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-21",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Zetii_DeathAndTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-21",28),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Easyldur1_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck31_timewalkinonsunshine_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",30),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Ravul_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-21",31),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck33_Mhawaii05_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",32),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck34_AndersPovirk_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-21",33),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Mussie99_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-21",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck36_sambran414_HardenedScales_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-21",35),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck37_utopiamycon_SkredRed_R()
        {
            Test(
                GetDeck("modern-league-2020-07-21",36),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(SkredRed),
                null,
                null
            );
        }

        [Test]
        public void Deck38_TBagTom_SnowControl_SultaiSnow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",37),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck39_MagicalHack99_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-21",38),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Brosterman_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck41_sanetomi_Crabvine_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",40),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Ayzkub_PrimevalTitan_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",41),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Curryvore_AzoriousBlink_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-21",42),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriousBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck44_jtl005_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",43),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck45_andresambiaze_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-07-21",44),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck46_EdB_Skelementals_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",45),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Skelementals),
                null,
                null
            );
        }

        [Test]
        public void Deck47_FunkiMunki_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",46),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck48_hoveydw_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",47),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck49_Chaughey_Delver_JeskaiDelver_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(Delver),
                typeof(JeskaiDelver),
                null
            );
        }

        [Test]
        public void Deck50_qbturtle15_BorosSunforger_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",49),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(BorosSunforger),
                null,
                null
            );
        }

        [Test]
        public void Deck51_FM3_RedPrison_R()
        {
            Test(
                GetDeck("modern-league-2020-07-21",50),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Huggbees_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",51),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck53_BaronOfBacon_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",52),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck54_sps_JeskaiControl_JeskaiStoneblade_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",53),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                typeof(JeskaiStoneblade),
                null
            );
        }

        [Test]
        public void Deck55_jamiieJR_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",54),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck56_DLCabelo_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",55),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck57_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",56),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck58_fpawlusz_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",57),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck59_ranspach17_DeathAndTaxes_EldraziTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",58),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck60_Albyz_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",59),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck61_MartinezDP_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",60),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(NayaMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck62_TwistedWombat_Rock_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",61),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck63_Metcalf23_DeathAndTaxes_ThaliaStompy_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",62),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                typeof(ThaliaStompy),
                null
            );
        }

        [Test]
        public void Deck64_konoyubitomare15_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",63),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck65_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-21",64),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck66_tcgshin_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",65),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck67_ArchonBlue_LivingEnd_BlueLivingEnd_WURG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",66),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(LivingEnd),
                typeof(BlueLivingEnd),
                null
            );
        }

        [Test]
        public void Deck68_kogamo_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",67),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }


    }
}
