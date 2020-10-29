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
#02 MHayashi: Mono Red Prowess (R, Jegantha)
#03 cypriankrzysztof: Slivers (WUBRG)
#04 Cherryxman: Scapeshift (URG)
#05 MrRaeb: Izzet Prowess (UR)
#06 Fabrice_K: Gruul Eldrazi (RG)
#07 SKAIANET: Esper Control (WUB)
#08 Tiemuuu: Izzet Control (UR)
#09 polinasgiuleppe: Gruul Midrange (RG)
#10 djbmppwns: Jund Shadow (BRG, Lurrus)
#11 keytolife: Rakdos Midrange (BR, Lurrus)
#12 ArchaeusDota: Bring To Niv (WUBRG, Yorion)
#13 imposterbatman: Burn (WR)
#14 fabee1: Selenya Taxes (WG)
#15 Ladon: Snow Saheeli (WURG)
#16 mogis67: Sultai Control (UBG)
#17 omgitztommy: Incinerator Burn (R)
#18 Rossello: Ad Nauseam (WUB)
#19 CodeProvider: Grishoalbrand (BR)
#20 cnofafva: KGC Amulet Titan (WUBRG)
#21 WebZone: Humans (WUBRG)
#22 kotka: Bogles (WG)
#23 nikkuniku: Cremator Evolution (WRG)
#24 A22en: Snoop Goblins (BR)
#25 junghans: Devoted (WRG)
#26 unicornparadise: Tokens (W)
#27 _VFS_: Jund Midrange (BRG)
#28 HomerJay: Azorius Control (WU)
#29 Zetii: Mono White Taxes (W)
#30 Easyldur1: Dredge (WBRG)
#31 timewalkinonsunshine: Taking Turns (URG)
#32 Ravul: KGC Tron (G)
#33 Mhawaii05: Jund Midrange (BRG)
#34 AndersPovirk: Mono Red Prowess (R)
#35 Mussie99: Azorius Control (WU)
#36 sambran414: Hardened Scales (WG, Lurrus)
#37 utopia_mycon: Skred Red (R)
#38 TBagTom: UBRG Control (UBRG)
#39 MagicalHack99: E Tron (C)
#40 Brosterman: Bant Midrange (WUG)
#41 sanetomi: Crabvine (UBRG)
#42 Ayzkub_: Primeval Titan (BRG)
#43 Curryvore: Azorius Blink (WU)
#44 jtl005: Bant Blink (WUG)
#45 andresambiaze: Hardened Scales (G)
#46 EdB: Skelementals (BR)
#47 FunkiMunki: Elementals (WUBRG)
#48 hoveydw: Grixis Shadow (UBR)
#49 Chaughey: Jeskai Delver (WUR)
#50 qbturtle15: Boros Sunforger (WR)
#51 FM3: Red Prison (R)
#52 Huggbees: Rakdos Midrange (BR)
#53 BaronOfBacon: UBRG Shadow (UBRG)
#54 sps: Jeskai Control (WUR)
#55 jamiieJR: Infect (UG)
#56 DLCabelo: Yawgmoth (BG)
#57 hugofreitas1: Gifts Storm (UR)
#58 fpawlusz: Bant Control (WUG)
#59 ranspach17: Selenya Eldrazi Taxes (WG)
#60 Albyz: Izzet Restore Balance (URG)
#61 MartinezDP: Naya Midrange (WRG)
#62 TwistedWombat: Golgari Midrange (BG)
#63 Metcalf23: Thalia Stompy (WR)
#64 konoyubitomare15: Bant Midrange (WUG)
#65 DoctorQueller: Spirits (WU)
#66 tcgshin: Titan Shift (RG)
#67 ArchonBlue: Blue Living End (WURG)
#68 kogamo: Sultai Reclamation (UBG)
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
        public void Deck02_MHayashi_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-21",1),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
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
        public void Deck05_MrRaeb_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
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
                typeof(GenericControl),
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
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_polinasgiuleppe_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",8),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_djbmppwns_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-21",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
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
                typeof(GenericMidrange),
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
        public void Deck14_fabee1_SelenyaTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Ladon_SnowSaheeli_WURG()
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
        public void Deck16_mogis67_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",15),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_omgitztommy_IncineratorBurn_R()
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
        public void Deck20_cnofafva_KGCAmuletTitan_WUBRG()
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
        public void Deck24_A22en_SnoopGoblins_BR()
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
        public void Deck27_VFS_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",26),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
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
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Zetii_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-21",28),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
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
        public void Deck32_Ravul_KGCTron_G()
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
        public void Deck33_Mhawaii05_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",32),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck34_AndersPovirk_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-21",33),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Mussie99_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-21",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
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
        public void Deck38_TBagTom_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",37),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
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
        public void Deck40_Brosterman_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
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
        public void Deck43_Curryvore_AzoriusBlink_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-21",42),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericBlink),
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
                typeof(GenericBlink),
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
        public void Deck48_hoveydw_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",47),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Chaughey_JeskaiDelver_WUR()
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
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck53_BaronOfBacon_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",52),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck54_sps_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",53),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
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
        public void Deck58_fpawlusz_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",57),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck59_ranspach17_SelenyaEldraziTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",58),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck60_Albyz_IzzetRestoreBalance_URG()
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
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck62_TwistedWombat_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",61),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck63_Metcalf23_ThaliaStompy_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-21",62),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(ThaliaStompy),
                null,
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
                typeof(GenericMidrange),
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
        public void Deck66_tcgshin_TitanShift_RG()
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
        public void Deck67_ArchonBlue_BlueLivingEnd_WURG()
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
        public void Deck68_kogamo_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-21",67),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }


    }
}
