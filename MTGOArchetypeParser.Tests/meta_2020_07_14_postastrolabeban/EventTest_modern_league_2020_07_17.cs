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
#01 Wuhsa: Bring To Niv (WUBRG, Yorion)
#02 CedricChatel: Izzet Control (UR)
#03 Cherryxman: Crabvine (UBG)
#04 rodeo: Incinerator Burn (R)
#05 PanCement_JP: Bant Spirits (WUG)
#06 cntrlfreak: UBRG Shadow (UBRG)
#07 Dwagz: Grixis Shadow (UBR)
#08 saccij92: Humans (WUBRG)
#09 Fabrioteo: E Tron (C)
#10 maple049: Hardened Scales (WG, Lurrus)
#11 kogamo: Azorius Control (WU)
#12 Silence9428: Infect (UG)
#13 moutierdu42: Amulet Titan (WUBRG)
#14 Elibaechan: Snoop Goblins (BR)
#15 MinCash: Ad Nauseam (WUB)
#16 bkorbsquare07: Boros Prowess (WR)
#17 ContraEgo: Thopter Urza (UBR)
#18 CitrusD: Yawgmoth (BG)
#19 argentopnz88: Izzet Prowess (UR)
#20 chengyiw: Izzet Prowess (UR)
#21 austinflakesss: Neobrand (UG)
#22 Salty_Steve: Ninja Faeries (UB)
#23 yuseimax: Soulflayer (BRG)
#24 _Shatun_: Gruul Midrange (RG)
#25 OscarS66: Rakdos Midrange (BR)
#26 Zxrogue: Kiki Chord (WURG, Yorion)
#27 Zebrah: Boros Taxes (WR, Lurrus)
#28 nahuel10: Bant Reclamation (WUG)
#29 NHA37: Burn (WR)
#30 TubbyBatman: Temur Delver (URG)
#31 jundecide: Golgari Midrange (BG)
#32 Gleiciano: G Tron (G)
#33 Goteo: Scapeshift (URG)
#34 TheLousyZoot: Snoop Goblins (BR)
#35 aspiringspike: Izzet Restore Balance (URG)
#36 6argamel: Boros Taxes (WR)
#37 GHash77: Bant Midrange (WUG)
#38 bubbsei: Devoted (WG, Lurrus)
#39 Oliver_Hart: Hardened Scales (G)
#40 pbarrrgh: Azorius Control (WU)
#41 Bruno_Mineiro: Mono White Taxes (W)
#42 jimdownside: Dredge (WBRG)
#43 teagantime: Sultai Reclamation (UBG)
#44 tanisong1221: Orzhov Shadow (WB)
#45 Pirika: Saheeli Combo (WUR)
#46 llabmonkey: Jund Midrange (BRG)
#47 hugofreitas1: Gifts Storm (UR)
#48 KYUNphago: Mono Red Prowess (R)
#49 BubbleDJ10: Bogles (WG, Lurrus)
#50 MHayashi: Mono Red Prowess (R, Jegantha)
#51 CNewman: Jund Midrange (BRG)
#52 Pendragon15038: Merfolk (U)
#53 Pirika: Izzet Living End (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_07_17 : EventTest
    {
        [Test]
        public void Deck01_Wuhsa_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-17",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_CedricChatel_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Cherryxman_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck04_rodeo_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-07-17",3),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck05_PanCementJP_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck06_cntrlfreak_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Dwagz_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",6),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck08_saccij92_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Fabrioteo_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-17",8),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_maple049_HardenedScales_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-17",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_kogamo_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-17",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Silence9428_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck13_moutierdu42_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck14_Elibaechan_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",13),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck15_MinCash_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-17",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck16_bkorbsquare07_BorosProwess_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck17_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck18_CitrusD_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck19_argentopnz88_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck20_chengyiw_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",19),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck21_austinflakesss_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck22_SaltySteve_NinjaFaeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-17",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(NinjaFaeries),
                null,
                null
            );
        }

        [Test]
        public void Deck23_yuseimax_Soulflayer_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",22),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Soulflayer),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",23),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_OscarS66_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",24),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Zxrogue_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-17",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_Zebrah_BorosTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-17",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_nahuel10_BantReclamation_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck29_NHA37_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck30_TubbyBatman_TemurDelver_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",29),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Delver),
                typeof(TemurDelver),
                null
            );
        }

        [Test]
        public void Deck31_jundecide_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Gleiciano_GTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-17",31),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Goteo_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",32),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck34_TheLousyZoot_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",33),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck35_aspiringspike_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",34),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck36_6argamel_BorosTaxes_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",35),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck37_GHash77_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck38_bubbsei_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-17",37),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck39_OliverHart_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-07-17",38),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck40_pbarrrgh_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-17",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck41_BrunoMineiro_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-17",40),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck42_jimdownside_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck43_teagantime_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",42),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck44_tanisong1221_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-17",43),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Pirika_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",44),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck46_llabmonkey_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",45),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",46),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck48_KYUNphago_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-17",47),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck49_BubbleDJ10_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-17",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck50_MHayashi_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-17",49),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck51_CNewman_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-17",50),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Pendragon15038_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-07-17",51),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Pirika_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-17",52),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetLivingEnd),
                null
            );
        }


    }
}
